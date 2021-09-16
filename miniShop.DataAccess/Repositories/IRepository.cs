using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniShop.DataAccess.Repositories
{
    public interface IRepository<T> where T : IEntity,new()
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<IEnumerable<T>> GetWithLazy();
    }
}
