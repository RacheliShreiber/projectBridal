using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Entities
{
    public enum Experience { beginner=1,middle=2,expert=3 }
    public class Dressmaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int status { get; set; }
        public Experience experience { get; set; }
    }
}
