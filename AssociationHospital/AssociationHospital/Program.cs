using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //create record object
            Record rec = new Record();
            //add illnesses to record
            rec.AddIllness(new Illness("TB", "Bacterial", "Coughing"));
            rec.AddIllness(new Illness("HIV", "Virus", "Skinny"));
            rec.AddIllness(new Illness("Cholera", "Bacterium", "Diahrea"));
            rec.AddIllness(new Illness("Flu", "Virus", "Sweating"));
            rec.AddIllness(new Illness("Measles", "Bacterium", "Pimples"));
            //add patients to record
            rec.AddPatient(new Patient("Kenny","M","0+"), "Cholera");
            rec.AddPatient(new Patient("Cartman", "M", "0-"), "TB");
            rec.AddPatient(new Patient("Kyle", "M", "B+"), "Flu");
            rec.AddPatient(new Patient("Wendy", "F", "0+"), "Cholera");
            rec.AddPatient(new Patient("Bebe", "F", "A+"), "HIV");
            rec.AddPatient(new Patient("Stan", "M", "0+"), "Cholera");
            //check out Stan
            rec.CheckOut("Stan");
            //checks to see if Stan and Cartman are treated
            Console.WriteLine(rec.IsTreated("Stan"));
            Console.WriteLine(rec.IsTreated("Cartman"));
            //Prints number of patients sufferring from Cholera
            string[] names = rec.SufferringFrom("Cholera");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            //Prints illness that affects the most people
            Console.WriteLine(rec.AffectedMostPeople());
            
        }
    }
}
