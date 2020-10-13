namespace CompositionInterfaces
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public abstract void Speak();
    }
}