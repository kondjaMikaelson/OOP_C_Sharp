using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationHospital
{
    class Illness
    {
        //attributes for illness class
        private string name;
        private string type;
        private string symptoms;
        //constructor for illness class. Takes in illness name, 
        //type of illness and symptoms of illness as parameters
        public Illness(string name, string type, string symptoms)
        {
            this.name = name;
            this.type = type;
            this.symptoms = symptoms;
        }
        //default constructor for illness class
        public Illness()
        {

        }
        //get method returns illness name
        public string GetName()
        {
            return name;
        }
    }
}
