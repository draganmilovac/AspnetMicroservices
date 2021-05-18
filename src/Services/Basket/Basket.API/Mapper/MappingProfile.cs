﻿using AutoMapper;
using Basket.API.Entities;
using EventBuss.Messages.Events;

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
