using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Fii.Business;
using Fii.Data;
using WebApiDesign.Models;

namespace WebApiDesign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepository<Products> _repository;

        public ProductsController(IRepository<Products> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<Products>> Get()
        {
            return Ok(this._repository.GetAll());
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Products> Get(Guid id)
        {
            return Ok(this._repository.GetById(id));
        }

        [HttpPost]
        public ActionResult<Products> Post([FromBody] CreateProductModel model)
        {
            if (model.Name == null)
            {
                return BadRequest();
            }

            Products prod = new Products(model.Name, model.Price, model.Pieces);
            this._repository.Create(prod);

            return CreatedAtRoute("GetById", new { id = prod.Id }, prod);
        }

        [HttpPut]
        public ActionResult<Products> Put([FromBody]Guid id, CreateProductModel model)
        {
            if (model.Name == null)
            {
                return BadRequest();
            }

            Products prod = this._repository.GetById(id);

            prod.update(model.Name, model.Price, model.Pieces);

            this._repository.Update(prod);

            return CreatedAtRoute("GetById", new { id = prod.Id }, prod);
        }
    }
}