using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_BHX
{
    public class Staff
    {
        /// <summary>
        /// _ID: id nhân viên
        /// _Name: Họ tên nhân viên
        /// _DOB: Ngày sinh nhật
        /// _PhoneNumber: Số điện thoại
        /// _CountryCode: Quê quán
        /// _Gender: Giới tính (false: nam; true: nữ)
        /// _Salary: Tiền lương tháng = lương cơ bản * (số ngày trong tháng / sốngày công)
        /// _Wage: Lương cơ bản
        /// _WorkdayCount: Số ngày công
        /// _BranchCode: ID chi nhánh
        /// </summary>
        private string _ID;
        private string _Name, _PhoneNumber;
        private DateTime _DOB;
        private bool _Gender;
        private string _ID_Person;
        private double _Wage;
        private Branch _Branch;

        /// <summary>
        /// Tạo nhân viên mới
        /// </summary>
        /// <param name="name">Họ tên nhân viên</param>
        /// <param name="phoneNumber">Số điện thoại</param>
        /// <param name="countryCode">Quê quán</param>
        /// <param name="dOB">Ngày sinh nhật</param>
        /// <param name="gender">Giới tính (true: name; false: nữ)</param>
        /// <param name="wage">Lương cơ bản</param>
        /// <param name="branchCode">ID chi nhánh</param>
        public Staff(string iD, string name, string iD_Person, string phoneNumber, DateTime dOB, bool gender, double wage, Branch branch)
        {
            _ID = iD;
            _Name = name;
            _ID_Person = iD_Person;
            _PhoneNumber = phoneNumber;
            _DOB = dOB;
            _Gender = gender;
            _Wage = wage;
            _Branch = branch;
        }
        public Staff(string iD)
        {
            _ID = iD;
            _Name = "";
            _PhoneNumber = "";
            _DOB = DateTime.Now;
            _Gender = true;
            _Wage = 0;
            _Branch = null;
        }

        //Properties
        public string ID { get => _ID; }
        public string Name { get => _Name; set => _Name = value; }
        public string PhoneNumber { get => _PhoneNumber; set => _PhoneNumber = value; }
        public DateTime DOB { get => _DOB; set => _DOB = value; }
        public bool Gender { get => _Gender; set => _Gender = value; }
        public double Wage { get => _Wage; set => _Wage = value; }
        internal Branch Branch { get => _Branch; set => _Branch = value; }
        public string ID_Person { get => _ID_Person; set => _ID_Person = value; }

        /// <summary>
        /// Thêm 1 nhân viên
        /// </summary>
        /// <param name="Staffs">Danh sách cần thêm nhân viên</param>
        /// <param name="staff">Nhân viên cần thêm</param>
        /// <returns></returns>
        public static bool addStaff(LinkedList<Staff> Staffs, Staff staff)
        {
            bool check;
            try
            {
                Staffs.AddLast(staff);
                check = true;
            }
            catch (Exception ex)
            {
                check = false;
            }
            return check;
        }
        /// <summary>
        /// Thêm danh sách nhân viên
        /// </summary>
        /// <param name="Staffs">Danh sách nhân viên của hệ thống</param>
        /// <param name="staffs">Danh sách nhân viên mới</param>
        /// <returns></returns>
        public static bool addStaffs(LinkedList<Staff> Staffs, LinkedList<Staff> staffs)
        {
            bool check;
            try
            {
                foreach (Staff staff in staffs)
                {
                    Staffs.AddLast(staff);
                }
                check = true;
            }
            catch (Exception ex)
            {
                check = false;
            }
            return check;
        }
        /// <summary>
        /// Xóa 1 nhân viên
        /// </summary>
        /// <param name="Staffs">Danh sách gốc</param>
        /// <param name="iD">id của nhân viên cần xóa</param>
        /// <returns></returns>
        public static bool removeStaff(LinkedList<Staff> Staffs, string iD)
        {
            bool check = false;

            foreach (Staff nv in Staffs)
            {
                if (nv.ID == iD)
                {
                    Staffs.Remove(nv);
                    check = true;
                    break;
                }
            }
            return check;
        }
        /// <summary>
        /// Xóa danh sách các nhân viên
        /// </summary>
        /// <param name="Staffs">Danh sách nhân viên của hệ thống</param>
        /// <param name="staffs">Danh sách các nhân viên cần xóa</param>
        /// <returns></returns>
        public static bool removeStaffs(LinkedList<Staff> Staffs, LinkedList<Staff> staffs)
        {
            bool check = false;
            foreach (Staff nv1 in staffs)
            {
                foreach (Staff nv2 in Staffs)
                {
                    if (nv1.ID == nv2.ID)
                    {
                        Staffs.Remove(nv2);
                        check = true;
                        break;
                    }
                }
            }
            return check;
        }
        /// <summary>
        /// Sửa thông tin của nhân viên
        /// </summary>
        /// <param name="Staffs">Danh sách chứa nhân viên cần sửa thông tin</param>
        /// <param name="staff">Thông tin cần sửa (trừ ID)</param>
        /// <returns></returns>
        public static bool updateStaff(LinkedList<Staff> Staffs, Staff staff)
        {
            bool check = false;
            foreach (Staff nv in Staffs)
            {
                if (nv.ID == staff.ID)
                {
                    Staffs.Find(nv).Value = staff;
                    check = true;
                    break;
                }
            }
            return check;
        }
        public string toFile()
        {
            return ID + "#" + Name + "#" + ID_Person + "#" + PhoneNumber + "#" + DOB.ToShortDateString() + "#" + Gender + "#" + Wage + "#" + Branch.ID;
        }
    }
}
