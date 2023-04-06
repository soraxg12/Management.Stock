using Management.Socket.Domain.Entities;
using Management.Socket.Domain.Interfaces;
using Management.Stock.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Stock.Infra.Data.Repository
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ManagementContext managementContext) : base(managementContext)
        {
        }
    }
}
