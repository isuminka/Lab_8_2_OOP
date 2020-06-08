using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_8_2_OOP
{
    public partial class Form1 : Form
    {
        Form2 f1;
        Form3 f2;
        Form4 f3;
        Form5 f4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1 = new Form2();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2 = new Form3();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f3 = new Form4();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f4 = new Form5();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Patient> patients = Patient.ReadBD();
            int k = comboBox1.SelectedIndex;
            if (k == 0) patients.Sort((a, b) => a.name.CompareTo(b.name));
            else if (k == 1) patients.Sort((a, b) => a.surname.CompareTo(b.surname));
            else if (k == 2) patients.Sort((a, b) => a.age.CompareTo(b.age));
            else if (k == 3) patients.Sort((a, b) => a.address.CompareTo(b.address));
            else if (k == 4) patients.Sort((a, b) => a.phonenumber.CompareTo(b.phonenumber));

            dataGridView1.RowCount = patients.Count;
            dataGridView1.ColumnCount = 5;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[0, i].Value = patients[i].name;
                dataGridView1[1, i].Value = patients[i].surname;
                dataGridView1[2, i].Value = patients[i].age;
                dataGridView1[3, i].Value = patients[i].address;
                dataGridView1[4, i].Value = patients[i].phonenumber;
            }
        }
    }
    

}
