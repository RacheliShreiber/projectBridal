using AutoMapper;
using Bridal.Core.DTOs;
using Bridal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BridalClass,BridalDTO>().ReverseMap();
            CreateMap<Dressmaker,DressmakerDTO>().ReverseMap();
            CreateMap<QueueBridal,QueueDTO>().ReverseMap();
        }
    }
}
