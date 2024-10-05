using System.Collections.Generic;

namespace PetPals.entity.model
{
    public class PetShelter
    {
        public List<Pet> AvailablePets { get; set; } = new List<Pet>();

        public void AddPet(Pet pet)
        {
            AvailablePets.Add(pet);
        }

        public void RemovePet(Pet pet)
        {
            AvailablePets.Remove(pet);
        }

        public void ListAvailablePets()
        {
            foreach (var pet in AvailablePets)
            {
                System.Console.WriteLine(pet);
            }
        }
    }
}
