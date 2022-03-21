using ANH_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildWithdraw : Form
    {
        User user = new User();
        Context ctx = new Context();
        string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;

        public FormChildWithdraw(int id)
        {
            RefreshForm();
            user = ctx.Users.Find(id);
        }

        #region Events

        private void buttonDeposit_Click(object sender, System.EventArgs e)
        {
            Account acc = (Account)comboBoxAcc.SelectedItem;

            if (acc != null)
            {
                acc.Balance -= nudAmount.Value;
                DW dw = new DW();
                dw.DWTime = System.DateTime.Now;
                dw.MoneyIn = false;
                dw.Amount = nudAmount.Value;
                dw.Account = acc;
                ctx.DWs.Add(dw);

                ctx.SaveChanges();

                DialogResult dr = MessageBox.Show("Your new balance is: " + acc.Balance.ToString(), "Success", MessageBoxButtons.OK);
                //DialogResult dr = MessageBox.Show(Helper.GetMessage("new_withdraw_balance", lang) + acc.Balance.ToString(), Helper.GetMessage("withdraw_success_title", lang), MessageBoxButtons.OK); // add this to messages list

                if (dr == DialogResult.OK)
                {
                    nudAmount.Value = 1;
                    labelBalanceVal.Text = acc.Balance.ToString();
                }
            }
        }

        private void comboBoxAcc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Account acc = (Account)comboBox.SelectedItem;
            labelCurrVal.Text = acc.Currency.Name;
            labelBalanceVal.Text = acc.Balance.ToString();
            nudAmount.Minimum = 1;
            nudAmount.Maximum = Math.Floor(acc.Balance);
        }

        private void FormChildWithdraw_Load(object sender, System.EventArgs e)
        {
            List<Account> accounts = user.Accounts.ToList();
            accounts = accounts.Where(a => a.Balance >= 1).ToList();
            foreach (Account account in accounts)
            {
                if (account.Name == null)
                    account.Name = Helper.GetMessage("account", lang) + account.Id.ToString();
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
    }
}