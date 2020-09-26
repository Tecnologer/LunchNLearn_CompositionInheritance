namespace CompositionVsInheritance.Composition.Interfaces
{
    public interface IAnimal
    {
        IFamily Family { get; }
        string Sound();
    }
}