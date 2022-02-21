namespace ANH_Bank
{
    partial class FormMain
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
            this.panelCardsSubMenu.Visible = false;
            this.panelPaymentsSubMenu.Visible = false;
            this.panelExchangeSubMenu.Visible = false;

            //this.labelID.Font = ANHColorsFonts.FontANH_header2;
            //this.textBoxID.Font = ANHColorsFonts.FontANH_default;
            //this.labelPwd.Font = ANHColorsFonts.FontANH_header2;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.panelExchangeSubMenu = new System.Windows.Forms.Panel();
            this.buttonRates = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonExchange = new System.Windows.Forms.Button();
            this.panelPaymentsSubMenu = new System.Windows.Forms.Panel();
            this.buttonTax = new System.Windows.Forms.Button();
            this.buttonCredit = new System.Windows.Forms.Button();
            this.buttonBills = new System.Windows.Forms.Button();
            this.buttonPayments = new System.Windows.Forms.Button();
            this.buttonTransfers = new System.Windows.Forms.Button();
            this.panelCardsSubMenu = new System.Windows.Forms.Panel();
            this.buttonCreditCard = new System.Windows.Forms.Button();
            this.buttonDebitCard = new System.Windows.Forms.Button();
            this.buttonCards = new System.Windows.Forms.Button();
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelExchangeSubMenu.SuspendLayout();
            this.panelPaymentsSubMenu.SuspendLayout();
            this.panelCardsSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            resources.ApplyResources(this.panelSideMenu, "panelSideMenu");
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSideMenu.Controls.Add(this.buttonSettings);
            this.panelSideMenu.Controls.Add(this.buttonWithdraw);
            this.panelSideMenu.Controls.Add(this.buttonDeposit);
            this.panelSideMenu.Controls.Add(this.panelExchangeSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonExchange);
            this.panelSideMenu.Controls.Add(this.panelPaymentsSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonPayments);
            this.panelSideMenu.Controls.Add(this.buttonTransfers);
            this.panelSideMenu.Controls.Add(this.panelCardsSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonCards);
            this.panelSideMenu.Controls.Add(this.buttonAccounts);
            this.panelSideMenu.Controls.Add(this.buttonMain);
            this.panelSideMenu.Name = "panelSideMenu";
            // 
            // buttonSettings
            // 
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonWithdraw
            // 
            resources.ApplyResources(this.buttonWithdraw, "buttonWithdraw");
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonDeposit
            // 
            resources.ApplyResources(this.buttonDeposit, "buttonDeposit");
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // panelExchangeSubMenu
            // 
            resources.ApplyResources(this.panelExchangeSubMenu, "panelExchangeSubMenu");
            this.panelExchangeSubMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelExchangeSubMenu.Controls.Add(this.buttonRates);
            this.panelExchangeSubMenu.Controls.Add(this.buttonSell);
            this.panelExchangeSubMenu.Controls.Add(this.buttonBuy);
            this.panelExchangeSubMenu.Name = "panelExchangeSubMenu";
            // 
            // buttonRates
            // 
            resources.ApplyResources(this.buttonRates, "buttonRates");
            this.buttonRates.FlatAppearance.BorderSize = 0;
            this.buttonRates.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRates.Name = "buttonRates";
            this.buttonRates.UseVisualStyleBackColor = true;
            this.buttonRates.Click += new System.EventHandler(this.buttonRates_Click);
            // 
            // buttonSell
            // 
            resources.ApplyResources(this.buttonSell, "buttonSell");
            this.buttonSell.FlatAppearance.BorderSize = 0;
            this.buttonSell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonBuy
            // 
            resources.ApplyResources(this.buttonBuy, "buttonBuy");
            this.buttonBuy.FlatAppearance.BorderSize = 0;
            this.buttonBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonExchange
            // 
            resources.ApplyResources(this.buttonExchange, "buttonExchange");
            this.buttonExchange.FlatAppearance.BorderSize = 0;
            this.buttonExchange.Name = "buttonExchange";
            this.buttonExchange.UseVisualStyleBackColor = true;
            this.buttonExchange.Click += new System.EventHandler(this.buttonExchange_Click);
            // 
            // panelPaymentsSubMenu
            // 
            resources.ApplyResources(this.panelPaymentsSubMenu, "panelPaymentsSubMenu");
            this.panelPaymentsSubMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelPaymentsSubMenu.Controls.Add(this.buttonTax);
            this.panelPaymentsSubMenu.Controls.Add(this.buttonCredit);
            this.panelPaymentsSubMenu.Controls.Add(this.buttonBills);
            this.panelPaymentsSubMenu.Name = "panelPaymentsSubMenu";
            // 
            // buttonTax
            // 
            resources.ApplyResources(this.buttonTax, "buttonTax");
            this.buttonTax.FlatAppearance.BorderSize = 0;
            this.buttonTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTax.Name = "buttonTax";
            this.buttonTax.UseVisualStyleBackColor = true;
            this.buttonTax.Click += new System.EventHandler(this.buttonTax_Click);
            // 
            // buttonCredit
            // 
            resources.ApplyResources(this.buttonCredit, "buttonCredit");
            this.buttonCredit.FlatAppearance.BorderSize = 0;
            this.buttonCredit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCredit.Name = "buttonCredit";
            this.buttonCredit.UseVisualStyleBackColor = true;
            this.buttonCredit.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // buttonBills
            // 
            resources.ApplyResources(this.buttonBills, "buttonBills");
            this.buttonBills.FlatAppearance.BorderSize = 0;
            this.buttonBills.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBills.Name = "buttonBills";
            this.buttonBills.UseVisualStyleBackColor = true;
            this.buttonBills.Click += new System.EventHandler(this.buttonBills_Click);
            // 
            // buttonPayments
            // 
            resources.ApplyResources(this.buttonPayments, "buttonPayments");
            this.buttonPayments.FlatAppearance.BorderSize = 0;
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.UseVisualStyleBackColor = true;
            this.buttonPayments.Click += new System.EventHandler(this.buttonPayments_Click);
            // 
            // buttonTransfers
            // 
            resources.ApplyResources(this.buttonTransfers, "buttonTransfers");
            this.buttonTransfers.Name = "buttonTransfers";
            this.buttonTransfers.UseVisualStyleBackColor = true;
            this.buttonTransfers.Click += new System.EventHandler(this.buttonTransfers_Click);
            // 
            // panelCardsSubMenu
            // 
            resources.ApplyResources(this.panelCardsSubMenu, "panelCardsSubMenu");
            this.panelCardsSubMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelCardsSubMenu.Controls.Add(this.buttonCreditCard);
            this.panelCardsSubMenu.Controls.Add(this.buttonDebitCard);
            this.panelCardsSubMenu.Name = "panelCardsSubMenu";
            // 
            // buttonCreditCard
            // 
            resources.ApplyResources(this.buttonCreditCard, "buttonCreditCard");
            this.buttonCreditCard.FlatAppearance.BorderSize = 0;
            this.buttonCreditCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreditCard.Name = "buttonCreditCard";
            this.buttonCreditCard.UseVisualStyleBackColor = true;
            this.buttonCreditCard.Click += new System.EventHandler(this.buttonCreditCard_Click);
            // 
            // buttonDebitCard
            // 
            resources.ApplyResources(this.buttonDebitCard, "buttonDebitCard");
            this.buttonDebitCard.FlatAppearance.BorderSize = 0;
            this.buttonDebitCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDebitCard.Name = "buttonDebitCard";
            this.buttonDebitCard.UseVisualStyleBackColor = true;
            this.buttonDebitCard.Click += new System.EventHandler(this.buttonDebitCard_Click);
            // 
            // buttonCards
            // 
            resources.ApplyResources(this.buttonCards, "buttonCards");
            this.buttonCards.FlatAppearance.BorderSize = 0;
            this.buttonCards.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCards.Name = "buttonCards";
            this.buttonCards.UseVisualStyleBackColor = true;
            this.buttonCards.Click += new System.EventHandler(this.buttonCards_Click);
            // 
            // buttonAccounts
            // 
            resources.ApplyResources(this.buttonAccounts, "buttonAccounts");
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.UseVisualStyleBackColor = true;
            this.buttonAccounts.Click += new System.EventHandler(this.buttonAccounts_Click);
            // 
            // buttonMain
            // 
            resources.ApplyResources(this.buttonMain, "buttonMain");
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // panelChildForm
            // 
            resources.ApplyResources(this.panelChildForm, "panelChildForm");
            this.panelChildForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelChildForm.Name = "panelChildForm";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.panelSideMenu.ResumeLayout(false);
            this.panelExchangeSubMenu.ResumeLayout(false);
            this.panelPaymentsSubMenu.ResumeLayout(false);
            this.panelCardsSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelCardsSubMenu;
        private System.Windows.Forms.Button buttonCreditCard;
        private System.Windows.Forms.Button buttonDebitCard;
        private System.Windows.Forms.Button buttonCards;
        private System.Windows.Forms.Button buttonAccounts;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Panel panelPaymentsSubMenu;
        private System.Windows.Forms.Button buttonCredit;
        private System.Windows.Forms.Button buttonBills;
        private System.Windows.Forms.Button buttonPayments;
        private System.Windows.Forms.Button buttonTransfers;
        private System.Windows.Forms.Button buttonTax;
        private System.Windows.Forms.Panel panelExchangeSubMenu;
        private System.Windows.Forms.Button buttonRates;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonExchange;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonSettings;
    }
}