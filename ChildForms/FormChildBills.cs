using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildBills : Form
    {
        public FormChildBills()
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