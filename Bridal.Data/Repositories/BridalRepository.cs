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

        public IEnumerable<BridalClass> GetBridal()
        {
            //var a= _context.BridalList.Include(b => b.Queues);
            return _context.BridalList;
            //return a.Include(b => b.Dressmaker);
        }

        public BridalClass GetById(int id)
        {
            return _context.BridalList.Find(id);
        }

        public async Task<BridalClass> UpdateBridalAsync(int id, BridalClass bridal)
        {
            var updateBridal = _context.BridalList.Find(id);
            if (updateBridal != null)
            {
                updateBridal.Name = bridal.Name;
                updateBridal.Phone = bridal.Phone;
                //updateBridal.Dressmaker=bridal.Dressmaker;
                updateBridal.DateWedding = bridal.DateWedding;
                return updateBridal;
            }
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<BridalClass> UpdateBridalAsync(int id, DateTime value)
        {
            var updateBridal = _context.BridalList.Find(id);
            if (updateBridal != null)
            {
                updateBridal.DateWedding = value;
                return updateBridal;
            }
            await _context.SaveChangesAsync();
            return null;
        }

        //public BridalClass UpdateBridal(int id, Dressmaker value)
        //{
        //    var updateBridal = _context.BridalList.Find(id);
        //    if (updateBridal != null)
        //    {
        //        updateBridal.Dressmaker = value;
        //        return updateBridal;
        //    }
        //    _context.SaveChanges();
        //    return null;
        //}
    }
}
