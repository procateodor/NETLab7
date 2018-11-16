using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fii.Data
{
    public class Products
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        [StringLength(100)]
        public string Name { get; private set; }

        [Required]
        public double Price { get; private set; }

        [Required]
        public int Pieces { get; private set; }

        [NotMapped]
        public double Total { get; private set; }

        private Products()
        {

        }

        public Products(string name, double price, int pieces)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Pieces = pieces;
            Total = Price * Pieces;
        }
    }
}
