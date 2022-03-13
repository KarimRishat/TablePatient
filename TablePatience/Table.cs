using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablePatience
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();

        }

        private void NewPatButton_Click(object sender, EventArgs e)
        {
            NewPatient newPatient = new NewPatient();
            newPatient.Show();
        }
    }
}
