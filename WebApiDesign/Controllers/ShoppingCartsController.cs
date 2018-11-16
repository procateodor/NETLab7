using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fii.Business;
using Fii.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDesign.Controllers
{
    public class ShoppingCartsController : Controller
    {
        private readonly IRepository<ShoppingCart> _repository;

        public ShoppingCartsController(IRepository<ShoppingCart> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<ShoppingCart>> Get()
        {
            return Ok(this._repository.GetAll());
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<ShoppingCart> Get(Guid id)
        {
            return Ok(this._repository.GetById(id));
        }

        [HttpPost]
        public ActionResult<ShoppingCart> Post([FromBody]  DateTime data, string descripion, List<Products> products)
        {
            if (data == null || descripion == null || products == null)
            {
                return BadRequest();
            }

            ShoppingCart cart = new ShoppingCart(data, descripion, products);
            this._repository.Create(cart);

            return CreatedAtRoute("GetById", new { id = cart.Id }, cart);
        }

        [HttpPut]
        public ActionResult<ShoppingCart> Put([FromBody] Guid id,  DateTime data, string descripion, List<Products> products)
        {
            if (data == null || descripion == null || products == null)
            {
                return BadRequest();
            }

            ShoppingCart cart = new ShoppingCart(data, descripion, products);
            this._repository.Create(cart);

            return CreatedAtRoute("GetById", new { id = cart.Id }, cart);
        }
    }
}