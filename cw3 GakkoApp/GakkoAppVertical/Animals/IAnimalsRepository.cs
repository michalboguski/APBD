namespace GakkoAppVertical.Animals;

public interface IAnimalsRepository
{
    IEnumerable<Animal> GetAnimals();
    Animal GetAnimal(int idAnimal);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(int idAnimal);
    int DeleteAnimal(int idAnimal);
}