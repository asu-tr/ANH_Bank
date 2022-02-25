namespace ANH_Bank.Models
{
    public class DebitCard
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Account Account { get; set; }
        public Currency Currency { get; set; }
        public string CardNo { get; set; }
        public string ExpirationDate { get; set; }
        public bool InUse { get; set; }
    }
}