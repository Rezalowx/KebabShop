namespace C_
{
    public class Meal
    {
        string name;
        bool isVegge;

        public Meal(string name, bool isVegge)
        {
            this.name = name;
            this.isVegge = isVegge;
        }

        public string Name { get => name; set => name = value; }
        public bool IsVegge { get => isVegge; set => isVegge = value; }
    }
}