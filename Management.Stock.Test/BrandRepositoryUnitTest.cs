using Management.Socket.Domain.Entities;
using Management.Stock.Infra.Data.Context;
using Management.Stock.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Management.Stock.Test
{
    public class BrandRepositoryUnitTest
    {
        [Fact]
        private void TestRepositoryInsertTest1()
        {
            BaseRepository<Brand> baseRepository = new BaseRepository<Brand>(new ManagementContext());
            baseRepository.Insert(new Brand() { Description = "Felipe"});
        }
    }
}
