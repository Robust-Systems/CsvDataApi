using DataRepository.CsvMappings;
using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TinyCsvParser;

namespace DataRepository
{
  public class BasketProcessor
  {
    const string CSV_FILE_NAME = "baskets.csv";

    public List<Basket> Baskets { get; set; }

    public BasketProcessor()
    {
      PopulateBasketList();
    }

    private void PopulateBasketList()
    {
      CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');

      var csvParser = new CsvParser<Basket>(csvParserOptions, new CsvBasketMapping());

      var csvString = ReadResource(CSV_FILE_NAME);

      CsvReaderOptions csvReaderOptions = new CsvReaderOptions(new[] { "\n" });

      Baskets = csvParser.ReadFromString(csvReaderOptions, csvString)
                         .Select(x => x.Result)
                         .ToList();
    }

    public static string ReadResource(string resourceName)
    {
      // Determine path
      var assembly = Assembly.GetExecutingAssembly();
      string resourcePath;

      // Format: "{Namespace}.{Folder}.{filename}.{Extension}"
      resourcePath = assembly.GetManifestResourceNames()
                             .Single(str => str.EndsWith(resourceName));

      using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
      using (StreamReader reader = new StreamReader(stream))
      {
        return reader.ReadToEnd();
      }
    }

  }
}
