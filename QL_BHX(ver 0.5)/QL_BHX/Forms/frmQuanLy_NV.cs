using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BHX
{
    public partial class frmQuanLy_NV : Form
    {
        //Đường dẫn đến các file
        string filePath_Cities = "Cities.txt";
        string filePath_Branches = "Branches.txt";
        string filePath_Staffs = "Staffs.txt";

        //Data chứa danh sách dữ liệu
        private LinkedList<Staff> data_Staffs;
        private LinkedList<Branch> data_Branches;
        private LinkedList<City> data_City;
        /// <summary>
        /// -1: chưa chọn
        ///  0: Hành động thêm
        ///  1: Hành động sửa
        /// </summary>
        private int actLevel = -1;
        private int addType = 0;
        public frmQuanLy_NV()
        {
            InitializeComponent();
        }


        //--------------------------------------Form-------------------------------------

        /// <summary>
        /// Khi mở form, tải dữ liệu từ dataBase, đổ data vào listView và treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuanLy_NhanVien_Load(object sender, EventArgs e)
        {
            data_City = new LinkedList<City>();
            data_Branches = new LinkedList<Branch>();
            data_Staffs = new LinkedList<Staff>();

            try
            {
                //--------------------------Đọc file lấy dữ liệu------------------------------
                //Dữ liệu của các thành phố
                using(StreamReader sr = new StreamReader(filePath_Cities))
                {
                    string doc = "";
                    while((doc = sr.ReadLine()) != null)
                    {
                        string[] data = doc.Split('#');
                        City city = new City(data[0], data[1]);
                        data_City.AddLast(city);
                    }
                }
                //Dữ liệu của các chi nhánh
                using(StreamReader sr = new StreamReader(filePath_Branches))
                {
                    string doc = "";
                    while ((doc = sr.ReadLine()) != null)
                    {
                        string[] data = doc.Split('#');
                        City branch_city = null;
                        foreach(City item in data_City)
                        {
                            if(item.ID == data[data.Length - 1])
                            {
                                branch_city = item;
                            }
                        }
                        Branch branch = new Branch(data[0], data[1], data[2],branch_city);
                        data_Branches.AddLast(branch);
                    }
                }
                //Dữ liệu của các nhân viên
                using (StreamReader sr = new StreamReader(filePath_Staffs))
                {
                    string doc = "";
                    while ((doc = sr.ReadLine()) != null)
                    {
                        string[] data = doc.Split('#');
                        Branch staff_branch = null;
                        foreach (Branch item in data_Branches)
                        {
                            if (item.ID == data[data.Length - 1])
                            {
                                staff_branch = item;
                            }
                        }
                        Staff staff = new Staff(data[0], data[1], data[2], data[3], Convert.ToDateTime(data[4]), Convert.ToBoolean(data[5]), Convert.ToDouble(data[6]), staff_branch);
                        data_Staffs.AddLast(staff);
                    }
                }
            }
            catch(Exception ex)
            {
                Ultilities.popUpError(ex.Message);
            }

            ////Tạo danh sách các địa điểm
            //City dd1 = new City("01", "TPHCM");
            //City dd2 = new City("02", "Hà Nội");
            //City dd3 = new City("03", "Hải Phòng");
            //data_City.AddLast(dd1);
            //data_City.AddLast(dd2);
            //data_City.AddLast(dd3);

            ////Tạo danh sách chi nhánh
            //Branch cn1 = new Branch("0101", "Quận 1", "53 Hai Bà Trưng", dd1);
            //Branch cn2 = new Branch("0102", "Quận 2", "53 Trần Não", dd1);
            //Branch cn3 = new Branch("0103", "Quận 3", "53 Điện Biên Phủ", dd1);
            //data_Branches.AddLast(cn1);
            //data_Branches.AddLast(cn2);
            //data_Branches.AddLast(cn3);

            ////Tạo danh sách nhân viên
            //Staff nv1 = new Staff("01010001", "Lê Ngọc Cảnh", "123456789", "0569577900", DateTime.Now, true, 3500000, cn1);
            //Staff nv2 = new Staff("01020002", "Nguyễn Quang Đại", "123456987", "0569577900", new DateTime(2000, 10, 3), true, 3500000, cn2);
            //Staff nv3 = new Staff("01010003", "Trần Đức Tín", "321456987", "0569577900", DateTime.Now, true, 3500000, cn1);
            //data_Staffs.AddLast(nv1);
            //data_Staffs.AddLast(nv2);
            //data_Staffs.AddLast(nv3);

            //Thêm vào treeView danh sách các chi nhánh và địa điểm 
            foreach (City dd in data_City)
            {
                TreeNode[] treeNodes_ChiNhanh = new TreeNode[0];
                foreach (Branch cn in data_Branches)
                {
                    if (cn.City.ID == dd.ID)
                    {
                        Array.Resize(ref treeNodes_ChiNhanh, treeNodes_ChiNhanh.Length + 1);
                        treeNodes_ChiNhanh[treeNodes_ChiNhanh.Length - 1] = new TreeNode(cn.Name);
                    }
                }
                tvBranches.Nodes.Add(new TreeNode(dd.Name, treeNodes_ChiNhanh));
            }
            //Thêm vào combo box chi nhánh
            foreach (Branch cn in data_Branches)
            {
                cboStaff_Branch.Items.Add(cn.Name);
            }
            //Chọn chi nhánh hiển thị đầu đầu
            cboStaff_Branch.SelectedIndex = 0;
            //Chọn giới tính hiển thị ban đầu
            cboGender.SelectedIndex = 0;
            //Khởi tạo ID ban đầu cho nhân viên mới
            generateID("0101", data_Staffs.Last().ID);
        }
        /// <summary>
        /// Xác nhận lưu các thông tin vừa thay đổi và đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuanLy_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = Ultilities.popUpQuestion("Bạn có muốn lưu thông tin trước khi thoát ?", 1);
            if (res == DialogResult.Yes)
            {
                //Lưu thông tin đã thay đổi và thoát form này
                try
                {
                    //---------------------Ghi dữ liệu vào file---------------------
                    //Dữ liệu thành phố
                    using (StreamWriter sw = new StreamWriter(filePath_Cities))
                    {
                        foreach (City city in data_City)
                        {
                            sw.WriteLine(city.toFile());
                        }
                    }
                    //Dữ liệu chi nhánh
                    using (StreamWriter sw = new StreamWriter(filePath_Branches))
                    {
                        foreach (Branch branch in data_Branches)
                        {
                            sw.WriteLine(branch.toFile());
                        }
                    }
                    //Dữ liệu nhân viên
                    using (StreamWriter sw = new StreamWriter(filePath_Staffs))
                    {
                        foreach (Staff staff in data_Staffs)
                        {
                            sw.WriteLine(staff.toFile());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Ultilities.popUpError(ex.Message);
                }
            }
            else if (res == DialogResult.No)
            {
                //Thoát form mà không lưu thông tin
            }
            else
            {
                e.Cancel = true;
            }
        }


        //--------------------------------------TreeView--------------------------------------

        /// <summary>
        /// Chọn các node trên treeview để hiển thị danh sách listview nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvBranches_AfterSelect(object sender, TreeViewEventArgs e)
        {
            showList(tvBranches.SelectedNode.Text);
        }


        //--------------------------------------ListView--------------------------------------

        /// <summary>
        /// Chọn nhân viên trên danh sách nhân viên (listView)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvStaffs_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView ctr = (ListView)sender;
            if (ctr.SelectedItems.Count > 0)
            {
                ListViewItem selected = ctr.SelectedItems[ctr.SelectedItems.Count - 1];
                if (actLevel == 1 && ctr.SelectedItems.Count > 1)
                {
                    txtStaff_Name.Enabled = false;
                    txtID_Person.Enabled = false;
                    txtStaff_Phone.Enabled = false;
                    dtpDOB.Enabled = false;
                    txtStaff_ID.Text = "";
                    txtStaff_Name.Text = "";
                    txtID_Person.Text = "";
                    txtStaff_Phone.Text = "";
                    clearError();
                    dtpDOB.Text = selected.SubItems[4].Text;
                    txtStaff_Wage.Text = selected.SubItems[5].Text;
                    cboStaff_Branch.SelectedIndex = cboStaff_Branch.Items.IndexOf(selected.SubItems[6].Text);
                    cboGender.SelectedItem = selected.SubItems[7].Text;
                }
                else
                {
                    txtStaff_Name.Enabled = true;
                    txtID_Person.Enabled = true;
                    txtStaff_Phone.Enabled = true;
                    dtpDOB.Enabled = true;
                    txtStaff_ID.Text = selected.SubItems[0].Text;
                    txtStaff_Name.Text = selected.SubItems[1].Text;
                    txtID_Person.Text = selected.SubItems[2].Text;
                    txtStaff_Phone.Text = selected.SubItems[3].Text;
                    dtpDOB.Text = selected.SubItems[4].Text;
                    txtStaff_Wage.Text = selected.SubItems[5].Text;
                    cboStaff_Branch.SelectedIndex = cboStaff_Branch.Items.IndexOf(selected.SubItems[6].Text);
                    cboGender.SelectedItem = selected.SubItems[7].Text;
                }
            }
        }
        /// <summary>
        /// Ngăn không cho người dùng thay đổi kích thước của các cộ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvStaffs_List_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvStaffs_List.Columns[e.ColumnIndex].Width;
        }


        //--------------------------------------Buttons--------------------------------------

        /// <summary>
        /// Nút thêm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isActing(true);
            actLevel = 0;
            clearText();
        }
        /// <summary>
        /// Nút đồng ý (Thêm nhân viên)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!isError())
            {
                switch (actLevel)
                {
                    case 0: // Thêm nhân viên
                        {
                            if (addType == 0)
                            {
                                Staff newNV = new Staff(txtStaff_ID.Text);
                                newNV.Name = txtStaff_Name.Text;
                                newNV.ID_Person = txtID_Person.Text;
                                newNV.PhoneNumber = txtStaff_Phone.Text;
                                DateTime dOB = Convert.ToDateTime(dtpDOB.Text);
                                newNV.DOB = dOB;
                                newNV.Wage = Convert.ToDouble(txtStaff_Wage.Text);
                                newNV.Gender = Convert.ToBoolean(cboGender.SelectedIndex);
                                foreach (Branch cn in data_Branches)
                                {
                                    if (cn.Name == cboStaff_Branch.SelectedItem.ToString())
                                    {
                                        newNV.Branch = cn;
                                        break;
                                    }
                                }
                                data_Staffs.AddLast(newNV);
                                tvBranches.SelectedNode = tvBranches.Nodes[0];
                                showList(tvBranches.SelectedNode.Text);
                                isActing(false);
                                clearText();
                            }
                            else
                            {
                                Ultilities.popUpWarning("Vui lòng chọn file danh sách có sẵn !");
                            }
                            break;
                        }
                    case 1: // Sửa thông tin nhân viên
                        {
                            if (lvStaffs_List.SelectedItems.Count < 1)
                            {
                                Ultilities.popUpWarning("Vui lòng chọn nhân viên cần sửa thông tin");
                            }
                            else if (lvStaffs_List.SelectedItems.Count > 1)
                            {
                                txtStaff_Name.Enabled = true;
                                txtID_Person.Enabled = true;
                                txtStaff_Phone.Enabled = true;
                                dtpDOB.Enabled = true;
                                foreach (ListViewItem item in lvStaffs_List.SelectedItems)
                                {
                                    Branch branch_change = null; 
                                    foreach (Branch br in data_Branches)
                                    {
                                        if(cboStaff_Branch.SelectedItem.ToString() == br.Name)
                                        {
                                            branch_change = br;
                                            break;
                                        }
                                    }
                                    foreach (Staff staff in data_Staffs)
                                    {
                                        if (item.SubItems[0].Text == staff.ID)
                                        {
                                            staff.Wage = Convert.ToDouble(txtStaff_Wage.Text);
                                            staff.Gender = Convert.ToBoolean((int)cboGender.SelectedIndex);
                                            staff.Branch = branch_change;
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                foreach (Staff staff in data_Staffs)
                                {
                                    if (staff.ID == txtStaff_ID.Text)
                                    {
                                        staff.Name = txtStaff_Name.Text;
                                        staff.ID_Person = txtID_Person.Text;
                                        staff.PhoneNumber = txtStaff_Phone.Text;
                                        staff.DOB = Convert.ToDateTime(dtpDOB.Value);
                                        staff.Wage = Convert.ToDouble(txtStaff_Wage.Text);
                                        foreach (Branch br in data_Branches)
                                        {
                                            if (br.Name == cboStaff_Branch.Text.ToString())
                                            {
                                                staff.Branch = br;
                                            }
                                        }
                                        staff.Gender = Convert.ToBoolean((int)cboGender.SelectedIndex);
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    default:
                        break;
                }
                tvBranches.SelectedNode = tvBranches.Nodes[0];
                showList(tvBranches.SelectedNode.Text);
                isActing(false);
                clearText();
            }
            else
            {
                Ultilities.popUpError("Thông tin nhân viên không hợp lệ !");
            }
        }
        /// <summary>
        /// Nút hủy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            isActing(false);
            clearText();
            tvBranches.SelectedNode = tvBranches.Nodes[0];
            showList(data_City.First().Name);
        }
        /// <summary>
        /// Thêm danh sách nhân viên mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_List_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        string doc = "";
                        while ((doc = sr.ReadLine()) != null)
                        {
                            string[] data = doc.Split('#');
                            Branch staff_branch = null;
                            foreach (Branch item in data_Branches)
                            {
                                if (item.ID == data[data.Length - 1])
                                {
                                    staff_branch = item;
                                }
                            }
                            Staff staff = new Staff(generateID(staff_branch.ID, data_Staffs.Last.Value.ID), data[1], data[2], data[3], Convert.ToDateTime(data[4]), Convert.ToBoolean(data[5]), Convert.ToDouble(data[6]), staff_branch);
                            data_Staffs.AddLast(staff);
                        }
                    }
                    tvBranches.SelectedNode = tvBranches.Nodes[0];
                    showList(tvBranches.SelectedNode.Text);
                    isActing(false);
                    clearText();
                }
                catch (Exception ex)
                {
                    Ultilities.popUpError(ex.Message);
                }
            }
        }
        /// <summary>
        /// Nút sửa thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isActing(true);
            actLevel = 1;
        }
        /// <summary>
        /// Chọn cách thêm nhân viên ( một hoặc nhiều)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ctr = (RadioButton)sender;
            string sub = ctr.Name.Substring(9);
            if (ctr.Checked && sub == "One")
            {
                gboSingle.Enabled = true;
                btnAdd_List.Enabled = false;
                addType = 0;
            }
            else
            {
                gboSingle.Enabled = false;
                btnAdd_List.Enabled = true;
                addType = 1;
            }
        }
        /// <summary>
        /// Nút xóa nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvStaffs_List.SelectedItems.Count > 0)
            {
                DialogResult res = Ultilities.popUpQuestion("Bạn có thực sự muốn xóa các nhân viên đã chọn ?", 0);
                if (res == DialogResult.Yes)
                {
                    int count = lvStaffs_List.SelectedItems.Count;
                    while (count > 0)
                    {
                        foreach (Staff nv in data_Staffs)
                        {
                            if (nv.ID == lvStaffs_List.SelectedItems[count - 1].Text)
                            {
                                data_Staffs.Remove(nv);
                                break;
                            }
                        }
                        count--;
                    }
                    tvBranches.SelectedNode = tvBranches.Nodes[0];
                    showList(data_City.First().Name);
                    clearText();
                }
            }
            else
            {
                Ultilities.popUpWarning("Vui lòng chọn nhân viên để xóa");
            }
        }


        //--------------------------------------TextBox--------------------------------------

        /// <summary>
        /// Kiểm tra thay đổi dữ liệu tên 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStaff_Name_TextChanged(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;
            if (ctr.Text.Trim().Length > 0)
            {
                bool checkChar = true;
                foreach (char item in ctr.Text)
                {
                    if (!char.IsLetter(item) && item != ' ')
                    {
                        checkChar = false;
                        break;
                    }
                }
                if (!checkChar)
                {
                    errName.SetError(ctr, "Họ tên không hợp lệ");
                }
                else
                {
                    errName.Clear();
                }
            }
            else
            {
                errName.SetError(ctr, "Không được để trống");
            }
        }
        /// <summary>
        /// Kiểm tra thay đổi dữ liệu số điện thoại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStaff_Phone_TextChanged(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;
            if (ctr.Text.Trim().Length > 0)
            {
                bool checkChar = true;
                foreach (char item in ctr.Text)
                {
                    if (!char.IsDigit(item))
                    {
                        checkChar = false;
                        break;
                    }
                }
                if (!checkChar || ctr.Text.Length != 10)
                {
                    errSDT.SetError(ctr, "Số điện thoại không hợp lệ");
                }
                else
                {
                    errSDT.Clear();
                }
            }
            else
            {
                errSDT.SetError(ctr, "Không được để trống");
            }
        }
        /// <summary>
        /// Kiểm tra thay đổi dữ liệu mức lương
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStaff_Wage_TextChanged(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;
            if (ctr.Text.Trim().Length > 0)
            {
                bool checkChar = true;
                foreach (char item in ctr.Text)
                {
                    if (!char.IsDigit(item))
                    {
                        checkChar = false;
                        break;
                    }
                }
                if (!checkChar || Convert.ToDouble(ctr.Text) < 0 || ctr.Text.Length > 9)
                {
                    errWage.SetError(ctr, "Mức lương không hợp lệ");
                }
                else
                {
                    errWage.Clear();
                }
            }
            else
            {
                errWage.SetError(ctr, "Không được để trống");
            }
        }
        /// <summary>
         /// Khi tập trung vào box tìm kiếm sẽ mất hint
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void txtFind_Enter(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;
            ctr.ForeColor = Color.Black;
            ctr.Text = "";
        }
        /// <summary>
        /// Khi rời khỏi box tìm kiếm
        /// Kiểm tra dữ liệu và hiện hint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFind_Leave(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                ctr.ForeColor = Color.Gray;
                ctr.Text = "Tìm nhân viên...";
            }
        }
        /// <summary>
        /// Khi nhấn nút Enter trong thanh tìm kiếm
        /// Tìm kiếm nhân viên theo: CCCD -> Tên -> Số điện thoại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox ctr = (TextBox)sender;
            //Nếu phím được nhấn là phím Enter
            if (e.KeyCode == Keys.Enter)
            {
                if (ctr.Text.Trim().Length > 0)
                {
                    //Tìm kiếm nhân viên theo CCCD
                    ListViewItem[] foundItems = Ultilities.findStaffByID_Person(data_Staffs, ctr.Text);
                    if (foundItems.Length > 0)
                    {
                        lvStaffs_List.Items.Clear();
                        foreach (ListViewItem item in foundItems)
                        {
                            lvStaffs_List.Items.Add(item);
                        }
                    }
                    else
                    {
                        //Tìm kiếm nhân viên theo tên
                        foundItems = Ultilities.findStaffByName(data_Staffs, ctr.Text);
                        if (foundItems.Length > 0)
                        {
                            lvStaffs_List.Items.Clear();
                            foreach (ListViewItem item in foundItems)
                            {
                                lvStaffs_List.Items.Add(item);
                            }
                        }
                        else
                        {
                            //Tìm kiếm nhân viên theo số điện thoại
                            foundItems = Ultilities.findStaffByPhone(data_Staffs, ctr.Text);
                            if (foundItems.Length > 0)
                            {
                                lvStaffs_List.Items.Clear();
                                foreach (ListViewItem item in foundItems)
                                {
                                    lvStaffs_List.Items.Add(item);
                                }
                            }
                            else
                            {
                                Ultilities.popUpError("Nhập số CCCD, họ tên hoặc số điện thoại đề tìm");
                            }
                        }
                    }
                    ctr.Text = "";
                    btnAdd.Focus();
                }
                else
                {
                    btnAdd.Focus();
                }
            }
        }


        //--------------------------------------ComboBox--------------------------------------

        /// <summary>
        /// Chọn chi nhánh khác thay đổi ID của nhân viên mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStaff_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStaff_Branch.Enabled)
            {
                ComboBox ctr = (ComboBox)sender;
                string newID = "";
                foreach (Branch cn in data_Branches)
                {
                    if (cn.Name == ctr.SelectedItem.ToString())
                    {
                        if (actLevel == 0)
                        {
                            newID = generateID(cn.ID, data_Staffs.Last().ID);
                        }
                        else
                        {
                            if (txtStaff_ID.Text != "")
                            {
                                newID = generateID(cn.ID, txtStaff_ID.Text);
                            }
                        }
                        break;
                    }
                }

                txtStaff_ID.Text = newID;
            }
        }


        //--------------------------------------Methods--------------------------------------

        /// <summary>
        /// Hành động thực hiện
        /// 0: Thêm nhân viên
        /// 1: Sửa thông tin
        /// </summary>
        /// <param name="check"></param>
        private void isActing(bool check)
        {
            lvStaffs_List.SelectedItems.Clear();
            btnAdd.Visible = !check;
            btnUpdate.Visible = !check;
            btnRemove.Visible = !check;
            btnAccept.Visible = check;
            btnCancel.Visible = check;
            gboStaff_Info.Enabled = check;
            if (!check)
            {
                actLevel = -1;
            }
        }
        /// <summary>
        /// Kiểm tra các trường dữ liệu
        /// </summary>
        /// <returns></returns>
        private bool isError()
        {
            if(actLevel == 0)
            {
                return errName.GetError(txtStaff_Name) != ""
                    || errSDT.GetError(txtStaff_Phone) != ""
                    || errWage.GetError(txtStaff_Wage) != ""
                    || txtStaff_Name.Text == ""
                    || txtStaff_Phone.Text == ""
                    || txtStaff_Wage.Text == "";
            }
            return errName.GetError(txtStaff_Name) != ""
                    || errSDT.GetError(txtStaff_Phone) != ""
                    || errWage.GetError(txtStaff_Wage) != "";
        }
        /// <summary>
        /// Hiển thị danh sách và khởi tạo ID cho người mới tiếp theo
        /// </summary>
        /// <param name="branchName"></param>
        private void showList(string branchName)
        {
            //Clear danh sách mỗi lần chọn node khác
            lvStaffs_List.Items.Clear();

            //Kiểm tra node đang chọn
            bool checkDiaDiem = false;

            //Kiểm tra theo tên địa chỉ
            foreach (City dd in data_City)
            {
                if (dd.Name == branchName)
                {
                    //Lấy tên id địa chỉ làm từ khóa tìm kiếm
                    checkDiaDiem = true;
                    break;
                }
            }
            //Nếu node đang chọn là địa điểm lớn (Thành phố/Tỉnh)
            if (checkDiaDiem)
            {
                foreach (Staff nv in data_Staffs)
                {
                    ListViewItem item;
                    if (nv.Branch.City.Name == branchName)
                    {
                        item = Ultilities.newItem_Staff(nv);
                        lvStaffs_List.Items.Add(item);
                    }
                }
            }
            else //Nếu node chọn là chi nhánh (Quận/Huyện)
            {
                ListViewItem item;
                //Tìm nhân viên có trong chi nhánh vừa chọn
                foreach (Staff nv in data_Staffs)
                {
                    if (nv.Branch.Name == branchName)
                    {
                        item = Ultilities.newItem_Staff(nv);
                        lvStaffs_List.Items.Add(item);
                    }
                }
            }
            txtStaff_ID.Text = generateID(data_Branches.First().ID, data_Staffs.Last().ID);
        }
        /// <summary>
        /// Tạo ID nhân viên
        /// </summary>
        /// <param name="branchID"></param>
        /// <param name="lastStaffID"></param>
        /// <returns></returns>
        private string generateID(string branchID, string lastStaffID)
        {
            //Khởi tạo ID cho nhân viên mới
            int newID_int = Convert.ToInt32(lastStaffID.Substring(4)) + 1;
            string newID = branchID + String.Format("{0:0000}", newID_int);
            return newID;
        }
        /// <summary>
        /// Xóa thông tin trên các trường textBox và tắt các thông báo lỗi dữ liệu
        /// </summary>
        private void clearText()
        {
            txtStaff_Name.Text = "";
            txtStaff_Phone.Text = "";
            txtStaff_Wage.Text = "";
            txtID_Person.Text = "";
            errName.Clear();
            errSDT.Clear();
            errWage.Clear();
            cboGender.SelectedIndex = 0;
            cboStaff_Branch.SelectedIndex = 0;
        }
        /// <summary>
        /// Xóa các thông báo lỗi ở các truòng
        /// </summary>
        private void clearError()
        {
            errName.Clear();
            errSDT.Clear();
            errWage.Clear();
        }
    }
}
