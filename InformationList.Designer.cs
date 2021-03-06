
namespace Contact_Tracing
{
    partial class InformationList
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
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.Guidelbl = new System.Windows.Forms.Label();
            this.InfoListlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(12, 126);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(776, 441);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = "";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(543, 44);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 23);
            this.Searchbtn.TabIndex = 1;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(172, 47);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(365, 20);
            this.SearchBox.TabIndex = 2;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(713, 12);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutbtn.TabIndex = 3;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // Guidelbl
            // 
            this.Guidelbl.AutoSize = true;
            this.Guidelbl.Location = new System.Drawing.Point(254, 70);
            this.Guidelbl.Name = "Guidelbl";
            this.Guidelbl.Size = new System.Drawing.Size(153, 13);
            this.Guidelbl.TabIndex = 4;
            this.Guidelbl.Text = "(Month-Day-Year Ex. 7-1-2021)";
            // 
            // InfoListlbl
            // 
            this.InfoListlbl.AutoSize = true;
            this.InfoListlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoListlbl.Location = new System.Drawing.Point(271, 14);
            this.InfoListlbl.Name = "InfoListlbl";
            this.InfoListlbl.Size = new System.Drawing.Size(223, 25);
            this.InfoListlbl.TabIndex = 5;
            this.InfoListlbl.Text = "INFORMATION LIST";
            // 
            // InformationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing.Properties.Resources.grbg;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.InfoListlbl);
            this.Controls.Add(this.Guidelbl);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.InfoBox);
            this.MaximizeBox = false;
            this.Name = "InformationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Label Guidelbl;
        private System.Windows.Forms.Label InfoListlbl;
    }
}