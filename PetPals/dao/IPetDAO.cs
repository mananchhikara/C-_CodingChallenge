namespace PetPals.dao
{
    public interface IPetDAO
    {
        void AddPet(PetPals.entity.model.Pet pet);
        void RemovePet(int petId);
        void ListAvailablePets();
    }
}
