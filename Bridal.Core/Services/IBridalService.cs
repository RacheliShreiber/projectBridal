using Bridal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Services
{
    public interface IBridalService
    {
        IEnumerable<BridalClass> GetBridal();

        BridalClass GetById(int id);

        Task<BridalClass> AddBridalAsync(BridalClass bridal);

        Task<BridalClass> UpdateBridalAsync(int id, BridalClass bridal);
        Task<BridalClass> UpdateBridalAsync(int id, DateTime value);
        //BridalClass UpdateBridal(int id, Dressmaker value);

        Task DeleteBridalAsync(int id);

    }
}
