using AutoMapper;
using miniShop.Models;
using miniShop.Models.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniShop.Business.Mapping
{
   public class RequestMappingProfile : Profile
    {
        public RequestMappingProfile()
        {
            CreateMap<Product, ProductListResponse>().ReverseMap();
        }
    }
}
