using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
  public interface IBasketDataService
  {
    List<Basket> GetBaskets();

    List<Basket> GetBaskets(int domain);

    Basket GetBasket(string transactionNumber);
  }
}
