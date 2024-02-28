using Bridal.Core.Entities;

namespace BridalSalon.Models
{
    public class QueuePostModel
    {
        public BridalClass Bridal { get; set; }
        public Dressmaker Dressmaker { get; set; }
        public DateTime DateQueue { get; set; }
    }
}
