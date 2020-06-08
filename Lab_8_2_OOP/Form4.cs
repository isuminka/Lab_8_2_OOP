using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8_2_OOP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List <Patient> patients = Patient.ReadBD();
            string surname = textBox1.Text;
            if (patients.All(b => b.surname != surname))
            {
                MessageBox.Show("Пацiєнта з таким прiзвищем не iснує!");
                return;
            }

            int k = comboBox1.SelectedIndex;

            if (k == 0)
            {
                string newname = textBox2.Text;
                patients.FindAll(s => s.surname == surname).ForEach(x => x.name = newname);
                Patient.WriteDB(patients);
            }
            else if (k == 1)
            {
                string newsurname = textBox3.Text;
                patients.FindAll(s => s.surname == surname).ForEach(x => x.surname = newsurname);
                Patient.WriteDB(patients);
            }
            else if (k == 2)
            {
                int newage = Convert.ToInt32(textBox4.Text);
                patients.FindAll(s => s.surname == surname).ForEach(x => x.age = newage);
                Patient.WriteDB(patients);
            }
            else if (k == 3)
            {
                string newaddress = textBox5.Text;
                patients.FindAll(s => s.surname == surname).ForEach(x => x.address = newaddress);
                Patient.WriteDB(patients);
            }
            else if (k == 4)
            {
                string newphonenumber = textBox6.Text;
                patients.FindAll(s => s.surname == surname).ForEach(x => x.phonenumber = newphonenumber);
                Patient.WriteDB(patients);
            }
 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
