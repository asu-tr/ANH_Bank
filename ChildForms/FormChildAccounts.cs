using ANH_Bank.Currency;
using ANH_Bank.Models;
using ANH_Bank.Popup;
using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildAccounts : Form
    {
        User user = new User();
        string lang = Thread.CurrentThread.CurrentUICulture.Name;
        Context ctx = new Context();

        public FormChildAccounts(int id)
        {
            RefreshForm();
            user = ctx.Users.Find(id);
        }

        #region Events

        private void buttonCreateAccount_Click(object sender, System.EventArgs e)
        {
            using (var form = new FormPopupCreateAccount(user, ctx))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Account a = new Account();
                    a = form.ReturnAccount;

                    ctx.Accounts.Add(a);
                    ctx.SaveChanges();
                    form.Dispose();

                    this.Controls.Clear();
                    this.RefreshForm();
                    LoadForm();
                }
            }
        }

        private void FormChildAccounts_Load(object sender, System.EventArgs e)
        {
            LoadForm();
        }

        #endregion

        #region Methods

        private void CreateAccountPanel(Account acc)
        {
            Panel panel = new Panel();
            panel.Name = "panel"+ acc.Id.ToString();
            panel.Tag = acc.Id.ToString();
            panel.Size = new System.Drawing.Size(408, 30);
            panel.Dock = DockStyle.Top;

            panel.DoubleClick += OpenAccountDetails;

            this.panelMiddle.Controls.Add(panel);

            Label labelAcc = new Label();
            labelAcc.Name = "labelAcc"+acc.Id.ToString();
            if (string.IsNullOrEmpty(acc.Name))
                labelAcc.Text = Helper.GetMessage("account", lang) + acc.Id.ToString();
            else
                labelAcc.Text = acc.Name;
            labelAcc.Dock = DockStyle.Left;
            labelAcc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            labelAcc.Font = ANHColorsFonts.Font_default;

            Label labelVal = new Label();
            labelVal.Name = "labelVal" + acc.Id.ToString();
            labelVal.Text = acc.Currency.Name + " "+ acc.Balance.ToString();
            labelVal.Dock = DockStyle.Right;
            labelVal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            labelVal.Font = ANHColorsFonts.Font_default;

            panel.Controls.Add(labelAcc);
            panel.Controls.Add(labelVal);
        }

        private void LoadForm()
        {
            decimal total = 0;

            var converter = new Converter(Helper.GetCurrencyAPIKey());
            double usdtry = converter.Convert(1, CurrencyType.USD, CurrencyType.TRY);
            double eurtry = converter.Convert(1, CurrencyType.EUR, CurrencyType.TRY);
            double gbptry = converter.Convert(1, CurrencyType.GBP, CurrencyType.TRY);

            foreach (Account account in user.Accounts)
            {
                CreateAccountPanel(account);
                switch (account.Currency.Name)
                {
                    case "TRY":
                        total += account.Balance;
                        break;

                    case "USD":
                        total += account.Balance * (decimal)usdtry;
                        break;

                    case "EUR":
                        total += account.Balance * (decimal)eurtry;
                        break;

                    case "GBP":
                        total += account.Balance * (decimal)gbptry;
                        break;

                    default:
                        break;
                }
            }

            labelTotalVal.Text = "TRY " + total.ToString("0.00");
        }

        private void OpenAccountDetails(object sender, System.EventArgs e)
        {
            // code goes here
        }

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        #endregion
    }
}