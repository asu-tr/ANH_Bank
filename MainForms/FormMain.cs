using ANH_Bank.ChildForms;
using System;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormMain : Form
    {
        int UserID = -1;
        Form activeForm = null;

        public FormMain(int id)
        {
            RefreshForm();
            UserID = id;
        }

        #region Events

        #region Menu

        private void buttonMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildMain());
            HideSubMenus();
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildAccounts(UserID));
            HideSubMenus();
        }

        #region CardsSubMenu

        private void buttonCards_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCardsSubMenu);
        }

        private void buttonDebitCard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildDebitCard());
            HideSubMenus();
        }

        private void buttonCreditCard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildCreditCard());
            HideSubMenus();
        }

        #endregion

        private void buttonTransfers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildTransfers());
            HideSubMenus();
        }

        #region PaymentsSubMenu

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPaymentsSubMenu);
        }

        private void buttonBills_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildBills());
            HideSubMenus();
        }

        private void buttonTax_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildTax());
            HideSubMenus();
        }

        #endregion

        #region ExchangeSubMenu

        private void buttonExchange_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelExchangeSubMenu);
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildBuy());
            HideSubMenus();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildSell());
            HideSubMenus();
        }

        private void buttonRates_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildRates());
            HideSubMenus();
        }

        #endregion

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildDeposit(UserID));
            HideSubMenus();
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildWithdraw());
            HideSubMenus();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildSettings());
            HideSubMenus();
        }

        #endregion

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void HideSubMenus()
        {
            if (panelCardsSubMenu.Visible == true)
            {
                panelCardsSubMenu.Visible = false;
            }
            if (panelPaymentsSubMenu.Visible == true)
            {
                panelPaymentsSubMenu.Visible = false;
            }
            if (panelExchangeSubMenu.Visible == true)
            {
                panelExchangeSubMenu.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

    }
}