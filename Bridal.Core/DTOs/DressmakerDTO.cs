using Bridal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.DTOs
{
    public class DressmakerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int status { get; set; }
        public Experience experience { get; set; }
    }
}
