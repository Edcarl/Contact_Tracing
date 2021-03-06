using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }


        private void timer_tick(object sender, EventArgs e)
        {
            DateTimelbl.Text = DateTime.Now.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            String DateofVisit = DateTime.Now.ToString();
            String Date = DateTime.Now.ToShortDateString().Replace("/", "-");
            outputFile = File.AppendText("Contact_Tracing-" + Date + ".txt");
            outputFile.WriteLine(Namelbl.Text + "" + NameBox.Text);
            outputFile.WriteLine(Agelbl.Text + "" + AgeBox.Text);
            outputFile.WriteLine(Numberlbl.Text + "" + NumberBox.Text);
            outputFile.WriteLine(Addresslbl.Text + "" + addressBox.Text);
            outputFile.WriteLine(DateofVisit);
            outputFile.WriteLine("=====================================");
            outputFile.Close();
            MessageBox.Show("Saved!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NameBox.Clear();
            AgeBox.Clear();
            NumberBox.Clear();
            addressBox.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Hide();
        }

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void AgeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
