using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationsHR
{
    class Program
    {
        static void Main(string[] args)
        {
            //create company object
            Company comp = new Company();
            //add employees to company
            comp.AddEmployee(new Employee("Alexander","Ndeumane",5236,50000.00,10000));
            comp.AddEmployee(new Employee("Erick", "Shivute", 5789, 20000.00, 5000));
            comp.AddEmployee(new Employee("Arnold", "Lincon", 5778, 5000.00, 300));
            //print payslip of Alexander
            string[] payslipInfo = comp.PrintPaySlip(5236);
            for(int i = 0; i < payslipInfo.Length; i++)
            {
                Console.WriteLine(payslipInfo[i]);
            }
            //checks to see whether Alexander exists
            Console.WriteLine(comp.SpecificEmployee(5236));
        }
    }
}
