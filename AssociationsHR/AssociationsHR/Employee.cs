using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationsHR
{
    class Employee
    {
        //employee class attributes
        private string name;
        private string surname;
        private int empNumber;
        private double salary;
        private double allowance;
        private PaySlip payslip;
        //constructor for employee class. Takes in employee name and surname, employee
        //number, basic salary and allowance as parameter. Initializes 
        //pay slip attribute
        public Employee(string name, string surname, int employeeNumber, double basicSalary, double allowance)
        {
            this.name = name;
            this.surname = surname;
            this.empNumber = employeeNumber;
            this.salary = basicSalary;
            this.allowance = allowance;
            payslip = new PaySlip(name, surname, empNumber, salary, allowance, GetTax());
        }
        //get method returns tax 
        public double GetTax()
        {
            double tax = (salary + allowance) * 0.28;
            return tax;
        }
        //get method returns employee payslip
        public PaySlip GetPaySlip()
        {
            return payslip;
        }
        //get method returns employee number
        public int GetEmpNum()
        {
            return empNumber;
        }
    }
}
