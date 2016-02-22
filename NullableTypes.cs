using System;

public class NullableTypes
{
  public static void Main(string[] args)
  {
      int? TicketsOnSale = null;
      int AvaialableTickets = TicketsOnSale ?? 0;

      Console.WriteLine("Avaialable Tickets are {0}", AvaialableTickets);
      
  }
}

