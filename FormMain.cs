﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormMain : Form
    {
        int userID = 0;
        Form activeForm = null;

        public FormMain(string lan, int id)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lan);
            RefreshForm();

            userID = id;
        }

        #region Events

        #region Menu

        private void buttonMain_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        #region CardsSubMenu

        private void buttonCards_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCardsSubMenu);
        }

        private void buttonDebitCard_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        private void buttonCreditCard_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        #endregion

        private void buttonTransfers_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        #region PaymentsSubMenu

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPaymentsSubMenu);
        }

        private void buttonBills_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        private void buttonCredit_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        private void buttonTax_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

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
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        private void buttonRates_Click(object sender, EventArgs e)
        {
            //
            // CODE GOES HERE
            //

            HideSubMenus();
        }

        #endregion

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