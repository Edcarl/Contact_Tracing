using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(UserBox.Text == "admin" && Passbox.Text == "password")
            {
                InformationList InfoList = new InformationList();
                InfoList.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username/Password!");
                UserBox.Text = "";
                Passbox.Text = "";
            }
        }
    }
}
