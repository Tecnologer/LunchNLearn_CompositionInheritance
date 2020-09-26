using CompositionVsInheritance.Composition.Interfaces;
using CompositionVsInheritance.Models;

namespace CompositionVsInheritance.Composition
{
    public class Mammal : IClass
    {
        public Mammal(string name, int gestation)
        {
            Kingdom = new Animal(name);
            Gestation = gestation;
        }

        public Animal Kingdom { get; }

        /// <summary>
        /// Duration of gestation in days
        ///</summary>
        public int Gestation { get; set; }

        public string GetClassName()
        {
            return "Mammal";
        }
    }
}