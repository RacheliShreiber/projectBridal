using Bridal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Repositories
{
    public interface IBridalRepository
    {
        Task<IEnumerable<BridalClass>> GetBridalAsync();
        Task<BridalClass> GetByIdAsync(int id);
        Task<BridalClass> AddBridalAsync(BridalClass bridal);
        Task<BridalClass> UpdateBridalAsync(int id, BridalClass bridal);
        Task<BridalClass> UpdateBridalAsync(int id,DateTime value);
        Task DeleteBridalAsync(int id);       
    }
}
