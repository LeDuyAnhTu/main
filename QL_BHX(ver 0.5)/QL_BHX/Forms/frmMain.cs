using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BHX
{
    public partial class frmMain : Form
    {
        Form frmDangNhap, frmNhanVien, frmHoaDon;
        /// <summary>
        /// loginLevel: Phân quyền truy cập
        /// -1: Chưa đăng nhập
        ///  0: Nhân viên
        ///  1: Quản lý
        /// </summary>
        public static int loginLevel = -1;

        public static LinkedList<Customer> data_Customer;
        public static LinkedList<Branch> data_Branch;
        public static LinkedList<City> data_City;
        public static LinkedList<Staff> data_Staff;


        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Before close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(loginLevel != -1)
            {
                Ultilities.popUpWarning("Vui lòng đăng xuất trước khi đóng chương trình !");
                e.Cancel = true;
                return;
            }
            DialogResult res = Ultilities.popUpQuestion("Bạn có muốn thoát không ?", 0);
            if(res == DialogResult.No)
            {
                // Cancel closing progress
                e.Cancel = true;
            }
            else
            {
                // Save database before close
            }
        }
        /// <summary>
        /// Khi thao tác trên các form con
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (loginLevel == -1)
            {
                enableManager(false);
            }
            else
            {
                if (loginLevel == 0)
                {
                    enableStaff(true);
                }
                else
                {
                    enableManager(true);
                }
            }
        }
        /// <summary>
        /// Nút đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmLogin_Click(object sender, EventArgs e)
        {
            frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            Ultilities.checkForm(frmDangNhap);
        }
        /// <summary>
        /// Nút thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Nút bán hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSell_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Nút đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmLogout_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                // Yêu cầu tắt hết các form con trước khi đăng xuát6
                Ultilities.popUpWarning("Vui lòng thoát các trang còn lại để đăng xuất");
            }
            else
            {
                // Xác thực hành động đăng xuất
                DialogResult res = Ultilities.popUpQuestion("Bạn có muốn lưu thông tin và đăng xuất ?", 0);
                if (res == DialogResult.Yes)
                {
                    loginLevel = -1;
                    enableManager(false);
                    // Thực hiện lưu thông tin ở đây
                }
            }
        }
        /// <summary>
        /// Nút quản lý nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmManager_Staff_Click(object sender, EventArgs e)
        {
            frmNhanVien = new frmQuanLy_NV();
            frmNhanVien.MdiParent = this;
            Ultilities.checkForm(frmNhanVien);
        }
        /// <summary>
        /// Nút quản lý hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmManager_Bill_Click(object sender, EventArgs e)
        {
            frmHoaDon = new frmQuanLyHoaDon();
            frmHoaDon.MdiParent = this;
            Ultilities.checkForm(frmHoaDon);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            data_Customer = new LinkedList<Customer>();
            data_Branch = new LinkedList<Branch>();
            data_City = new LinkedList<City>();
            data_Staff = new LinkedList<Staff>();
        }


        /// <summary>
        /// Kích hoạt các nút của quản lý
        /// </summary>
        /// <param name="enable"></param>
        private void enableManager(bool enable)
        {
            enableStaff(enable);
            tsmManager_Customer.Enabled = enable;
            tsmManager_Discount.Enabled = enable;
            tsmManager_Staff.Enabled = enable;
        }
        /// <summary>
        /// Kích hoạt các nút của nhân viên
        /// </summary>
        /// <param name="enable"></param>
        private void enableStaff(bool enable)
        {
            tsmSell.Enabled = enable;
            tsmLookup_Bill.Enabled = enable;
            tsmLookup_Customer.Enabled = enable;
            tsmLookup_Staff.Enabled = enable;
            tsmManager_Product.Enabled = enable;
            tsmManager_Bill.Enabled = enable;
            tsmLogin.Enabled = !enable;
            tsmLogout.Enabled = enable;
        }
    }
}
