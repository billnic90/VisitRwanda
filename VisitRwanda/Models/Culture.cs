namespace VisitRwanda.Models
{
    public class Culture
    {
        public int CultureID { get; set; }  // culture id         
        public required string Title { get; set; }   // culture title        
        public required string Description { get; set; }   //   culture description
        public required string Image { get; set; }//image URL
    }
}
