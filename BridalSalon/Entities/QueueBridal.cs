namespace BridalSalon.Entities
{
    public class QueueBridal
    {
        public int Id { get; set; }
        public Bridal bridal { get; set; }
        public DateTime DateQueue { get; set; }
    }
}
