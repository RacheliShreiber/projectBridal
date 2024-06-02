using Bridal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Data
{
    public class DataContext:DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<BridalClass> BridalList { get; set; }
        public DbSet<Dressmaker> DressmakerList { get; set; }
        public DbSet<QueueBridal> QueueBridalList { get; set; }

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["DbConnection"]);
        }
    }
}
