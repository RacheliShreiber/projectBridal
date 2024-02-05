using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using Bridal.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Service
{
    public class QueueBridalService:IQueueBridalService
    {
        private readonly IQueueBridalRepository _queueBridalRepository;

        public QueueBridalService(IQueueBridalRepository queueBridalRepository)
        {
            _queueBridalRepository = queueBridalRepository;
        }

        public QueueBridal AddQueueBridal(QueueBridal queueBridal)
        {
            return _queueBridalRepository.AddQueueBridal(queueBridal);
        }

        public void DeleteQueueBridal(int id)
        {
            _queueBridalRepository.DeleteQueueBridal(id);
        }

        public QueueBridal GetById(int id)
        {
            return _queueBridalRepository.GetById(id);
        }

        public IEnumerable<QueueBridal> GetQueueBridal()
        {
            return _queueBridalRepository.GetQueueBridal();
        }

        public QueueBridal UpdateQueueBridal(int id, BridalClass bridal)
        {
            return _queueBridalRepository.UpdateQueueBridal(id, bridal);
        }

        public QueueBridal UpdateQueueBridal(int id, DateTime value)
        {
            return _queueBridalRepository.UpdateQueueBridal(id, value);
        }
    }
}
