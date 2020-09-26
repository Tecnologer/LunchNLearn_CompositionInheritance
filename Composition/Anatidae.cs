using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition
{
    public class Anatidae : IFamily
    {
        public Anatidae(string name, int incubation)
        {
            Class = new Oviparity(name, incubation);
        }

        public IClass Class { get; }

        public string GetFamilyName()
        {
            return "Anatidae";
        }
    }
}