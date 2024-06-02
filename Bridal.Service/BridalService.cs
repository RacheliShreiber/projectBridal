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
        public async Task<BridalClass> AddBridalAsync(BridalClass bridal)
        {
            return await _bridalRepository.AddBridalAsync(bridal);
        }
        public async Task DeleteBridalAsync(int id)
        {
            await _bridalRepository.DeleteBridalAsync(id);
        }
        public async Task<IEnumerable<BridalClass>> GetBridalAsync()
        {
            return await _bridalRepository.GetBridalAsync();
        }
        public async Task<BridalClass> GetByIdAsync(int id)
        {
            return await _bridalRepository.GetByIdAsync(id);
        }
        public async Task<BridalClass> UpdateBridalAsync(int id, BridalClass bridal)
        {
            return await _bridalRepository.UpdateBridalAsync(id, bridal);
        }
        public async Task<BridalClass> UpdateBridalAsync(int id, DateTime value)
        {
            return await _bridalRepository.UpdateBridalAsync(id, value);
        }
    }
}
