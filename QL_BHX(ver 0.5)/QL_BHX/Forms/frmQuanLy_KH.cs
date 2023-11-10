using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BHX
{
    public partial class frmQuanLy_KH : Form
    {
        private LinkedList<Customer> data_Customer;
        public frmQuanLy_KH()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Lưu về main trước khi tắt hoặc không
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuanLy_KH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = Ultilities.popUpQuestion("Bạn có muốn lưu dữ liệu trước khi thoát không ?", 1);
            if (res == DialogResult.Yes)
            {
                frmMain.data_Customer = data_Customer;
            }
            else if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// lấy dữ liệu trên main về khi chạy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuanLy_KH_Load(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ main
            if (frmMain.data_Customer != null)
                data_Customer = frmMain.data_Customer;
            else //Nếu main chưa có dữ liệu thì tạo mới
                data_Customer = new LinkedList<Customer>();
            //Tự tạo ID khách hàng
            txtID.Text = generateID();
            //Hiển thị danh sách khách hàng
            showList(data_Customer);
            
        }


        //-------------------------------------Buttons-------------------------------------
        /// <summary>
        /// Nút thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Thêm khách hàng mới vào data và đổ lên listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isError())
            {
                //Thông báo lỗi cho người dùng nếu ID Khách hàng đã tồn tại
                if (isExistID(txtID.Text))
                {
                    Ultilities.popUpError($"Khách hàng {txtID.Text} đã có trong danh sách");
                    clearText();
                    return;
                }
                if(DateTime.Now.Subtract(dtpDOB.Value).Days / 3652 < 1)
                {
                    Ultilities.popUpError($"Khách hàng {txtID.Text} không thể làm đăng ký vì chưa đủ 10 tuổi");
                    return;
                }
                //Thêm khách hàng mới vào danh sách khách hàng và làm mới danh sách
                Customer cm = new Customer(txtID.Text, txtName.Text, txtPhone.Text, dtpDOB.Value, DateTime.Now, Convert.ToInt64(txtPoint.Text));
                data_Customer.AddLast(cm);
                showList(data_Customer);
                clearText();
            }
            else
            {
                Ultilities.popUpWarning("Vui lòng kiểm tra lại các thông tin trên !");
            }
        }
        /// <summary>
        /// Nút xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Kiểm tra số lượng khách hàng đã chọn để xóa
            if (lvCustomer.SelectedItems.Count > 0)
            {
                //Xác minh việc xóa
                DialogResult res = Ultilities.popUpQuestion("Bạn thực sự muốn xóa khách hàng này ?", 0);
                if (res == DialogResult.Yes)
                {
                    //Tìm và xóa khách hàng theo ID
                    foreach (ListViewItem item in lvCustomer.SelectedItems)
                    {
                        Customer delCustomer = Customer.findCustomer(item.SubItems[0].Text, data_Customer);
                        if (delCustomer != null)
                        {
                            data_Customer.Remove(delCustomer);
                        }
                    }
                    //Làm mới danh sách listView
                    clearText();
                    showList(data_Customer);
                }
            }
            else
            {
                Ultilities.popUpWarning("Chọn ít nhất 1 khách hàng để xóa !");
            }
        }
        /// <summary>
        /// Nút sửa thông tin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer udCustomer = Customer.findCustomer(txtID.Text, data_Customer);
            if (udCustomer != null)
            {
                DialogResult res = Ultilities.popUpQuestion($"Bạn có muốn sửa thông tin của khách hàng {txtID.Text}", 0);
                if(res == DialogResult.Yes)
                {
                    udCustomer.Name = txtName.Text;
                    udCustomer.PhoneNumber = txtPhone.Text;
                    udCustomer.DateOfBirth = dtpDOB.Value;
                    udCustomer.Point = Convert.ToInt64(txtPoint.Text);
                    clearText(); 
                    showList(data_Customer);
                    Ultilities.popUpInformation("Sửa thành công !");
                }
            }
            else
            {
                Ultilities.popUpWarning($"Không tìm thấy khách hàng {txtID.Text} trong danh sách");
            }
        }
        /// <summary>
        /// Nút lưu danh sách hiện hành
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt"
            };
            save.ShowDialog();
            if (save.FileName != "")
            {
                try
                {
                    using(StreamWriter sw = new StreamWriter(save.FileName))
                    {
                        foreach(Customer item in data_Customer)
                        {
                            sw.WriteLine(item.toFile());
                        }
                    }
                    Ultilities.popUpInformation("Lưu thành công !");
                }catch(Exception ex)
                {
                    Ultilities.popUpError(ex.Message);
                }
            }
        }
        /// <summary>
        /// Nút mở file đang có 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt"
            };
            if(open.ShowDialog() == DialogResult.OK)
            {
                //Xác nhận ghi đè lên danh sách hiện hành nếu danh sách có dữ liệu
                bool isListed = false;
                if(data_Customer != null) { 
                    if(data_Customer.Count > 0)
                    {
                        if(Ultilities.popUpQuestion("Bạn có muốn ghi đè lên danh sách hiện tại ?", 0) == DialogResult.No)
                        {
                            isListed = true;
                        }
                    }
                }
                if(!isListed)
                {
                    try
                    {
                        using (StreamReader sw = new StreamReader(open.FileName))
                        {
                            //Xóa danh sách cũ
                            data_Customer = new LinkedList<Customer>();
                            //Ghi danh sách mới vào data
                            string doc = "";
                            while((doc = sw.ReadLine()) != null)
                            {
                                string[] data = doc.Split('#');
                                DateTime dOB = Convert.ToDateTime(data[3]);
                                if (DateTime.Now.Subtract(dOB).Days / 3652 == 0)
                                {
                                    dOB = dtpDOB.Value;
                                }

                                Customer item = new Customer(data[0]
                                    , data[1]
                                    , data[2]
                                    , dOB
                                    , Convert.ToDateTime(data[4])
                                    , Convert.ToInt64(data[5]));
                                data_Customer.AddLast(item);
                            }
                            //làm mới trang
                            clearText();
                            showList(data_Customer);
                            Ultilities.popUpInformation("Mở file thành công");
                        }
                    }
                    catch (Exception ex)
                    {
                        Ultilities.popUpError(ex.Message);
                    }
                }
                else
                {
                    Ultilities.popUpInformation("Mở file thất bại");
                }
            }
        }
        /// <summary>
        /// làm mới trang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            clearText();
            showList(data_Customer);
        }


        //-------------------------------------Method-------------------------------------
        /// <summary>
        /// Hiển thị thông tn mới nhất trên danh sách
        /// </summary>
        private void showList(LinkedList<Customer> list)
        {
            if (list != null)
            {
                lvCustomer.Items.Clear();
                if (list.Count > 0)
                {
                    foreach (Customer customer in list)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = customer.ID;
                        item.SubItems.Add(customer.Name);
                        item.SubItems.Add(customer.PhoneNumber);
                        item.SubItems.Add(customer.DateOfBirth.ToShortDateString());
                        item.SubItems.Add(customer.Point.ToString());
                        item.SubItems.Add(customer.StartDate.ToShortDateString());
                        lvCustomer.Items.Add(item);
                    }
                }
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu trên các trường
        /// </summary>
        /// <returns></returns>
        private bool isError()
        {
            return txtName.Text == ""
                || txtPhone.Text == ""
                || txtPoint.Text == ""
                || errName.GetError(txtName) != ""
                || errPhone.GetError(txtPhone) != ""
                || errPoint.GetError(txtPoint) != "";
        }
        /// <summary>
        /// Trả dữ liệu của các trường về ban đầu
        /// </summary>
        private void clearText()
        {
            txtID.Text = generateID();
            txtName.Text = "";
            txtPhone.Text = "";
            txtPoint.Text = "0";
            dtpDOB.Value = DateTime.Now;
            txtFind.Text = "";
            errName.Clear();
            errPhone.Clear();
            errPoint.Clear();
        }
        /// <summary>
        /// Tự động tạo ID mới
        /// </summary>
        /// <returns></returns>
        private string generateID()
        {
            string id = "KH0001";
            if (data_Customer != null)
            {
                if (data_Customer.Count > 0)
                {
                    int count = Convert.ToInt32(data_Customer.Last.Value.ID.Substring(2));
                    id = $"KH{count + 1:0000}";
                }
            }
            return id;
        }
        /// <summary>
        /// Kiểm tra ID trong danh sách đang duyệt
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool isExistID(string id)
        {
            if (data_Customer.Count > 0)
            {
                foreach (Customer customer in data_Customer)
                {
                    if (customer.ID == id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //-------------------------------------ListView-------------------------------------
        /// <summary>
        /// Khi chọn khách hàng từ danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCustomer.SelectedItems.Count > 0)
            {
                if (lvCustomer.SelectedItems.Count == 1)
                {
                    ListViewItem item = lvCustomer.SelectedItems[0];
                    txtID.Text = item.SubItems[0].Text;
                    txtName.Text = item.SubItems[1].Text;
                    txtPhone.Text = item.SubItems[2].Text;
                    dtpDOB.Text = item.SubItems[3].Text;
                    txtPoint.Text = item.SubItems[4].Text;
                }
            }
            else
            {
                clearText();
            }
        }


        //-------------------------------------TextBox-------------------------------------
        /// <summary>
        /// Khi nhấn vào ô tìm kiếm thì tắt hint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFind_Enter(object sender, EventArgs e)
        {
            if(txtFind.ForeColor == Color.Gray)
            {
                txtFind.Text = string.Empty;
                txtFind.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Khi rời ô tìm kiếm mà không nhập gì thì hiển thị hint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFind_Leave(object sender, EventArgs e)
        {
            if(txtFind.Text.Trim().Length == 0)
            {
                txtFind.Text = "Tìm kiếm...";
                txtFind.ForeColor = Color.Gray;
            }
        }
        /// <summary>
        /// Khi nhấn Enter trong ô tìm kiếm thì hiển thị danh sách tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LinkedList<Customer> list = Customer.findCustomers(txtFind.Text,data_Customer);
                if(list != null)
                {
                    showList(list);
                }
                else
                {
                    Ultilities.popUpInformation($"Không tìm thấy khách hàng {txtFind.Text}");
                }
                clearText();
            }
        }
        /// <summary>
        /// Khi hiển thị hint sau khi clear text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if(!txtFind.Focused)
            {
                if (txtFind.Text.Trim().Length == 0)
                {
                    txtFind.Text = "Tìm kiếm...";
                    txtFind.ForeColor = Color.Gray;
                }
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu khi nhập vào trường Họ tên 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;

            bool correct = Ultilities.isName(ctr.Text);

            if (correct)
            {
                errName.Clear();
            }
            else
            {
                errName.SetError(ctr, "Tên khách hàng không hợp lệ");
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu khi nhập vào trường Số điện thoại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;

            bool correct = Ultilities.isPhone(ctr.Text);

            if (correct)
            {
                errPhone.Clear();
            }
            else
            {
                errPhone.SetError(ctr, "Số điện thoại không hợp lệ");
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu khi nhập vào trường Điểm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPoint_TextChanged(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;

            bool correct = Ultilities.isNumber(ctr.Text);

            if (correct)
            {
                errPoint.Clear();
            }
            else
            {
                errPoint.SetError(ctr, "Số điểm không hợp lệ");
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu khi rời khỏi trường Họ tên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Leave(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;

            bool correct = Ultilities.isName(ctr.Text);

            if (correct)
            {
                errName.Clear();
            }
            else
            {
                errName.SetError(ctr, "Tên khách hàng không hợp lệ");
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu khi rời khỏi trường Số điện thoại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;

            bool correct = Ultilities.isPhone(ctr.Text);

            if (correct)
            {
                errPhone.Clear();
            }
            else
            {
                errPhone.SetError(ctr, "Số điện thoại không hợp lệ");
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu khi rời khỏi trường Điểm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPoint_Leave(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;

            bool correct = Ultilities.isNumber(ctr.Text);

            if (correct)
            {
                errPoint.Clear();
            }
            else
            {
                errPoint.SetError(ctr, "Số điểm không hợp lệ");
            }
        }
    }

}
