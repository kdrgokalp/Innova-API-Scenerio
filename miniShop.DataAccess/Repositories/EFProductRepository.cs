using Microsoft.EntityFrameworkCore;
using miniShop.EFCore.Data;
using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniShop.DataAccess.Repositories
{
    public class EFProductRepository : IRepository<Product>
    {
        private InnovaDbContext innovaDbContext;

        public EFProductRepository(InnovaDbContext innovaDbContext)
        {
            this.innovaDbContext = innovaDbContext;
        }
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await innovaDbContext.Products.Include(p=>p.Category).ToListAsync();

        }

        public async Task<IEnumerable<Product>> GetWithLazy()
        {
            return await innovaDbContext.Products.ToListAsync();
        }
    }
}
