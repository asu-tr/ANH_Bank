using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildMain : Form
    {
        public FormChildMain()
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