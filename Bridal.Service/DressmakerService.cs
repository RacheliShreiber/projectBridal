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

        public Dressmaker AddDressmaker(Dressmaker dressmaker)
        {
            return _dressmakerRepository.AddDressmaker(dressmaker); 
        }

        public Dressmaker GetById(int id)
        {
            return _dressmakerRepository.GetById(id);
        }

        public List<Dressmaker> GetDressmaker()
        {
            return _dressmakerRepository.GetDressmaker();
        }

        public Dressmaker UpdateDressmaker(int id, Dressmaker dressmaker)
        {
            return _dressmakerRepository.UpdateDressmaker(id, dressmaker);
        }

        public Dressmaker UpdateDressmaker(int id, Experience value)
        {
            return _dressmakerRepository.UpdateDressmaker(id, value);
        }

        public Dressmaker UpdateDressmaker(int id, int status)
        {
            return _dressmakerRepository.UpdateDressmaker(id,status);   
        }
    }
}
