using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirkwood_Water_Department_Final_Project
{
    public class Employee
    {
        //Instance Fields
        private string _employeeFirstName;
        private string _employeeLastName;
        private string _phoneNumber;
        private string _username;
        private string _password;
        private int _employeeID;


       


        //Constructor
        public Employee() { }

        public Employee(string employeeFirstName, string employeeLastName, string phoneNumber, string username, string password, int employeeID)
        {

            _employeeFirstName = employeeFirstName;
            _employeeLastName = employeeLastName;
            _phoneNumber = phoneNumber;
            _username = username;
            _password = password;
            _employeeID = employeeID;

        }


        //Proprites
        public string EmployeeFirstName
        {
            get { return _employeeFirstName; }
        }

        public string EmployeeLastName
        {
            get { return _employeeLastName; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public string Username
        {
            get { return _username; }
        }

        public string Password
        {
            get { return _password; }
        }

        public int EmployeeID
        {
            get { return _employeeID; }
        }



        public override string ToString()
        {
            return $"Employee ID: {EmployeeID}\n{EmployeeFirstName} {EmployeeLastName}, {PhoneNumber}\n\n";
        }



    }
}
