using Microsoft.EntityFrameworkCore;
using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Data.Repositories
{
    public class BridalRepository : IBridalRepository
    {
        private readonly DataContext _context;
        public BridalRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<BridalClass> AddBridalAsync(BridalClass bridal)
        {
            _context.BridalList.Add(bridal);
            await _context.SaveChangesAsync();
            return bridal;
        }
        public async Task DeleteBridalAsync(int id)
        {
            _context.BridalList.Remove(_context.BridalList.Find(id));
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<BridalClass>> GetBridalAsync()
        {
            return await _context.BridalList.ToListAsync();
        }
        public async Task<BridalClass> GetByIdAsync(int id)
        {
            return await _context.BridalList.FindAsync(id);
        }
        public async Task<BridalClass> UpdateBridalAsync(int id, BridalClass bridal)
        {
            var updateBridal = _context.BridalList.Find(id);
            if (updateBridal != null)
            {
                updateBridal.Name = bridal.Name;
                updateBridal.Phone = bridal.Phone;
                updateBridal.DateWedding = bridal.DateWedding;
                await _context.SaveChangesAsync();
                return updateBridal;
            }
            return null;
        }
        public async Task<BridalClass> UpdateBridalAsync(int id, DateTime value)
        {
            var updateBridal = _context.BridalList.Find(id);
            if (updateBridal != null)
            {
                updateBridal.DateWedding = value;
                await _context.SaveChangesAsync();
                return updateBridal;
            } 
            return null;
        }
    }
}
