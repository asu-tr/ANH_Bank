using ANH_Bank.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildMain : Form
    {
        User user = new User();
        Context ctx = new Context();
        string lang = Thread.CurrentThread.CurrentUICulture.Name;

        public FormChildMain(int id)
        {
            RefreshForm();
            user = ctx.Users.Find(id);
        }

        #region Events

        private void FormChildMain_Load(object sender, System.EventArgs e)
        {
            labelWelcome.Text += user.FirstName;

            List<Account> accounts = user.Accounts.OrderByDescending(x => x.Balance).Take(3).ToList();

            foreach (Account account in accounts)
            {
                Panel panel = new Panel();
                panel.Name = "panel" + account.Id.ToString();
                panel.Tag = account.Id.ToString();
                panel.Size = new System.Drawing.Size(340, 25);
                panel.Dock = DockStyle.Top;
                panel.BackColor = ANHColorsFonts.Color_ButtonSubBack;

                flpAccounts.Controls.Add(panel);

                Label labelAcc = new Label();
                labelAcc.Name = "labelAcc" + account.Id.ToString();
                if (string.IsNullOrEmpty(account.Name))
                    labelAcc.Text = Helper.GetMessage("account", lang) + account.Id.ToString();
                else
                    labelAcc.Text = account.Name;
                labelAcc.Dock = DockStyle.Left;
                labelAcc.Size = new System.Drawing.Size(170, 25);
                labelAcc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
                labelAcc.Font = ANHColorsFonts.Font_default;
                labelAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                Label labelVal = new Label();
                labelVal.Name = "labelVal" + account.Id.ToString();
                labelVal.Text = account.Currency.Name + " " + account.Balance.ToString();
                labelVal.Dock = DockStyle.Right;
                labelVal.Size = new System.Drawing.Size(170, 25);
                labelVal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
                labelVal.Font = ANHColorsFonts.Font_default;
                labelVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                panel.Controls.Add(labelAcc);
                panel.Controls.Add(labelVal);
            }
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