using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using TinyCsvParser.Mapping;

namespace DataRepository.CsvMappings
{
  class CsvBasketMapping : CsvMapping<Basket>
  {
    public CsvBasketMapping() : base()
    {

      MapProperty(0, x => x.TransactionNumber);

      MapProperty(1, x => x.NumberOfPassengers);

      MapProperty(2, x => x.Domain);

      MapProperty(3, x => x.AgentId);

      MapProperty(4, x => x.ReferrerUrl);

      MapProperty(5, x => x.CreatedDateTime);

      MapProperty(6, x => x.UserId);

      MapProperty(7, x => x.SelectedCurrency);

      MapProperty(8, x => x.ReservationSystem);

    }
  }
}
