using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildSell : Form
    {
        public FormChildSell()
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