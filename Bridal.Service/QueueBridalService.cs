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

        public async Task<QueueBridal> AddQueueBridalAsync(QueueBridal queueBridal)
        {
            return await _queueBridalRepository.AddQueueBridalAsync(queueBridal);
        }

        public async Task DeleteQueueBridalAsync(int id)
        {
            await _queueBridalRepository.DeleteQueueBridalAsync(id);
        }

        public QueueBridal GetById(int id)
        {
            return _queueBridalRepository.GetById(id);
        }

        public IEnumerable<QueueBridal> GetQueueBridal()
        {
            return _queueBridalRepository.GetQueueBridal();
        }

        public async Task<QueueBridal> UpdateQueueBridalAsync(int id, BridalClass bridal)
        {
            return await _queueBridalRepository.UpdateQueueBridalAsync(id, bridal);
        }

        public async Task<QueueBridal> UpdateQueueBridalAsync(int id, DateTime value)
        {
            return await _queueBridalRepository.UpdateQueueBridalAsync(id, value);
        }
    }
}
