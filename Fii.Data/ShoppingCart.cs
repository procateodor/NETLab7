using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fii.Data
{
    public class ShoppingCart
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        public DateTime Date { get; private set; }

        [Required]
        public string Description { get; private set; }

        [NotMapped]
        public double Total { get; private set; }

        [NotMapped]
        private List<Products> Products = new List<Products>();

        private ShoppingCart()
        {

        }

        public ShoppingCart(DateTime data, string descripion, List<Products> products)
        {
            Id = Guid.NewGuid();
            Date = data;
            Description = descripion;
            Products = products;

            foreach(Products prop in Products)
            {
                Total += prop.Price;
            }
        }

        public void update(DateTime date, string description, List<Products> list)
        {
            Date = date;
            Description = description;
            Products = list;

            foreach (Products prop in Products)
            {
                Total += prop.Price;
            }
        }
    }
}
