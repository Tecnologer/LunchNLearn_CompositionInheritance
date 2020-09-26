using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition
{
    public class Duck : IAnimal
    {
        public Duck()
        {
            Family = new Anatidae("Anas platyrhynchos domesticus", 28);
        }

        public IFamily Family { get; }

        public string Sound() => Quak();

        public string Quak()
        {
            return "quak quak";
        }
    }
}