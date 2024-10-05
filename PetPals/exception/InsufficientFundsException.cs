using System;

namespace PetPals.exception
{
  public class InsufficientFundsException : Exception
 { public InsufficientFundsException(string message) : base(message) { }
    }
}
