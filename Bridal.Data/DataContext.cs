using Bridal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Data
{
    public class DataContext:DbContext
    {
        public DbSet<BridalClass> BridalList { get; set; }
        public DbSet<Dressmaker> DressmakerList { get; set; }
        public DbSet<QueueBridal> QueueBridalList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=bridalSalon_db");
        }

        //public DataContext()
        //{
        //BridalList = new List<BridalClass>();
        //DressmakerList = new List<Dressmaker>();
        //QueueBridalList = new List<QueueBridal>();
        //}
    }
}
