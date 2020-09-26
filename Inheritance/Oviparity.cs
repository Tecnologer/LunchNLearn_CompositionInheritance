using CompositionVsInheritance.Models;

namespace CompositionVsInheritance.Inheritance
{
    public class Oviparity : Animal
    {
        public Oviparity(string name) : base(name)
        {

        }

        ///<summary>
        /// Duration of the egg incubation in days
        ///</summary>
        public int Incubation { get; set; }
    }
}