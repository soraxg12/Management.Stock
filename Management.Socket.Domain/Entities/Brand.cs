﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Socket.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Description { get; set; }
        List<Product> products { get; set; }
    }
}
