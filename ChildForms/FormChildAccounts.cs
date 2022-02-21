using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormChildAccounts : Form
    {
        public FormChildAccounts()
        {
            RefreshForm();
        }

        #region Methods

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        #endregion
    }
}