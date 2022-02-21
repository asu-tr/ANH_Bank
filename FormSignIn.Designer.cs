namespace ANH_Bank
{
    partial class FormSignIn
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
            this.labelID.Font = ANHColorsFonts.Font_header2;
            this.textBoxID.Font = ANHColorsFonts.Font_default;
            this.labelPwd.Font = ANHColorsFonts.Font_header2;
            this.textBoxPwd.Font = ANHColorsFonts.Font_default;
            this.buttonSignIn.Font = ANHColorsFonts.Font_header1;
            this.labelForgotPwd.Font = ANHColorsFonts.Font_default;

            this.BackColor = ANHColorsFonts.Color_MainBG;
            this.buttonSignIn.BackColor = ANHColorsFonts.Color_ButtonMainBack;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.labelID = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.labelForgotPwd = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            resources.ApplyResources(this.labelID, "labelID");
            this.labelID.Name = "labelID";
            // 
            // labelPwd
            // 
            resources.ApplyResources(this.labelPwd, "labelPwd");
            this.labelPwd.Name = "labelPwd";
            // 
            // textBoxID
            // 
            resources.ApplyResources(this.textBoxID, "textBoxID");
            this.textBoxID.Name = "textBoxID";
            // 
            // textBoxPwd
            // 
            resources.ApplyResources(this.textBoxPwd, "textBoxPwd");
            this.textBoxPwd.Name = "textBoxPwd";
            // 
            // labelForgotPwd
            // 
            resources.ApplyResources(this.labelForgotPwd, "labelForgotPwd");
            this.labelForgotPwd.Name = "labelForgotPwd";
            // 
            // buttonSignIn
            // 
            resources.ApplyResources(this.buttonSignIn, "buttonSignIn");
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // FormSignIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelForgotPwd);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSignIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSignIn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label labelForgotPwd;
        private System.Windows.Forms.Button buttonSignIn;
    }
}