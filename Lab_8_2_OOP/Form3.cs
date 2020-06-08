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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Patient> patients = Patient.ReadBD();
            string name = textBox1.Text;
            string surname = textBox2.Text;
            int age = Convert.ToInt32(textBox3.Text);
            string address = textBox4.Text;
            string phonenumber = textBox5.Text;

            patients.Add(new Patient(name, surname, age, address, phonenumber));
            Patient.WriteDB(patients);
        }
    }
}
