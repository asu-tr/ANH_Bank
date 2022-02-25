namespace ANH_Bank.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Currency Currency { get; set; }
        public decimal Limit { get; set; }
        public string CardNo { get; set; }
        public string ExpirationDate { get; set; }
        public bool InUse { get; set; }
    }
}