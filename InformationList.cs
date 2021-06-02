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
            int i = 0;
            string date = "";
            while (i<file.Length)
            {
                string filename = file[i];
                filename = filename.Replace(".\\Contact_Tracing-", "");
                filename = filename.Replace(".txt", "");
                i++;
                if (SearchBox.Text == filename)
                {
                    date = filename;
                }
            }
            ////for (int i = 0; i < file.Length; i++)
            ////{
            ////    string filename = file[i];
            ////    filename = filename.Replace(".\\Contact_Tracing-", "");
            ////    filename = filename.Replace(".txt", "");
            ////    date = filename;
            ////}

            StreamReader inputFile;
                inputFile = File.OpenText("Contact_Tracing-" + date + ".txt");
                InfoBox.Text = inputFile.ReadToEnd();
                inputFile.Close();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            Admin newadmin = new Admin();
            newadmin.Show();
            this.Hide();
        }
    }
}
