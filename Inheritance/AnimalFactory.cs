using CompositionVsInheritance.Models;

namespace CompositionVsInheritance.Inheritance
{
    public static class AnimalFactory
    {
        public static Animal NewAnimal(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Dog:
                    return new Dog();
                case AnimalType.Cat:
                    return new Cat();
                default:
                    throw new System.Exception("Invalid animal type");
            }
        }
    }
}