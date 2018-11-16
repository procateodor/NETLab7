using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fii.Data;

namespace Fii.Business
{
    public class ShoppingCartRepository : IRepository<ShoppingCart>
    {
        private readonly ShoppingCartContext _context;

        public ShoppingCartRepository(ShoppingCartContext context)
        {
            _context = context;
        }

        public void Create(ShoppingCart cart)
        {
            if (cart != null)
            {
                _context.ShoppingCarts.Add(cart);
                _context.SaveChanges();
            }
        }

        public ShoppingCart GetById(Guid id)
        {
            return _context.ShoppingCarts.Find(id);
        }

        public IReadOnlyList<ShoppingCart> GetAll()
        {
            return _context.ShoppingCarts.ToList();
        }

        public void Update(ShoppingCart cart)
        {
            if (cart != null)
            {
                _context.ShoppingCarts.Update(cart);
                _context.SaveChanges();
            }
        }
    }
}
