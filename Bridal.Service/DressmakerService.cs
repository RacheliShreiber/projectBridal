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
    public class DressmakerService:IDressmakerService
    {
        private readonly IDressmakerRepository _dressmakerRepository;

        public DressmakerService(IDressmakerRepository dressmakerRepository)
        {
            _dressmakerRepository = dressmakerRepository;
        }

        public async Task<Dressmaker> AddDressmakerAsync(Dressmaker dressmaker)
        {
            return await _dressmakerRepository.AddDressmakerAsync(dressmaker); 
        }

        public Dressmaker GetById(int id)
        {
            return _dressmakerRepository.GetById(id);
        }

        public List<Dressmaker> GetDressmaker()
        {
            return _dressmakerRepository.GetDressmaker();
        }

        public async Task<Dressmaker> UpdateDressmakerAsync(int id, Dressmaker dressmaker)
        {
            return await _dressmakerRepository.UpdateDressmakerAsync(id, dressmaker);
        }

        public async Task<Dressmaker> UpdateDressmakerAsync(int id, Experience value)
        {
            return await _dressmakerRepository.UpdateDressmakerAsync(id, value);
        }

        public async Task<Dressmaker> UpdateDressmakerAsync(int id, int status)
        {
            return await _dressmakerRepository.UpdateDressmakerAsync(id,status);   
        }
    }
}
