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
    public class BridalService : IBridalService
    {
        private readonly IBridalRepository _bridalRepository;

        public BridalService(IBridalRepository bridalRepository)
        {
            _bridalRepository = bridalRepository;
        }

        public BridalClass AddBridal(BridalClass bridal)
        {
            return _bridalRepository.AddBridal(bridal);
        }

        public void DeleteBridal(int id)
        {
            _bridalRepository.DeleteBridal(id);
        }

        public IEnumerable<BridalClass> GetBridal()
        {
            return _bridalRepository.GetBridal();
        }

        public BridalClass GetById(int id)
        {
            return _bridalRepository.GetById(id);
        }

        public BridalClass UpdateBridal(int id, BridalClass bridal)
        {
            return _bridalRepository.UpdateBridal(id, bridal);
        }

        public BridalClass UpdateBridal(int id, DateTime value)
        {
            return _bridalRepository.UpdateBridal(id, value);
        }

        public BridalClass UpdateBridal(int id, Dressmaker value)
        {
            return _bridalRepository.UpdateBridal(id, value);
        }
    }
}
