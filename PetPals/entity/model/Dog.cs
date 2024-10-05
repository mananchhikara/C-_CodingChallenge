namespace PetPals.entity.model
{
    public class Dog : Pet
    {
        public string DogBreed { get; set; }

        public Dog(string name, int age, string breed, string dogBreed, int petid,int shelterid) : base(name, age, breed, petid,shelterid)
        {
            DogBreed = dogBreed;
        }
    }
}
