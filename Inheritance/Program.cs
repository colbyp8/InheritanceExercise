using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.Migrate = true;
            myBird.BeakLength = 3.5;

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = false,
                Habitat = "Trees",
                CanGrowTail = true,

            };

            var myAnimals = new Animal[] {myBird, lizard};
            
            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"# of legs: {animal.Legs}");
                Console.WriteLine($"Lives by: {animal.LandSeaAir}");

            }


        }
    }
}
