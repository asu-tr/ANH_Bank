using System.Windows.Forms;

namespace ANH_Bank
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