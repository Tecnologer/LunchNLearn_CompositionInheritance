using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition
{
    public class Caninae : IFamily
    {
        public Caninae(string name, int gestation)
        {
            Class = new Mammal(name, gestation);
        }

        public IClass Class { get; }

        public string GetFamilyName()
        {
            return "Caninae";
        }
    }
}