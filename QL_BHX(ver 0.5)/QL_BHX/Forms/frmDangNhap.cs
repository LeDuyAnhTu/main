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
    public partial class frmDangNhap : Form
    {
        // Khai báo biến
        private int loginLevel = -1;
        public static int attemps = 0;
        private string[] accManager = new string[] { "admin" };
        private string[] passwordManager = new string[] { "124578", };
        private string[] accStaff = new string[] { "staff1" };
        private string[] passwordStaff = new string[] { "anhtuyet" };
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public int LoginLevel { get => loginLevel; }

        /// <summary>
        /// Nhân nút đăng nhập
        ///     Kiểm tra thông tin vừa nhập vào: Tên đăng nhập và password
        ///     Nếu sai 3 lần sẽ thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(attemps < 3)
            {
                string accName = txtAccName.Text.ToString();
                string password = txtPassword.Text.ToString();
                // Kiểm tra tên đăng nhập và mật khẩu của các quản lý
                for (int i = 0; i < accManager.Length; i++)
                {
                    if (accManager[i].Equals(accName))
                    {
                        if (passwordManager[i].Equals(password))
                        {
                            loginLevel = 1;
                            break;
                        }
                    }
                }
                // Kiểm tra tên đăng nhập và mật khẩu của các nhân viên
                if (loginLevel == -1)
                {
                    for (int i = 0; i < accStaff.Length; i++)
                    {
                        if (accStaff[i].Equals(accName))
                        {
                            if (passwordStaff[i].Equals(password))
                            {
                                loginLevel = 0;
                                break;
                            }
                        }
                    }
                }
                if (loginLevel == -1)
                {
                    attemps++;
                    Ultilities.popUpWarning("Đăng nhập thất bại. Vui lỏng kiểm tra kĩ tên đăng nhập và mật khẩu");
                    txtAccName.Text = "";
                    txtPassword.Text = "";
                    txtAccName.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                Ultilities.popUpWarning("Ứng dụng hiện đang bị khóa do đăng nhập sai quá nhiều. Vui lòng khởi động lại !");
            }
        }
        /// <summary>
        /// Trước khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.loginLevel = loginLevel;
        }
        /// <summary>
        /// Nút Hủy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// Khi đang focus vào form này
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDangNhap_Activated(object sender, EventArgs e)
        {
            txtAccName.Focus();
        }
    }
}
