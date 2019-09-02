using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationHospital
{
    class Record
    {
        //attributes for record class
        private Illness[] illnesses;
        private Patient[] patients;
        private  int countI;
        private int countP;
        //constructor for record class initializes record class attributes
        public Record()
        {
            illnesses = new Illness[1000];
            patients = new Patient[1000];
            countI = 0;
            countP = 0;
        }
        //method adds patients to record. Takes in patient object
        //and illness name as parameters
        public void AddPatient(Patient p, string illnessName)
        {
            patients[countP] = p;
            for(int i = 0; i < countI; i++)
            {
                if (illnesses[i].GetName() == illnessName)
                {
                    patients[countP].SetIllness(illnesses[i]);
                    break;
                }
            }
            countP++;
        }
        //method adds illness to record. Takes in illness onject
        //as a parameter
        public void AddIllness(Illness i)
        {
            illnesses[countI] = i;
            countI++;
        }
        //method checks to see if a patients has been treated
        //takes in patient name as a parameter
        public bool IsTreated(string name)
        {
            bool status = false;
            for(int i=0; i<countP;i++)
            {
                if(patients[i].GetName() == name)
                {
                    status = patients[i].GetStatus();
                    break;
                }
            }
            return status;
        }
        //method checks out a patient from a hospital that has been treated
        //takes in patient name as a parameter
        public void CheckOut(String name)
        {
            for(int i=0; i<countP;i++)
            {
                if (patients[i].GetName() == name)
                {
                    patients[i].Treated();
                    break;
                }
            }
        }
        //method checks to see patients that are sufferring from a specific illness
        //takes in illness name as a parameter
        public string[] SufferringFrom(string illnessName)
        {
            int total = AmountSufferringFrom(illnessName);
            int c = 0;
            string[] patientNames = new string[total];
            for(int i=0;i<countP;i++)
            {
                if(patients[i].GetIllnessName() == illnessName)
                {
                    patientNames[c++] = patients[i].GetName();
                }
            }
            return patientNames;
        }
        //method finds the amount of people affected by a certain illness
        private int AmountSufferringFrom(string illnessName)
        {
            int c = 0;
            for (int i = 0; i < countP; i++)
            {
                if (patients[i].GetIllnessName() == illnessName)
                {
                    c++;
                }
            }
            return c;
        }
        //method checks to see what illness affects the most people
        public string AffectedMostPeople()
        {
            int currentMax = 0;
            int newMax = 0;
            string illnessName = "";
            for(int i = 0; i < countI; i++)
            {
                for(int j=0; j < countP; j++)
                {
                    if(illnesses[i].GetName() == patients[j].GetIllnessName())
                    {
                        newMax++;
                    }
                }
                if (newMax > currentMax)
                {
                    illnessName = illnesses[i].GetName();
                    currentMax = newMax;
                }
                newMax = 0;
            }
            return illnessName;
        } 
    }
}
