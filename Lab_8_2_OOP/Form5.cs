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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Patient> patients = Patient.ReadBD();
            string surname = Console.ReadLine();
            if (patients.All(b => b.surname != surname))
            {
                MessageBox.Show("Пацiєнта з таким прiзвищем не iснує!");
                return;
            }
            var itemToDelete = patients.Where(x => x.surname == surname).Select(x => x).First();
            patients.Remove(itemToDelete);
            Patient.WriteDB(patients);
        }
    }
}
