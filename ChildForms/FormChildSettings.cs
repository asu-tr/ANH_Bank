using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildSettings : Form
    {
        public FormChildSettings()
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