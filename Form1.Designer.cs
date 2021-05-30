
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
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(63, 50);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(344, 32);
            this.NameBox.TabIndex = 0;
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(200, 121);
            this.NumberBox.Multiline = true;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(207, 32);
            this.NumberBox.TabIndex = 1;
            // 
            // AgeBox
            // 
            this.AgeBox.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeBox.Location = new System.Drawing.Point(63, 121);
            this.AgeBox.Multiline = true;
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(37, 32);
            this.AgeBox.TabIndex = 3;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(12, 56);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(38, 13);
            this.Namelbl.TabIndex = 4;
            this.Namelbl.Text = "Name:";
            // 
            // Numberlbl
            // 
            this.Numberlbl.AutoSize = true;
            this.Numberlbl.Location = new System.Drawing.Point(106, 127);
            this.Numberlbl.Name = "Numberlbl";
            this.Numberlbl.Size = new System.Drawing.Size(87, 13);
            this.Numberlbl.TabIndex = 5;
            this.Numberlbl.Text = "Contact Number:";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Location = new System.Drawing.Point(12, 202);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(48, 13);
            this.Addresslbl.TabIndex = 6;
            this.Addresslbl.Text = "Address:";
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Location = new System.Drawing.Point(12, 127);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(29, 13);
            this.Agelbl.TabIndex = 7;
            this.Agelbl.Text = "Age:";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(63, 202);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(344, 50);
            this.addressBox.TabIndex = 8;
            this.addressBox.Text = "";
            // 
            // btnSave
            // 
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
            this.btnAdmin.Location = new System.Drawing.Point(242, 316);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(127, 54);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // NameInslbl
            // 
            this.NameInslbl.AutoSize = true;
            this.NameInslbl.Location = new System.Drawing.Point(157, 85);
            this.NameInslbl.Name = "NameInslbl";
            this.NameInslbl.Size = new System.Drawing.Size(138, 13);
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
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 488);
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
            this.Name = "LogForm";
            this.Text = "Log Form";
            this.Load += new System.EventHandler(this.LogForm_Load);
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
    }
}

