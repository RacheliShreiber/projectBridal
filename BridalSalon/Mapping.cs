using AutoMapper;
using Bridal.Core.DTOs;
using Bridal.Core.Entities;
using BridalSalon.Models;

namespace BridalSalon
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<BridalPostModel, BridalClass > ().ReverseMap();
            CreateMap<DressmakerPostModel, Dressmaker>().ReverseMap();
            CreateMap<QueuePostModel, QueueBridal>().ReverseMap();
        }
    }
}
