using Management.Socket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Stock.Web.Models
{
    public class ProductViewModel
    {
        public IList<Product> products { get; set; }
    }
}
