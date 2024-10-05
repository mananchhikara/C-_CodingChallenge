namespace PetPals.entity.model
{
    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public int Petid { get; set; }

        public int Shelterid { get; set; }
        public Pet(string name, int age, string breed,int petid, int shelterid)
        {
            Name = name;
            Age = age;
            Breed = breed;
            Petid = petid;
            Shelterid = shelterid;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Breed: {Breed}";
        }
    }
}

