namespace ANH_Bank.ChildForms
{
    partial class FormChildWithdraw
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

            this.buttonDeposit.BackColor = ANHColorsFonts.Color_ButtonMainBack;
            this.buttonDeposit.Font = ANHColorsFonts.Font_header3;

            this.labelAcc.Font = ANHColorsFonts.Font_header2;
            this.comboBoxAcc.Font = ANHColorsFonts.Font_default;
            this.labelCurr.Font = ANHColorsFonts.Font_header2;
            this.labelCurrVal.Font = ANHColorsFonts.Font_header2;
            this.labelAmount.Font = ANHColorsFonts.Font_header2;
            this.nudAmount.Font = ANHColorsFonts.Font_default;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChildWithdraw));
            this.labelCurrVal = new System.Windows.Forms.Label();
            this.labelCurr = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.comboBoxAcc = new System.Windows.Forms.ComboBox();
            this.labelAcc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrVal
            // 
            resources.ApplyResources(this.labelCurrVal, "labelCurrVal");
            this.labelCurrVal.Name = "labelCurrVal";
            // 
            // labelCurr
            // 
            resources.ApplyResources(this.labelCurr, "labelCurr");
            this.labelCurr.Name = "labelCurr";
            // 
            // nudAmount
            // 
            resources.ApplyResources(this.nudAmount, "nudAmount");
            this.nudAmount.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            // 
            // buttonDeposit
            // 
            resources.ApplyResources(this.buttonDeposit, "buttonDeposit");
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // labelAmount
            // 
            resources.ApplyResources(this.labelAmount, "labelAmount");
            this.labelAmount.Name = "labelAmount";
            // 
            // comboBoxAcc
            // 
            this.comboBoxAcc.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxAcc, "comboBoxAcc");
            this.comboBoxAcc.Name = "comboBoxAcc";
            this.comboBoxAcc.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcc_SelectedIndexChanged);
            // 
            // labelAcc
            // 
            resources.ApplyResources(this.labelAcc, "labelAcc");
            this.labelAcc.Name = "labelAcc";
            // 
            // FormChildWithdraw
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCurrVal);
            this.Controls.Add(this.labelCurr);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.comboBoxAcc);
            this.Controls.Add(this.labelAcc);
            this.Name = "FormChildWithdraw";
            this.Load += new System.EventHandler(this.FormChildWithdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrVal;
        private System.Windows.Forms.Label labelCurr;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.ComboBox comboBoxAcc;
        private System.Windows.Forms.Label labelAcc;
    }
}