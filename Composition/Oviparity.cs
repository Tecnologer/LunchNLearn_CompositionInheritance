using CompositionVsInheritance.Composition.Interfaces;
using CompositionVsInheritance.Models;

namespace CompositionVsInheritance.Composition
{
    public class Oviparity : IClass
    {
        public Oviparity(string name, int incubation)
        {
            Kingdom = new Animal(name);
            Incubation = incubation;
        }

        public Animal Kingdom { get; }

        ///<summary>
        /// Duration of the egg incubation in days
        ///</summary>
        public int Incubation { get; set; }

        public string GetClassName()
        {
            return "Oviparity";
        }
    }
}