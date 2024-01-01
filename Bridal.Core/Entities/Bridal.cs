namespace Bridal.Core.Entities
{
    public class Bridal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateWedding { get; set; }
        public Dressmaker dressmaker { get; set; }
    }
}
