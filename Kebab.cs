using System;
namespace C_
{

    public class Kebab
    {


        private Vegetables vegetables;
        private Meal meal;
        private Sauce sauce;

        public Vegetables Vegetables { get => vegetables; set => vegetables = value; }
        public Meal Meal { get => meal; set => meal = value; }
        public Sauce Sauce { get => sauce; set => sauce = value; }

        public Kebab(Vegetables vegetables, Meal meal, Sauce sauce)
        {
            this.vegetables = vegetables;
            this.meal = meal;
            this.sauce = sauce;
        }

        public bool IsVegge()
        {
            return this.meal.IsVegge;
        }

        //public bool IsPesce()
        //{
           
        //}

        public Kebab NoOnions(Kebab kebab)
        {
            Vegetables vegetables = new Vegetables(kebab.vegetables.Salad, kebab.vegetables.Tomato, false);
            return new Kebab(vegetables, kebab.meal, kebab.sauce);
       
        }


        public Kebab AddCheese(Kebab kebab)
        {
            Vegetables vegetables = new Vegetables(kebab.vegetables.Salad, kebab.vegetables.Tomato, kebab.vegetables.Onions);
            vegetables.Cheese = true;

            return new Kebab(vegetables, kebab.meal, kebab.sauce);
        }
    }
}
