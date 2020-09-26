namespace CompositionVsInheritance.Models
{
    public class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Scientific name
        /// </summary>
        public string Name { get; set; }

        public virtual string Sound()
        {
            return "strange animal sound";
        }
    }
}