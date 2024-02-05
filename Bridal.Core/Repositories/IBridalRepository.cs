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
        IEnumerable<BridalClass> GetBridal();

        BridalClass GetById(int id);

        BridalClass AddBridal(BridalClass bridal);

        BridalClass UpdateBridal(int id, BridalClass bridal);
        BridalClass UpdateBridal(int id,DateTime value);
        BridalClass UpdateBridal(int id,Dressmaker value);

        void DeleteBridal(int id);

        
    }
}
