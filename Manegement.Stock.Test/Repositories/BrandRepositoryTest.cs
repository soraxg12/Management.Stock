using Management.Socket.Domain.Entities;
using Management.Stock.Infra.Data.Context;
using Management.Stock.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Manegement.Stock.Test.Repositories
{
    public class BrandRepositoryTest
    {
        private readonly BrandRepository _brandRepository;
        private readonly ManagementContext _managementContext;
        public BrandRepositoryTest()
        {
            _managementContext = new ManagementContext();
            _brandRepository = new BrandRepository(_managementContext);
        }
        
        [Fact]
        public void BrandRepositoryTestInsert()
        {
            var brand = new Brand() { Description = "brandTest"};
            var category = new Category() { Description = "test"};

            _managementContext.Categories.Add(category);
            _managementContext.SaveChanges();

             _brandRepository.Insert(brand);

            Assert.Equal(1, 1);
        }
    }
}
