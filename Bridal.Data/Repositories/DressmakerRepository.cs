using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Data.Repositories
{
    public class DressmakerRepository : IDressmakerRepository
    {
        private readonly DataContext _context;
        public DressmakerRepository(DataContext context)
        {
            _context = context;
        }

        public Dressmaker AddDressmaker(Dressmaker dressmaker)
        {
            _context.DressmakerList.Add(dressmaker);
            _context.SaveChanges();
            return dressmaker;
        }

        public Dressmaker GetById(int id)
        {
            return _context.DressmakerList.Find(id);
        }

        public List<Dressmaker> GetDressmaker()
        {
            return _context.DressmakerList.ToList();
        }

        public Dressmaker UpdateDressmaker(int id, Dressmaker dressmaker)
        {
            var updateDressmaker = _context.DressmakerList.Find(id);
            if (updateDressmaker != null)
                updateDressmaker.Name = dressmaker.Name;
            _context.SaveChanges();
            return updateDressmaker;
        }

        public Dressmaker UpdateDressmaker(int id, Experience value)
        {
            var updateDressmaker = _context.DressmakerList.Find(id);
            if (updateDressmaker != null)
                updateDressmaker.experience = value;
            _context.SaveChanges();
            return updateDressmaker;
        }

        public Dressmaker UpdateDressmaker(int id, int status)
        {
            var updateDressmaker = _context.DressmakerList.Find(id);
            if (updateDressmaker != null)
                updateDressmaker.status = status;

            return updateDressmaker;
        }
    }
}
