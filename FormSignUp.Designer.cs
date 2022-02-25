using System;
using System.Windows.Forms;

namespace ANH_Bank
{
    partial class FormSignUp
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

        private void MyInitializeComponent()
        {
            foreach (Control control in this.Controls)
            {
                Label l = control as Label;
                if (l != null)
                {
                    l.Font = ANHColorsFonts.Font_header3;
                }

                TextBox t = control as TextBox;
                if (t != null)
                {
                    t.Font = ANHColorsFonts.Font_default;
                }
            }

            this.BackColor = ANHColorsFonts.Color_MainBG;

            this.buttonSignUp.Font = ANHColorsFonts.Font_header2;
            this.buttonSignUp.BackColor = ANHColorsFonts.Color_ButtonMainBack;

            System.DateTime today = System.DateTime.Now;
            System.DateTime max = new System.DateTime(today.Year - 18, today.Month, today.Day, today.Hour, today.Minute, today.Second);
            this.dtp.MaxDate = max;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelFN = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.labelBD = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelSecQ = new System.Windows.Forms.Label();
            this.comboBoxSecQ = new System.Windows.Forms.ComboBox();
            this.textBoxSecA = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelSecA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelID
            // 
            resources.ApplyResources(this.labelID, "labelID");
            this.labelID.Name = "labelID";
            // 
            // textBoxID
            // 
            resources.ApplyResources(this.textBoxID, "textBoxID");
            this.textBoxID.Name = "textBoxID";
            // 
            // labelFN
            // 
            resources.ApplyResources(this.labelFN, "labelFN");
            this.labelFN.Name = "labelFN";
            // 
            // textBoxFN
            // 
            resources.ApplyResources(this.textBoxFN, "textBoxFN");
            this.textBoxFN.Name = "textBoxFN";
            // 
            // labelBD
            // 
            resources.ApplyResources(this.labelBD, "labelBD");
            this.labelBD.Name = "labelBD";
            // 
            // labelLN
            // 
            resources.ApplyResources(this.labelLN, "labelLN");
            this.labelLN.Name = "labelLN";
            // 
            // textBoxLN
            // 
            resources.ApplyResources(this.textBoxLN, "textBoxLN");
            this.textBoxLN.Name = "textBoxLN";
            // 
            // labelAddress
            // 
            resources.ApplyResources(this.labelAddress, "labelAddress");
            this.labelAddress.Name = "labelAddress";
            // 
            // textBoxAddress
            // 
            resources.ApplyResources(this.textBoxAddress, "textBoxAddress");
            this.textBoxAddress.Name = "textBoxAddress";
            // 
            // dtp
            // 
            resources.ApplyResources(this.dtp, "dtp");
            this.dtp.Name = "dtp";
            // 
            // labelPhone
            // 
            resources.ApplyResources(this.labelPhone, "labelPhone");
            this.labelPhone.Name = "labelPhone";
            // 
            // textBoxPhone
            // 
            resources.ApplyResources(this.textBoxPhone, "textBoxPhone");
            this.textBoxPhone.Name = "textBoxPhone";
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.Name = "labelEmail";
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(this.textBoxEmail, "textBoxEmail");
            this.textBoxEmail.Name = "textBoxEmail";
            // 
            // labelSecQ
            // 
            resources.ApplyResources(this.labelSecQ, "labelSecQ");
            this.labelSecQ.Name = "labelSecQ";
            // 
            // comboBoxSecQ
            // 
            this.comboBoxSecQ.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSecQ, "comboBoxSecQ");
            this.comboBoxSecQ.Name = "comboBoxSecQ";
            // 
            // textBoxSecA
            // 
            resources.ApplyResources(this.textBoxSecA, "textBoxSecA");
            this.textBoxSecA.Name = "textBoxSecA";
            // 
            // buttonSignUp
            // 
            resources.ApplyResources(this.buttonSignUp, "buttonSignUp");
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelSecA
            // 
            resources.ApplyResources(this.labelSecA, "labelSecA");
            this.labelSecA.Name = "labelSecA";
            // 
            // FormSignUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.comboBoxSecQ);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.labelSecA);
            this.Controls.Add(this.labelSecQ);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.textBoxSecA);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSignUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSignUp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelSecQ;
        private System.Windows.Forms.ComboBox comboBoxSecQ;
        private System.Windows.Forms.TextBox textBoxSecA;
        private System.Windows.Forms.Button buttonSignUp;
        private Label labelSecA;
    }
}