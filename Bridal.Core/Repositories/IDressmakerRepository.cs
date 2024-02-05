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
        List<Dressmaker> GetDressmaker();

        Dressmaker GetById(int id);

        Dressmaker AddDressmaker(Dressmaker dressmaker);

        Dressmaker UpdateDressmaker(int id, Dressmaker dressmaker);
        Dressmaker UpdateDressmaker(int id, Experience value);
        Dressmaker UpdateDressmaker(int id, int status);


    }
}
