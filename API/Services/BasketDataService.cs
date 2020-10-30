using DataRepository;
using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
  public class BasketDataService : IBasketDataService
  {
    BasketProcessor basketProcessor;

    public BasketDataService()
    {
      basketProcessor = new BasketProcessor();
    }

    public List<Basket> GetBaskets()
    {
      return basketProcessor.Baskets.OrderBy(b => b.CreatedDateTime).ToList();
    }

    public List<Basket> GetBaskets(int domain)
    {
      return basketProcessor.Baskets.Where(b => b.Domain == domain).OrderBy(b => b.CreatedDateTime).ToList();
    }

    public Basket GetBasket(string transactionNumber)
    {
      return basketProcessor.Baskets.FirstOrDefault(b => b.TransactionNumber.Equals(transactionNumber, StringComparison.OrdinalIgnoreCase));
    }
  }
}
