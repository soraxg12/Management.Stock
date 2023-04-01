using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Socket.Domain.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        [Required]
        public int Amount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
