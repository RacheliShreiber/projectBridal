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

        public QueueBridal AddQueueBridal(QueueBridal queueBridal)
        {
            _context.QueueBridalList.Add(queueBridal);
            _context.SaveChanges();
            return queueBridal;
        }

        public void DeleteQueueBridal(int id)
        {
            _context.QueueBridalList.Remove(GetById(id));
            _context.SaveChanges();
        }

        public QueueBridal GetById(int id)
        {
            return _context.QueueBridalList.Find(id);
        }

        public IEnumerable<QueueBridal> GetQueueBridal()
        {
            return _context.QueueBridalList.Include(q=>q.Bridal);
        }

        public QueueBridal UpdateQueueBridal(int id, BridalClass bridal)
        {
            var queueBridal = _context.QueueBridalList.Find(id);
            if (queueBridal != null)
                queueBridal.Bridal = bridal;
            _context.SaveChanges();
            return queueBridal;
        }

        public QueueBridal UpdateQueueBridal(int id, DateTime value)
        {
            var queueBridal = _context.QueueBridalList.Find(id);
            if (queueBridal != null)
                queueBridal.DateQueue = value;
            _context.SaveChanges();
            return queueBridal;
        }
    }
}
