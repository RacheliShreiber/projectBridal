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
        public async Task<QueueBridal> GetByIdAsync(int id)
        {
            return await _queueBridalRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<QueueBridal>> GetQueueBridalAsync()
        {
            return await _queueBridalRepository.GetQueueBridalAsync();
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
