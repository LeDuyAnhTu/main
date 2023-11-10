using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BHX
{
    internal class Ultilities
    {
        public static void checkForm(Form form)
        {
            if (Application.OpenForms[form.Name] == null)
            {
                form.Show();
            }
            else
            {
                Application.OpenForms[form.Name].Activate();
            }
        }
        /// <summary>
        /// Hiển thị bảng thông báo lỗi
        /// </summary>
        /// <param name="message"></param>
        public static void popUpError(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Hiển thị bảng cảnh báo
        /// </summary>
        /// <param name="message"></param>
        public static void popUpWarning(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Hiển thị bảng xác minh
        /// 
        /// </summary>
        /// <param name="message">Tin nhắn hiển thị</param>
        /// <param name="type">
        ///     0: Yes/No
        ///     1: Yes/No/Cancel
        ///     2: Ok/Cancel
        /// </param>
        /// <returns></returns>
        public static DialogResult popUpQuestion(string message, int type)
        {
            MessageBoxButtons buttons;
            switch (type)
            {
                case 0:
                    buttons = MessageBoxButtons.YesNo;
                    break;
                case 1:
                    buttons = MessageBoxButtons.YesNoCancel;
                    break;
                case 2:
                    buttons = MessageBoxButtons.OKCancel;
                    break;
                default:
                    throw new Exception("Loại nút không hợp lệ (0/1/2)");
            }
            return MessageBox.Show(message, "Thông báo", buttons, MessageBoxIcon.Question);
        }
        /// <summary>
        /// Hiển thị thông báo thường
        /// </summary>
        /// <param name="message"></param>
        public static void popUpInformation(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Tạo listviewItem với thông tin của nhân viên thêm vào
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public static ListViewItem newItem_Staff(Staff nv)
        {
            ListViewItem item = new ListViewItem();
            item.Text = nv.ID;
            item.SubItems.Add(nv.Name);
            item.SubItems.Add(nv.ID_Person);
            item.SubItems.Add(nv.PhoneNumber);
            item.SubItems.Add(nv.DOB.ToShortDateString());
            item.SubItems.Add(nv.Wage.ToString());
            item.SubItems.Add(nv.Branch.Name);
            string gender = nv.Gender == true ? "Nữ" : "Nam";
            item.SubItems.Add(gender);
            return item;
        }
        /// <summary>
        /// Tìm nhân viên theo CCCD và trả về listViewItem[]
        /// </summary>
        /// <param name="data_Staffs"></param>
        /// <param name="iD_Person"></param>
        /// <returns></returns>
        public static ListViewItem[] findStaffByID_Person(LinkedList<Staff> data_Staffs, string iD_Person)
        {
            ListViewItem[] list = new ListViewItem[0];
            foreach (Staff staff in data_Staffs)
            {
                if (staff.ID_Person.Contains(iD_Person))
                {
                    Array.Resize(ref list, list.Length + 1);
                    list[list.Length - 1] = newItem_Staff(staff);
                }
            }
            return list;
        }
        /// <summary>
        /// Tìm nhân viên theo tên và trả về listViewItem[]
        /// </summary>
        /// <param name="data_Staffs"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ListViewItem[] findStaffByName(LinkedList<Staff> data_Staffs, string name)
        {
            ListViewItem[] list = new ListViewItem[0];
            foreach (Staff staff in data_Staffs)
            {
                if (staff.Name.Contains(name))
                {
                    Array.Resize(ref list, list.Length + 1);
                    list[list.Length - 1] = newItem_Staff(staff);
                }
            }
            return list;
        }
        /// <summary>
        /// Tìm nhân viên theo số điện thoại và trả về listViewItem[]
        /// </summary>
        /// <param name="data_Staffs"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static ListViewItem[] findStaffByPhone(LinkedList<Staff> data_Staffs, string phoneNumber)
        {
            ListViewItem[] list = new ListViewItem[0];
            foreach (Staff staff in data_Staffs)
            {
                if (staff.PhoneNumber.Contains(phoneNumber))
                {
                    Array.Resize(ref list, list.Length + 1);
                    list[list.Length - 1] = newItem_Staff(staff);
                }
            }
            return list;
        }
        
        /// <summary>
        /// Lấy chuỗi các ID trong danh sách
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string getIDString(LinkedList<Branch> list)
        {
            string msg = "";
            foreach (Branch item in list)
            {
                msg += item;
                if(item != list.Last())
                {
                    msg += "/";
                }
            }
            return msg;
        }
        public static string getIDString(LinkedList<Product> list)
        {
            string msg = "";
            foreach (Product item in list)
            {
                msg += item;
                if (item != list.Last())
                {
                    msg += "/";
                }
            }
            return msg;
        }

        /// <summary>
        /// Kiểm tra Tên
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool isName(string name)
        {
            bool correct = true;
            if (name.Trim().Length > 0)
            {
                foreach (char item in name)
                {
                    if (!char.IsLetter(item) && item != ' ')
                    {
                        correct = false;
                        break;
                    }
                }
            }
            else
            {
                correct = false;
            }
            return correct;
        }
        /// <summary>
        /// Kiểm tra số điện thoại
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static bool isPhone(string phone)
        {
            bool correct = true;
            if (phone.Length == 10 && phone.StartsWith("0"))
            {
                foreach (char item in phone)
                {
                    if (!char.IsDigit(item))
                    {
                        correct = false;
                        break;
                    }
                }
            }
            else
            {
                correct = false;
            }
            return correct;
        }
        /// <summary>
        /// Kiểm tra Số nguyên
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool isNumber(string number)
        {
            bool correct = true;
            if (number.Length > 0)
            {
                foreach (char item in number)
                {
                    if (!char.IsDigit(item))
                    {
                        correct = false;
                        break;
                    }
                }
            }
            else
            {
                correct = false;
            }
            return correct;
        }
    }
}
