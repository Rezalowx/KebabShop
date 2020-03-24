namespace C_
{
    public class Vegetables
    {
        private bool salad;
        private bool tomato;
        private bool onions;

        public Vegetables(bool salad, bool tomato, bool onions)
        {
            Salad = salad;
            Tomato = tomato;
            Onions = onions;
        }

        public bool Salad { get => salad; set => salad = value; }
        public bool Tomato { get => tomato; set => tomato = value; }
        public bool Onions { get => onions; set => onions = value; }
    }
}