using ANH_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildDeposit : Form
    {
        User user = new User();
        Context ctx = new Context();
        string lang = Thread.CurrentThread.CurrentUICulture.Name;

        public FormChildDeposit(int id)
        {
            RefreshForm();
            user = ctx.Users.Find(id);
        }

        #region Events

        private void comboBoxAcc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Account acc = (Account)comboBox.SelectedItem;
            labelCurrVal.Text = acc.Currency.Name;
        }

        private void FormChildDeposit_Load(object sender, System.EventArgs e)
        {
            List<Account> accounts = user.Accounts.ToList();
            foreach (Account account in accounts)
            {
                if (account.Name == null)
                    account.Name = "Account " + account.Id.ToString();
                //account.Name = GetMessage("account", lang) + acc.Id.ToString(); // undo when db created again
            }
            comboBoxAcc.DisplayMember = "Name";
            comboBoxAcc.ValueMember = "Id";
            comboBoxAcc.DataSource = accounts;
        }

        #endregion

        #region Methods

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }


        #endregion

        private void buttonDeposit_Click(object sender, System.EventArgs e)
        {
            decimal amount = nudAmount.Value;
            Account acc = (Account)comboBoxAcc.SelectedItem;
            acc.Balance += amount;

            DW dw = new DW();
            dw.DWTime = DateTime.Now;
            dw.MoneyIn = true;
            dw.Amount = amount;
            dw.Account = acc;
            ctx.DWs.Add(dw);

            ctx.SaveChanges();

            DialogResult dr = MessageBox.Show(Helper.GetMessage("new_balance", lang) + acc.Balance.ToString(), Helper.GetMessage("deposit_success_title", lang), MessageBoxButtons.OK);

            if (dr == DialogResult.OK)
            {
                nudAmount.Value = 0;
            }
        }
    }
}