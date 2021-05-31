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

        private void LogForm_Load(object sender, EventArgs e)
        {
               
        }

        private void timer_tick(object sender, EventArgs e)
        {
            DateTimelbl.Text = DateTime.Now.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            String DateofVisit = DateTime.Now.ToString();
            String Date = DateTime.Now.ToLongDateString();
            outputFile = File.AppendText("Contact_Tracing-" + Date + ".txt");
            outputFile.WriteLine(Namelbl.Text + "" + NameBox.Text);
            outputFile.WriteLine(Agelbl.Text + "" + AgeBox.Text);
            outputFile.WriteLine(Numberlbl.Text + "" + NumberBox.Text);
            outputFile.WriteLine(Addresslbl.Text + "" + addressBox.Text);
            outputFile.WriteLine(DateofVisit);
            outputFile.WriteLine("=====================================");
            outputFile.Close();
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

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Hide();
        }
    }
}
