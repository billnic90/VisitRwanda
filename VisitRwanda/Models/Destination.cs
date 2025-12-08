namespace VisitRwanda.Models
{
    public class Destination
    {
       
        public int DestinationID { get; set; } // destination id
        public required string Name { get; set; }             // name of the destination
        public required string Description { get; set; }      // description of the destination
        public required string Location { get; set; }         // location of the destination
        public required string Image { get; set; }            // image URL

    }
}
