using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fii.Data;

namespace WebApiDesign.Models
{
    public class CreateModelShoppingCart
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public List<Products> Products { get; set; }
    }
}
