using CompositionVsInheritance.Models;

namespace CompositionVsInheritance.Inheritance
{
    public class Cat : Felidae
    {
        public Cat() : base("Felis catus")
        {

        }

        public override string Sound() => Mew();
        public string Mew()
        {
            return "mew mew";
        }
    }
}