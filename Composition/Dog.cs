using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition
{
    public class Dog : IAnimal
    {
        public Dog()
        {
            Family = new Caninae("Canis lupus familiaris", 63);
        }

        public IFamily Family { get; }


        public string Sound() => Woof();

        public string Woof()
        {
            return "woof woof";
        }
    }
}