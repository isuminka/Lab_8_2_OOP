using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8_2_OOP
{
    class Patient
    {
        private string Name;
        private string Surname;
        private int Age;
        private string Address;
        private string PhoneNumber;

        public Patient() { }
        public Patient(string name, string surname, int age, string address, string phonenumber)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Address = address;
            PhoneNumber = phonenumber;
        }

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }

        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }

        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }

        public string phonenumber
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                PhoneNumber = value;
            }
        }

        static public void WriteDB(List<Patient> patients)
        {
            string textRow;
            StreamWriter file = new StreamWriter("output.txt");
            foreach (Patient rr in patients)
            {
                textRow = rr.name + ";" + rr.surname + ";" + Convert.ToString(rr.age) + ";" +
                    rr.address + ";" + rr.phonenumber;
                file.WriteLine(textRow);
            }
            file.Close();
        }

        static public List<Patient> ReadBD()
        {
            string textRow;
            string pName, pSurname, sAge, pAddress, pPhoneNumber;
            int pAge;
            int i, ip;
            List<Patient> patients = new List<Patient>();
            StreamReader file = new StreamReader("output.txt");
            while (file.Peek() >= 0)
            {
                pName = ""; pSurname = ""; sAge = ""; pAddress = ""; pPhoneNumber = "";
                textRow = file.ReadLine();
                i = textRow.IndexOf(';') - 1;
                for (int j = 0; j <= i; j++) pName = pName + textRow[j];
                ip = i + 2;
                i = textRow.IndexOf(';', ip) - 1;
                for (int j = ip; j <= i; j++) pSurname = pSurname + textRow[j];
                ip = i + 2;
                i = textRow.IndexOf(';', ip) - 1;
                for (int j = ip; j <= i; j++) sAge = sAge + textRow[j];
                ip = i + 2;
                i = textRow.IndexOf(';', ip) - 1;
                for (int j = ip; j <= i; j++) pAddress = pAddress + textRow[j];
                ip = i + 2;
                for (int j = ip; j <= textRow.Length - 1; j++) pPhoneNumber = pPhoneNumber + textRow[j];
                pAge = Convert.ToInt32(sAge);
                patients.Add(new Patient(pName, pSurname, pAge, pAddress, pPhoneNumber));
            }
            file.Close();
            return patients;

        }

    }
}
