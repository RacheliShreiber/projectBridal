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
        IEnumerable<QueueBridal> GetQueueBridal();

        QueueBridal GetById(int id);

        QueueBridal AddQueueBridal(QueueBridal queueBridal);

        QueueBridal UpdateQueueBridal(int id, BridalClass bridal);
        QueueBridal UpdateQueueBridal(int id, DateTime value);


        void DeleteQueueBridal(int id);
    }
}
