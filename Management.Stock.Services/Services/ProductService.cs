using Management.Socket.Domain.Entities;
using Management.Socket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Stock.Services.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IBaseRepository<Product> baseRepository) : base(baseRepository)
        {
        }
    }
}
