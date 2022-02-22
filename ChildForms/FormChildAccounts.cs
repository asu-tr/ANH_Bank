using System.Collections.Generic;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildAccounts : Form
    {
        int UserID = -1;

        public FormChildAccounts(int id)
        {
            RefreshForm();
            UserID = id;
        }

        #region Events

        private void FormChildAccounts_Load(object sender, System.EventArgs e)
        {
            foreach (string account in GetAccounts(UserID))
            {
                CreateAccountPanel(account);
            }

            BringTotalToFront();
        }

        #endregion

        #region Methods

        private void BringTotalToFront()
        {
            this.Controls.Remove(panelTotal);
            this.Controls.Add(panelTotal);
        }

        private void CreateAccountPanel(string account)
        {
            Panel panel = new Panel();
            panel.Name = account; // panel+account.id
            panel.Tag = account; // account.id
            panel.Size = new System.Drawing.Size(408, 70);
            panel.Dock = DockStyle.Top;

            panel.DoubleClick += OpenAccountDetails;

            this.Controls.Add(panel);

            Label labelAcc = new Label();
            labelAcc.Name = account; // labelAcc+account.id
            labelAcc.Text = account; // account.accountname
            labelAcc.Dock = DockStyle.Left;
            labelAcc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            labelAcc.Font = ANHColorsFonts.Font_header2;

            Label labelVal = new Label();
            labelVal.Name = account; // labelVal+account.id
            labelVal.Text = account; // account.balance
            labelVal.Dock = DockStyle.Left;
            labelVal.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            labelVal.Font = ANHColorsFonts.Font_header2;

            panel.Controls.Add(labelAcc);
            panel.Controls.Add(labelVal);
        }

        private List<string> GetAccounts(int id)
        {
            List<string> accounts = new List<string>();

            //
            // code goes here (list type is string for now)
            // order by asc balance
            //

            return accounts;
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