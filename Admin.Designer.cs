
namespace Contact_Tracing
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserBox = new System.Windows.Forms.TextBox();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.Location = new System.Drawing.Point(98, 103);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(234, 24);
            this.UserBox.TabIndex = 0;
            this.UserBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Passbox
            // 
            this.Passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passbox.Location = new System.Drawing.Point(98, 173);
            this.Passbox.Name = "Passbox";
            this.Passbox.PasswordChar = '*';
            this.Passbox.Size = new System.Drawing.Size(234, 24);
            this.Passbox.TabIndex = 1;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Location = new System.Drawing.Point(184, 130);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(55, 13);
            this.Userlbl.TabIndex = 2;
            this.Userlbl.Text = "Username";
            this.Userlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Location = new System.Drawing.Point(184, 202);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(53, 13);
            this.Passlbl.TabIndex = 3;
            this.Passlbl.Text = "Password";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(148, 274);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(127, 54);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(148, 339);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(127, 54);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 488);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.UserBox);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}