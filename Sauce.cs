namespace C_
{
    public class Sauce
    {
        string name;

        public Sauce(string name)
        {
            this.name = name;
        
        }

        public string Name { get => name; set => name = value; }
    }
}