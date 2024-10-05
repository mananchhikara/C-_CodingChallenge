namespace PetPals.entity.model
{
    public class Cat : Pet
    {
        public string CatColor { get; set; }

        public Cat(string name, int age, string breed, string catColor,int petid, int shelterid) : base(name, age, breed, petid,shelterid)
        {
            CatColor = catColor;
        }
    }
}
