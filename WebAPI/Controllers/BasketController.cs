using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        IBasketService _basketService;
        IBasketDal _basketDal;

        public BasketController(IBasketService basketService, IBasketDal basketDal)
        {
            _basketService = basketService;
            _basketDal = basketDal;
        }

        [HttpGet]
        public IActionResult GetBasketById(string id)
        {
            var basket = _basketService.GetBasket(id);
            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public IActionResult UpdateBasket(CustomerBasket customerBasket)
        {
            var updatedBasket = _basketService.UpdateBasket(customerBasket);
            return Ok(updatedBasket);
        }

        //[HttpDelete]
        //public IActionResult DeleteBasket(string id)
        //{
        //    return _basketService.DeleteBasket(id);
        //}

    }
}
