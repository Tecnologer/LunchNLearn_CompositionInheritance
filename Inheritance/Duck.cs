namespace CompositionVsInheritance.Inheritance
{
    public class Duck : Oviparity
    {
        public Duck() : base("Anas platyrhynchos domesticus")
        {

        }

        public override string Sound() => Quak();

        public string Quak()
        {
            return "quak quak";
        }
    }
}