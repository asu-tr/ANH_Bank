namespace ANH_Bank.Popup
{
    partial class FormPopupCreateAccount
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

            this.labelAccName.Font = ANHColorsFonts.Font_header2;
            this.textBoxName.Font = ANHColorsFonts.Font_default;
            this.labelCurr.Font = ANHColorsFonts.Font_header2;
            this.comboBoxCurr.Font = ANHColorsFonts.Font_default;
            this.buttonCreate.BackColor = ANHColorsFonts.Color_ButtonMainBack;
            this.buttonCreate.Font = ANHColorsFonts.Font_header1;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopupCreateAccount));
            this.labelAccName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCurr = new System.Windows.Forms.Label();
            this.comboBoxCurr = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAccName
            // 
            resources.ApplyResources(this.labelAccName, "labelAccName");
            this.labelAccName.Name = "labelAccName";
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            // 
            // labelCurr
            // 
            resources.ApplyResources(this.labelCurr, "labelCurr");
            this.labelCurr.Name = "labelCurr";
            // 
            // comboBoxCurr
            // 
            this.comboBoxCurr.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCurr, "comboBoxCurr");
            this.comboBoxCurr.Name = "comboBoxCurr";
            // 
            // buttonCreate
            // 
            resources.ApplyResources(this.buttonCreate, "buttonCreate");
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // FormPopupCreateAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.comboBoxCurr);
            this.Controls.Add(this.labelCurr);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAccName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPopupCreateAccount";
            this.Load += new System.EventHandler(this.FormPopupCreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCurr;
        private System.Windows.Forms.ComboBox comboBoxCurr;
        private System.Windows.Forms.Button buttonCreate;
    }
}