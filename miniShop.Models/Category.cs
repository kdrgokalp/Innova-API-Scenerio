﻿using System;
using System.Collections.Generic;

#nullable disable

namespace miniShop.Models
{ 
    public partial class Category : IEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
