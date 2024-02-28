using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Entities
{
    public class QueueBridal
    {
        public int Id { get; set; }
        public BridalClass Bridal { get; set; }
        public Dressmaker Dressmaker { get; set; }
        public DateTime DateQueue { get; set; }
    }
}
