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

namespace TablePatience
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
            foreach (string line in File.ReadLines("Patients.txt", Encoding.Default))
            {                
                string[] array = line.Split();
                Patient patient = new Patient(array);
                dataGridView1.Rows.Add(patient.Id,patient.NamePatient,patient.SurnamePatient,patient.BirthDate,
                    patient.SexPatient,patient.SexPatient);
            }
        }

        private void NewPatButton_Click(object sender, EventArgs e)
        {
            NewPatient newPatient = new NewPatient();
            newPatient.Show();
        }
    }
}
