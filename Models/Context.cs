using System.Data.Entity;

namespace ANH_Bank.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("name=ANH_DB")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<DebitCard> DebitCards { get; set; }
        public DbSet<DW> DWs { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<SecurityQuestionTranslation> SecurityQuestionTranslations { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}