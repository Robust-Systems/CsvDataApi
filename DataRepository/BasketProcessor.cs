using DataRepository.CsvMappings;
using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyCsvParser;

namespace DataRepository
{
  public class BasketProcessor
  {
    public List<Basket> Baskets { get; set; }

    public BasketProcessor()
    {
      CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
      
      var csvParser = new CsvParser<Basket>(csvParserOptions, new CsvBasketMapping());
      
      Baskets = csvParser.ReadFromFile("import.txt", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
    }
  }
}
