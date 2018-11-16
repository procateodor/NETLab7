using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDesign.Models
{
    public class CreateProductModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Pieces { get; set; }
    }
}
