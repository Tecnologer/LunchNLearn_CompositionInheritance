using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition
{
    public class Felidae : IFamily
    {
        public Felidae(string name, int gestation)
        {
            Class = new Mammal(name, gestation);
        }

        public IClass Class { get; }

        public string GetFamilyName()
        {
            return "Felidae";
        }
    }
}