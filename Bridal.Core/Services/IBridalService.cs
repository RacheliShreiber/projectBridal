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
        Task<IEnumerable<BridalClass>> GetBridalAsync();
        Task<BridalClass> GetByIdAsync(int id);
        Task<BridalClass> AddBridalAsync(BridalClass bridal);
        Task<BridalClass> UpdateBridalAsync(int id, BridalClass bridal);
        Task<BridalClass> UpdateBridalAsync(int id, DateTime value);
        Task DeleteBridalAsync(int id);
    }
}
