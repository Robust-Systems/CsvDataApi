using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using DataRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BasketsController : ControllerBase
  {
    readonly IBasketDataService _basketDataService;

    public BasketsController(IBasketDataService basketDataService)
    {
      _basketDataService = basketDataService;
    }

    // GET api/<BasketsController>/0002b3be-4f0b-418a-b7dd-670494981a89
    [HttpGet("{transactionNumber}")]
    public Basket Get(string transactionNumber)
    {
      return _basketDataService.GetBasket(transactionNumber);
    }

    // GET api/<BasketsController>/10
    [HttpGet("{domain:int?}")]
    public IEnumerable<Basket> Get(int? domain = null)
    {
      if (domain.HasValue)
      {
        return _basketDataService.GetBaskets(domain.Value);
      }
      else
      {
        return _basketDataService.GetBaskets();
      }
    }
  }
}
