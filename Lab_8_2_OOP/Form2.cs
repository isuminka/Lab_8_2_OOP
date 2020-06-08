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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Patient> patients = Patient.ReadBD();
            dataGridView1.RowCount = patients.Count;
            dataGridView1.ColumnCount = 5;
            for(int i = 0; i < dataGridView1.RowCount; i++)
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
