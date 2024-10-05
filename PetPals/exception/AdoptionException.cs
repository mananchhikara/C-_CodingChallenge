using System;

namespace PetPals.exception
{
public class AdoptionException : Exception{
        public AdoptionException(string message) : base(message) { }
}
}
