using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationHospital
{
    class Patient
    {
        //attributes for patient class
        private string name;
        private string gender;
        private string bloodType;
        private Illness illness;
        private bool treated;
        //constructor for patient class. Takes in patient name,
        //patient gender and patient blood type as parameters
        //initializes illness attribute
        public Patient(string name, string gender, string bloodType)
        {
            this.name = name;
            this.gender = gender;
            this.bloodType = bloodType;
            this.treated = false;
            illness = new Illness();
        }
        //get method returns patient name
        public string GetName()
        {
            return name;
        }
        //get method returns patient treatment status
        public bool GetStatus()
        {
            return treated;
        }
        //method to treat patient
        public void Treated()
        {
            treated = true;
        }
        //method returns illness name that patient suffers from
        public string GetIllnessName()
        {
            return illness.GetName();
        }
        //method assigns illness to patient
        public void SetIllness(Illness ill)
        {
            illness = ill;
        }
    }
}
