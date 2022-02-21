using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildDeposit : Form
    {
        public FormChildDeposit()
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