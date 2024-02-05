﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Entities
{
    public class BridalClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateWedding { get; set; }
        public Dressmaker Dressmaker { get; set; }
        //public int MyProperty { get; set; }
        public List<QueueBridal> Queues { get; set; }

    }
}
