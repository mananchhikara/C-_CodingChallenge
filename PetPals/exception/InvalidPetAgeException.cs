using System;

namespace PetPals.exception
{
    public class InvalidPetAgeException : Exception
    {public InvalidPetAgeException(string message) : base(message) { }
    }
}
