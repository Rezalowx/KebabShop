using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab kebab = new Kebab(true, true, true);

            if(kebab.IsVegge())
            {
                Console.WriteLine("Le kebab est végé !");
            }
            else
            {
                Console.WriteLine("Wow le kebab est interdit");
            }

            

        }
    }
}
