using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Data.Repositories
{
    public class QueueBridalRepository:IQueueBridalRepository
    {
        private readonly DataContext _context;

        public QueueBridalRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<QueueBridal> AddQueueBridalAsync(QueueBridal queueBridal)
        {
            _context.QueueBridalList.Add(queueBridal);
            await _context.SaveChangesAsync();
            return queueBridal;
        }

        public async Task DeleteQueueBridalAsync(int id)
        {
            _context.QueueBridalList.Remove(GetById(id));
            await _context.SaveChangesAsync();
        }

        public QueueBridal GetById(int id)
        {
            return _context.QueueBridalList.Find(id);
        }

        public IEnumerable<QueueBridal> GetQueueBridal()
        {
            return _context.QueueBridalList.Include(q=>q.Bridal);
        }

        public async Task<QueueBridal> UpdateQueueBridalAsync(int id, BridalClass bridal)
        {
            var queueBridal = _context.QueueBridalList.Find(id);
            if (queueBridal != null)
                queueBridal.Bridal = bridal;
            await _context.SaveChangesAsync();
            return queueBridal;
        }

        public async Task<QueueBridal> UpdateQueueBridalAsync(int id, DateTime value)
        {
            var queueBridal = _context.QueueBridalList.Find(id);
            if (queueBridal != null)
                queueBridal.DateQueue = value;
            await _context.SaveChangesAsync();
            return queueBridal;
        }
    }
}
