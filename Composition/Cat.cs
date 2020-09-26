using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition
{
    public class Cat : IAnimal
    {
        public Cat()
        {
            Family = new Felidae("Felis catus", 61);
        }

        public IFamily Family { get; }

        public string Sound() => Mew();

        public string Mew()
        {
            return "mew mew";
        }
    }
}