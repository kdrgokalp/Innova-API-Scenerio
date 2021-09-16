using Microsoft.Extensions.DependencyInjection;
using miniShop.Business.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniShop.Business.Extensions
{
  public static  class MappingRegister
    {
        public static IServiceCollection AddMapperConfiguration(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(RequestMappingProfile));
        }
    }
}
