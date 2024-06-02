using Bridal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Services
{
    public interface IQueueBridalService
    {
        Task<IEnumerable<QueueBridal>> GetQueueBridalAsync();
        Task<QueueBridal> GetByIdAsync(int id);
        Task<QueueBridal> AddQueueBridalAsync(QueueBridal queueBridal);
        Task<QueueBridal> UpdateQueueBridalAsync(int id, BridalClass bridal);
        Task<QueueBridal> UpdateQueueBridalAsync(int id, DateTime value);
        Task DeleteQueueBridalAsync(int id);
    }
}
