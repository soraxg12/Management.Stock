using Management.Socket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Stock.Web.Models
{
    public class BrandViewModel
    {
        public IList<Brand> brands { get; set; }
    }
}
