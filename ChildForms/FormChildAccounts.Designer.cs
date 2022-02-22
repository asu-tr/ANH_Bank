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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotalVal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.labelTotalVal);
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(408, 75);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotalVal
            // 
            this.labelTotalVal.AutoSize = true;
            this.labelTotalVal.Location = new System.Drawing.Point(250, 31);
            this.labelTotalVal.Name = "labelTotalVal";
            this.labelTotalVal.Size = new System.Drawing.Size(88, 16);
            this.labelTotalVal.TabIndex = 1;
            this.labelTotalVal.Text = "labelTotalVal";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(13, 31);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(68, 16);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "labelTotal";
            // 
            // FormChildAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 606);
            this.Controls.Add(this.panelTotal);
            this.Name = "FormChildAccounts";
            this.Text = "FormChildAccounts";
            this.Load += new System.EventHandler(this.FormChildAccounts_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotalVal;
        private System.Windows.Forms.Label labelTotal;
    }
}