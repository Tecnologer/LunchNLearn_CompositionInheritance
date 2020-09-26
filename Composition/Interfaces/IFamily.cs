namespace CompositionVsInheritance.Composition.Interfaces
{
    public interface IFamily
    {
        IClass Class { get; }
        string GetFamilyName();
    }
}