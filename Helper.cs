using ANH_Bank.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace ANH_Bank
{
    public class Helper
    {
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

            context.SecurityQuestions.Add(new SecurityQuestion { Question = "fav_color" });
            context.SecurityQuestions.Add(new SecurityQuestion { Question = "pet_name" });
            context.SecurityQuestions.Add(new SecurityQuestion { Question = "bff_name" });

            // question translations

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
        
    }
}