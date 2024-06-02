using Bridal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Repositories
{
    public interface IDressmakerRepository
    {
        Task<List<Dressmaker>> GetDressmakerAsync();
        Task<Dressmaker> GetByIdAsync(int id);
        Task<Dressmaker> AddDressmakerAsync(Dressmaker dressmaker);
        Task<Dressmaker> UpdateDressmakerAsync(int id, Dressmaker dressmaker);
        Task<Dressmaker> UpdateDressmakerAsync(int id, Experience value);
        Task<Dressmaker> UpdateDressmakerAsync(int id, int status);
    }
}
