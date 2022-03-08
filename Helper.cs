using ANH_Bank.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace ANH_Bank
{
    public class Helper
    {
        #region Database - Connection

        public static void CreateDatabase(Context context)
        {
            if (context.Database.Exists())
                return;

            context.Database.Create();

            context.Currencies.Add(new Models.Currency { Name = "TRY" });
            context.Currencies.Add(new Models.Currency { Name = "USD" });
            context.Currencies.Add(new Models.Currency { Name = "EUR" });
            context.Currencies.Add(new Models.Currency { Name = "GBP" });

            context.PaymentTypes.Add(new Models.PaymentType { Description = "Card Purchases" });
            context.PaymentTypes.Add(new Models.PaymentType { Description = "Taxes" });
            context.PaymentTypes.Add(new Models.PaymentType { Description = "Bills" });

            SecurityQuestion sq = new SecurityQuestion { Question = "fav_color" };
            context.SecurityQuestions.Add(sq);
            SecurityQuestionTranslation sqt = new SecurityQuestionTranslation { Language = "en", SecurityQuestion = sq, IsDefault = true, Translation = "What is your favourite color?" };
            context.SecurityQuestionTranslations.Add(sqt);
            sqt = new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = sq, IsDefault = false, Translation = "En sevdiğiniz renk?" };
            context.SecurityQuestionTranslations.Add(sqt);

            sq = new SecurityQuestion { Question = "pet_name" };
            context.SecurityQuestions.Add(sq);
            sqt = new SecurityQuestionTranslation { Language = "en", SecurityQuestion = sq, IsDefault = true, Translation = "What is your pet's name?" };
            context.SecurityQuestionTranslations.Add(sqt);
            sqt = new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = sq, IsDefault = false, Translation = "Evcil hayvanınızın adı?" };
            context.SecurityQuestionTranslations.Add(sqt);

            sq = new SecurityQuestion { Question = "bff_name" };
            context.SecurityQuestions.Add(sq);
            sqt = new SecurityQuestionTranslation { Language = "en", SecurityQuestion = sq, IsDefault = true, Translation = "What is your BFF's name?" };
            context.SecurityQuestionTranslations.Add(sqt);
            sqt = new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = sq, IsDefault = false, Translation = "En sevdiğiniz arkadaşınızın adı?" };
            context.SecurityQuestionTranslations.Add(sqt);

            // ADD MESSAGE / TRANSLATIONS

            //user_create_success
            //user_create_success_title
            // first_password

            context.SaveChanges();
        }

        Configuration config;

        public Helper()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        SqlConnection conn;
        public Helper(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }

        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }

        #endregion

        #region Banking Stuff

        public static Account CreateAccount(User user, int currencyId)
        {
            Context context = new Context();

            Account acc = new Account();

            acc.Currency = context.Currencies.Where(c => c.Id == currencyId).First();
            acc.Balance = 0;
            acc.Overdraft = 0;
            acc.InUse = true;
            acc.User = user;

            context.Accounts.Add(acc);

            return acc;
        }

        public static Account CreateAccount(User user, int currencyId, string accountName)
        {
            Context context = new Context();

            Account acc = new Account();

            acc.Name = accountName;
            acc.Currency = context.Currencies.Where(c => c.Id == currencyId).First();
            acc.Balance = 0;
            acc.Overdraft = 0;
            acc.InUse = true;
            acc.User = user;

            context.Accounts.Add(acc);

            return (acc);
        }

        #endregion

        #region Language

        public static string GetMessage(string messageName, string lang)
        {
            Context context = new Context();

            Message msg = context.Messages.Where(m => m.Name == messageName).First();
            string translated = context.MessageTranslations.Where(t => t.Message == msg && t.Language == lang).First().Translation;

            if (translated == null)
            {
                translated = context.MessageTranslations.Where(t => t.Message == msg && t.IsDefault == true).First().Translation;
            }

            return translated;
        }

        #endregion
    }
}