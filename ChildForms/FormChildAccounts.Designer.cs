using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    partial class FormChildAccounts
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
            this.BackColor = ANHColorsFonts.Color_MainBG;

            this.labelTotal.Font = ANHColorsFonts.Font_header3;
            this.labelTotalVal.Font = ANHColorsFonts.Font_header3;

            this.buttonCreateAccount.BackColor = ANHColorsFonts.Color_ButtonMainBack;
            this.buttonCreateAccount.Font = ANHColorsFonts.Font_header3;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChildAccounts));
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotalVal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelTotal.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.labelTotalVal);
            this.panelTotal.Controls.Add(this.labelTotal);
            resources.ApplyResources(this.panelTotal, "panelTotal");
            this.panelTotal.Name = "panelTotal";
            // 
            // labelTotalVal
            // 
            resources.ApplyResources(this.labelTotalVal, "labelTotalVal");
            this.labelTotalVal.Name = "labelTotalVal";
            // 
            // labelTotal
            // 
            resources.ApplyResources(this.labelTotal, "labelTotal");
            this.labelTotal.Name = "labelTotal";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCreateAccount);
            resources.ApplyResources(this.panelButtons, "panelButtons");
            this.panelButtons.Name = "panelButtons";
            // 
            // buttonCreateAccount
            // 
            resources.ApplyResources(this.buttonCreateAccount, "buttonCreateAccount");
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // panelMiddle
            // 
            resources.ApplyResources(this.panelMiddle, "panelMiddle");
            this.panelMiddle.Name = "panelMiddle";
            // 
            // FormChildAccounts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTotal);
            this.Name = "FormChildAccounts";
            this.Load += new System.EventHandler(this.FormChildAccounts_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotalVal;
        private System.Windows.Forms.Label labelTotal;
        private Panel panelButtons;
        private Button buttonCreateAccount;
        private Panel panelMiddle;
    }
}