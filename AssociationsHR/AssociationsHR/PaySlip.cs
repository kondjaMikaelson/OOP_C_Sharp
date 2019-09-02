using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationsHR
{
    class PaySlip
    {
        //attributes for payslip class
        private string empName;
        private string empSurname;
        private int empNumber;
        private double salary;
        private double allowance;
        private double tax;
        //constructor for payslip class. takes in employee name & surname, 
        //employee number, salary, allowance and tax as parameters
        public PaySlip(string name, string surname, int employeeNumber, double basicSalary, double allowance, double tax)
        {
            this.empName = name;
            this.empSurname = surname;
            this.empNumber = employeeNumber;
            this.salary = basicSalary;
            this.allowance = allowance;
            this.tax = tax;
        }
        public string GetNameSurname()
        {
            return empName + " " + empSurname;
        }
        public int GetEmpNum()
        {
            return empNumber;
        }
        public double GetSalary()
        {
            return salary;
        }
        public double GetAllowance()
        {
            return allowance;
        }
        public double GetTax()
        {
            return tax;
        }
    }
}
