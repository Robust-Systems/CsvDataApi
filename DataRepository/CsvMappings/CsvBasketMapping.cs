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
      
      // map the column in the same order as it is in the CSV file

      int colNumber = 0;

      MapProperty(colNumber++, x => x.TransactionNumber);

      MapProperty(colNumber++, x => x.NumberOfPassengers);

      MapProperty(colNumber++, x => x.Domain);

      MapProperty(colNumber++, x => x.AgentId);

      MapProperty(colNumber++, x => x.ReferrerUrl);

      MapProperty(colNumber++, x => x.CreatedDateTime);

      MapProperty(colNumber++, x => x.UserId);

      MapProperty(colNumber++, x => x.SelectedCurrency);

      MapProperty(colNumber++, x => x.ReservationSystem);

    }
  }
}
