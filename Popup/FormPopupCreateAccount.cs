using ANH_Bank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANH_Bank.Popup
{
    public partial class FormPopupCreateAccount : Form
    {
        User User = new User();
        Context Ctx = new Context();
        public Account ReturnAccount = new Account();

        public FormPopupCreateAccount(User user, Context ctx)
        {
            RefreshForm();
            User = user;
            Ctx = ctx;
        }

        #region Events

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Models.Currency curr = comboBoxCurr.SelectedItem as Models.Currency;

            if (User.Accounts.ToList().Where(x => x.CurrencyId == curr.Id).Count() > 1)
                this.DialogResult = DialogResult.Cancel;
            else
            {
                if (string.IsNullOrEmpty(textBoxName.Text))
                    this.ReturnAccount = Helper.CreateAccount(User, curr, null);
                else
                    this.ReturnAccount = Helper.CreateAccount(User, curr, textBoxName.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormPopupCreateAccount_Load(object sender, EventArgs e)
        {
            List<Models.Currency> currencies = Ctx.Currencies.ToList();

            comboBoxCurr.DisplayMember = "Name";
            comboBoxCurr.ValueMember = "Id";
            comboBoxCurr.DataSource = currencies;
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
