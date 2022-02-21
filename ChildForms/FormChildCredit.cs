using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildCredit : Form
    {
        public FormChildCredit()
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