using CompositionVsInheritance.Models;

namespace CompositionVsInheritance.Inheritance
{
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        }

        /// <summary>
        /// Duration of gestation in days
        ///</summary>
        public int Gestation { get; set; }
    }
}