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

        public async Task<Dressmaker> AddDressmakerAsync(Dressmaker dressmaker)
        {
            _context.DressmakerList.Add(dressmaker);
            await _context.SaveChangesAsync();
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

        public async Task<Dressmaker> UpdateDressmakerAsync(int id, Dressmaker dressmaker)
        {
            var updateDressmaker = _context.DressmakerList.Find(id);
            if (updateDressmaker != null)
                updateDressmaker.Name = dressmaker.Name;
            await _context.SaveChangesAsync();
            return updateDressmaker;
        }

        public async Task<Dressmaker> UpdateDressmakerAsync(int id, Experience value)
        {
            var updateDressmaker = _context.DressmakerList.Find(id);
            if (updateDressmaker != null)
                updateDressmaker.experience = value;
            await _context.SaveChangesAsync();
            return updateDressmaker;
        }

        public async Task<Dressmaker> UpdateDressmakerAsync(int id, int status)
        {
            var updateDressmaker = _context.DressmakerList.Find(id);
            if (updateDressmaker != null)
                updateDressmaker.status = status;
            await _context.SaveChangesAsync();
            return updateDressmaker;
        }
    }
}
