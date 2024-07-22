using System;
using System.Net;
using System.Runtime.InteropServices;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // - Create a class Animal
            // - give this class 4 members that all Animals have in common


            // - Create a class Bird
            // - give this class 4 members that are specific to Bird
            // - Set this class to inherit from your Animal Class

            // - Create a class Reptile
            // - give this class 4 members that are specific to Reptile
            // - Set this class to inherit from your Animal Class


            
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.CanFly = true;
            myBird.ChirpNoise = "Tweet Tweet";
            myBird.FeatherColor = "Red";
            myBird.BeakLength = "Long";

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            var myReptile = new Reptile();
            myReptile.HasTail = true;
            myReptile.LaysEggs = true;
            myReptile.ScaleColor = "Dark Brown";
            myReptile.ScaleShape = "Sharp";

            var myAnimals = new Animal[] { myBird, myReptile };
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"My {animal.Type}");
                Console.WriteLine("");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Has Children: {animal.Parent}");
                Console.WriteLine($"Gender: {animal.Sex}");
                if (animal == myBird)
                {
                    Console.WriteLine($"Chirp Noise: {myBird.ChirpNoise}");
                    Console.WriteLine($"Beak Length: {myBird.BeakLength}");
                    Console.WriteLine($"Can Fly: {myBird.CanFly}");
                    Console.WriteLine($"Feather Colors: {myBird.FeatherColor}");
                    Console.WriteLine("------------------------------");
                } else if (animal == myReptile)
                {
                    Console.WriteLine($"Has Tail: {myReptile.HasTail}");
                    Console.WriteLine($"Lays Eggs: {myReptile.LaysEggs}");
                    Console.WriteLine($"Scale Color: {myReptile.ScaleColor}");
                    Console.WriteLine($"Scale Shape: {myReptile.ScaleShape}");
                    Console.WriteLine("------------------------------");
                }
                
            }
        }
    }
}
