namespace VisitRwanda.Models
{
    public class Investment
    {
        public int InvestmentID { get; set; }      // Investment ID
        public required string Sector { get; set; }         // Sector of investment
        public required string Description { get; set; }      // Description of investment
        public required string Requirements { get; set; }     // Requirements for investment
        public required string Image { get; set; }// Image URL
    }
}
