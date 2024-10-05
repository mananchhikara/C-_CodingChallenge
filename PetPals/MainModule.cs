using System;
using PetPals.dao;
using PetPals.entity.model;
using PetPals.exception;

namespace PetPals
{
    public class MainModule
    {
        public static void Main(string[] args)
        {
            PetDAOImpl petDAO = new PetDAOImpl();
            PetShelter shelter = new PetShelter();

            while (true)
            {
                Console.WriteLine("1. Add Pet");
                Console.WriteLine("2. Remove Pet");
                Console.WriteLine("3. List Available Pets");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        try
                        {
                            Console.Write("Enter Pet Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Pet Age: ");
                            int age = int.Parse(Console.ReadLine());
                            if (age <= 0)
                                throw new InvalidPetAgeException("Age must be a positive integer.");
                            Console.Write("Enter Pet Breed: ");
                            string breed = Console.ReadLine();
                            Console.Write("Enter Pet ID: ");
                            int petid = int.Parse(Console.ReadLine());
                            Console.Write("Enter Shelter ID: ");
                            int shelterid = int.Parse(Console.ReadLine());

                            Pet pet = new Pet(name, age, breed,petid,shelterid);
                            shelter.AddPet(pet);
                            petDAO.AddPet(pet);
                            
                            Console.WriteLine("Pet added successfully.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number for age.");
                        }
                        catch (InvalidPetAgeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    //case "2":
                    //    Console.Write("Enter Pet ID to Remove: ");
                    //    int petId = int.Parse(Console.ReadLine());
                    //    petDAO.RemovePet(petId);
                    //    Console.WriteLine("Pet removed successfully.");
                    //    break;

                    //case "3":
                    //    shelter.ListAvailablePets();
                    //    petDAO.ListAvailablePets();
                    //    break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
