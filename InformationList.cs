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
    public partial class InformationList : Form
    {
        public InformationList()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            String[] file = Directory.GetFiles(".", "Contact_Tracing-*");
            string date = "";
            for (int i = 0; i < file.Length; i++)
            {
                string filename = file[i];
                filename = filename.Replace(".\\Contact_Tracing-", "");
                filename = filename.Replace(".txt", "");
                   
                if (SearchBox.Text == filename)
                  {
                     date = filename;
                  }

            }

            StreamReader inputFile;
            if (date != "")
            {
                inputFile = File.OpenText("Contact_Tracing-" + date + ".txt");
                InfoBox.Text = inputFile.ReadToEnd();
                inputFile.Close();
            }
            else
            {
                MessageBox.Show("Sorry there's no record for that day");
            }
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            Admin newadmin = new Admin();
            newadmin.Show();
            this.Hide();
        }
    }
}
