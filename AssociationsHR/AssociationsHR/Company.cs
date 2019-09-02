using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationsHR
{
    class Company
    {
        //attributes for company class
        private Employee[] employees;
        private int count;
        //constructor for company class. initializes class attributes
        public Company()
        {
            employees = new Employee[1000];
            count = 0;
        }
        //method adds employees to company
        public void AddEmployee(Employee e)
        {
            employees[count] = e;
            count++;
        }
        
        //method checks if a specific employee exists. Takes in
        //employee number as parameter
        public bool SpecificEmployee(int empNum)
        {
            bool exist = false;
            for (int i = 0; i < count; i++)
            {
                if(employees[i].GetEmpNum() == empNum)
                {
                    exist = true;
                }
            }
            return exist;
        }
        //method returns payslip, takes in employee number as parameter
        public string[] PrintPaySlip(int empNum)
        {
            string[] payslipInfo = new string[5];
            for (int i = 0; i < count; i++){
                if(employees[i].GetEmpNum() == empNum)
                {
                    payslipInfo[0] = employees[i].GetPaySlip().GetNameSurname();
                    payslipInfo[1] = employees[i].GetPaySlip().GetEmpNum().ToString();
                    payslipInfo[2] = employees[i].GetPaySlip().GetSalary().ToString();
                    payslipInfo[3] = employees[i].GetPaySlip().GetAllowance().ToString();
                    payslipInfo[4] = employees[i].GetPaySlip().GetTax().ToString();
                    break;
                }
            }
            return payslipInfo;
        }
    }
}
