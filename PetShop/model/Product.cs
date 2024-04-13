using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop.model
{
    public class Product
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public string Detail { get; set; }
    }
}