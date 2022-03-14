using ANH_Bank.Currency;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildRates : Form
    {
        public FormChildRates()
        {
            RefreshForm();
        }

        #region Events

        private void FormChildRates_Load(object sender, System.EventArgs e)
        {
            var converter = new Converter(Helper.GetCurrencyAPIKey());

            double usdtry = converter.Convert(1, CurrencyType.USD, CurrencyType.TRY);
            labelUSDVal.Text = usdtry.ToString();

            double eurtry = converter.Convert(1, CurrencyType.EUR, CurrencyType.TRY);
            labelEURVal.Text = eurtry.ToString();

            double gbptry = converter.Convert(1, CurrencyType.GBP, CurrencyType.TRY);
            labelGBPVal.Text = gbptry.ToString();
        }

        #endregion

        #region Methods

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        #endregion
    }
}