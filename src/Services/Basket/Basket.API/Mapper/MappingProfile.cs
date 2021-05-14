using AutoMapper;
using Basket.API.Entities;
using EventBuss.Messages.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
