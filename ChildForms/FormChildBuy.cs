using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildBuy : Form
    {
        public FormChildBuy()
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