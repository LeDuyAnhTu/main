using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BHX
{
    public class Customer
    {
        //Fields
        private string _ID, _Name, _PhoneNumber;
        private long _Point;
        private DateTime _StartDate, _DateOfBirth;

        //Contructor
        public Customer(string iD, string name, string phoneNumber, DateTime dateOfBirth, DateTime startDate, long point = 0)
        {
            _ID = iD;
            _Name = name;
            _PhoneNumber = phoneNumber;
            _Point = point;
            _StartDate = startDate;
            _DateOfBirth = dateOfBirth;
        }

        //Properties
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string PhoneNumber { get => _PhoneNumber; set => _PhoneNumber = value; }
        public long Point { get => _Point; set => _Point = value; }
        public DateTime StartDate { get => _StartDate; }
        public DateTime DateOfBirth { get => _DateOfBirth; set => _DateOfBirth = value; }

        //Method
        public string toFile()
        {
            return $"{ID}" +
                $"#{Name}" +
                $"#{PhoneNumber}" +
                $"#{DateOfBirth.ToShortDateString()}" +
                $"#{StartDate.ToShortDateString()}" +
                $"#{Point}";
        }
        public static Customer findCustomer(string iD, LinkedList<Customer> list)
        {
            foreach(Customer customer in list)
            {
                if(customer.ID == iD)
                    return customer;
            }
            return null;
        }
        /// <summary>
        /// Tìm kiếm danh sách khách hàng theo ID
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static LinkedList<Customer> findCustomersByID(string iD, LinkedList<Customer> list)
        {
            bool found = false;
            LinkedList<Customer> tmp = new LinkedList<Customer>();
            foreach(Customer customer in list)
            {
                if(customer.ID == iD)
                {
                    tmp.AddLast(customer);
                    found = true;
                }
            }
            if(found)
                return tmp;
            return null;
        }
        /// <summary>
        /// Tìm kiếm danh sách hàng theo Tên
        /// </summary>
        /// <param name="name"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static LinkedList<Customer> findCustomersByName(string name, LinkedList<Customer> list)
        {
            bool found = false;
            LinkedList<Customer> tmp = new LinkedList<Customer>();
            foreach (Customer customer in list)
            {
                if (customer.Name.Contains(name))
                {
                    tmp.AddLast(customer);
                    found = true;
                }
            }
            if (found)
                return tmp;
            return null;
        }
        /// <summary>
        /// Tìm kiếm khách hàng theo số điện thoại
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static LinkedList<Customer> findCustomersByPhone(string phone, LinkedList<Customer> list)
        {
            bool found = false;
            LinkedList<Customer> tmp = new LinkedList<Customer>();
            foreach (Customer customer in list)
            {
                if (customer.PhoneNumber.Contains(phone))
                {
                    tmp.AddLast(customer);
                    found = true;
                }
            }
            if (found)
                return tmp;
            return null;
        }
        /// <summary>
        /// Tìm kiếm danh sách kết hợp
        /// </summary>
        /// <param name="item"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static LinkedList<Customer> findCustomers(string item, LinkedList<Customer> list)
        {
            if(item == null) 
                return list;

            bool found = false;
            LinkedList<Customer> customers = new LinkedList<Customer>();
            //Tìm kiếm theo tên
            customers = findCustomersByName(item, list);
            if(customers == null)
            {
                //Nếu chuỗi bắt đầu bằng "KH" thì tìm theo ID 
                if (item.StartsWith("KH"))
                {
                    customers = findCustomersByID(item, list);
                }
                else
                {
                    customers = findCustomersByPhone(item, list);
                }

                if(customers != null)
                {
                    found = true;
                }
            }
            else
            {
                found = true;
            }

            if(found) 
                return customers;
            return null;
        }
    }
}
