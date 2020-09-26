using System.Diagnostics;

namespace CompositionVsInheritance.Inheritance
{
    public class Dog : Caninae
    {
        public Dog() : base("Canis lupus familiaris")
        {

        }

        public override string Sound() => Woof();

        public string Woof()
        {
            return "woof woof";
        }
    }
}