
namespace Contact_Tracing
{
    partial class LogForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Numberlbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.Agelbl = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.NameInslbl = new System.Windows.Forms.Label();
            this.DateTimelbl = new System.Windows.Forms.Label();
            this.TimerDT = new System.Windows.Forms.Timer(this.components);
            this.CTFormlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(63, 50);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(344, 32);
            this.NameBox.TabIndex = 0;
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(200, 121);
            this.NumberBox.MaxLength = 11;
            this.NumberBox.Multiline = true;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(207, 32);
            this.NumberBox.TabIndex = 1;
            this.NumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // AgeBox
            // 
            this.AgeBox.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeBox.Location = new System.Drawing.Point(63, 121);
            this.AgeBox.MaxLength = 2;
            this.AgeBox.Multiline = true;
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(37, 32);
            this.AgeBox.TabIndex = 3;
            this.AgeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeBox_KeyPress);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(13, 56);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(47, 17);
            this.Namelbl.TabIndex = 4;
            this.Namelbl.Text = "Name:";
            // 
            // Numberlbl
            // 
            this.Numberlbl.AutoSize = true;
            this.Numberlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numberlbl.Location = new System.Drawing.Point(103, 127);
            this.Numberlbl.Name = "Numberlbl";
            this.Numberlbl.Size = new System.Drawing.Size(97, 15);
            this.Numberlbl.TabIndex = 5;
            this.Numberlbl.Text = "Contact Number:";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslbl.Location = new System.Drawing.Point(5, 202);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(60, 17);
            this.Addresslbl.TabIndex = 6;
            this.Addresslbl.Text = "Address:";
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agelbl.Location = new System.Drawing.Point(13, 127);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(36, 17);
            this.Agelbl.TabIndex = 7;
            this.Agelbl.Text = "Age:";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(63, 202);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(344, 62);
            this.addressBox.TabIndex = 8;
            this.addressBox.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(63, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 54);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(63, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 54);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(242, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 54);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdmin.Location = new System.Drawing.Point(242, 316);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(127, 54);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // NameInslbl
            // 
            this.NameInslbl.AutoSize = true;
            this.NameInslbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInslbl.Location = new System.Drawing.Point(134, 85);
            this.NameInslbl.Name = "NameInslbl";
            this.NameInslbl.Size = new System.Drawing.Size(176, 17);
            this.NameInslbl.TabIndex = 13;
            this.NameInslbl.Text = "(Surname, Given Name, MI)";
            // 
            // DateTimelbl
            // 
            this.DateTimelbl.AutoSize = true;
            this.DateTimelbl.Location = new System.Drawing.Point(277, 471);
            this.DateTimelbl.Name = "DateTimelbl";
            this.DateTimelbl.Size = new System.Drawing.Size(53, 13);
            this.DateTimelbl.TabIndex = 14;
            this.DateTimelbl.Text = "DateTime";
            // 
            // TimerDT
            // 
            this.TimerDT.Enabled = true;
            this.TimerDT.Interval = 1000;
            this.TimerDT.Tick += new System.EventHandler(this.timer_tick);
            // 
            // CTFormlbl
            // 
            this.CTFormlbl.AutoSize = true;
            this.CTFormlbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTFormlbl.Location = new System.Drawing.Point(125, 9);
            this.CTFormlbl.Name = "CTFormlbl";
            this.CTFormlbl.Size = new System.Drawing.Size(193, 23);
            this.CTFormlbl.TabIndex = 15;
            this.CTFormlbl.Text = "Contact Tracing Form";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing.Properties.Resources.grbg;
            this.ClientSize = new System.Drawing.Size(430, 488);
            this.Controls.Add(this.CTFormlbl);
            this.Controls.Add(this.DateTimelbl);
            this.Controls.Add(this.NameInslbl);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.Agelbl);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Numberlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.NameBox);
            this.MaximizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Numberlbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label Agelbl;
        private System.Windows.Forms.RichTextBox addressBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label NameInslbl;
        private System.Windows.Forms.Label DateTimelbl;
        private System.Windows.Forms.Timer TimerDT;
        private System.Windows.Forms.Label CTFormlbl;
    }
}

