using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fii.Data;

namespace Fii.Business
{
    public class ProductsRepository : IRepository<Products>
    {
        private readonly ProductsContext _context;

        public ProductsRepository(ProductsContext context)
        {
            _context = context;
        }

        public void Create(Products products)
        {
            if (products != null)
            {
                _context.Products.Add(products);
                _context.SaveChanges();
            }
        }

        public Products GetById(Guid id)
        {
            return _context.Products.Find(id);
        }

        public IReadOnlyList<Products> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
