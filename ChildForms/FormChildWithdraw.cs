using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildWithdraw : Form
    {
        public FormChildWithdraw()
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