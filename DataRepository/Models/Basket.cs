using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.Models
{
  // this class represents the data in the 'baskets' CSV file
  public class Basket
  {

    public string TransactionNumber { get; set; }

    public int? NumberOfPassengers { get; set; }

    public int Domain { get; set; }

    public string AgentId { get; set; }

    public string ReferrerUrl { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string UserId { get; set; }

    public string SelectedCurrency { get; set; }

    public string ReservationSystem { get; set; }

  }
}
