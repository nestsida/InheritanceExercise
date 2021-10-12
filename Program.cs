using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bird OurBird = new Bird();
            {
                OurBird.Name = "Chickpea";
                OurBird.Age = 3;
                OurBird.Wings = 2;
                OurBird.OwnerName = "Sarah";
            };

            Console.WriteLine($"Our bird's name is {OurBird.Name} who is {OurBird.Age}. It has {OurBird.Wings} and the owner is {OurBird.OwnerName}");


            Reptile Snake = new Reptile();
            {
                
                Snake.PreferredClimate = "warm";
                Snake.PreferredFood = "meat";
                Snake.Legs = 0;
                Snake.WildAnimal = true;
            };
            Console.WriteLine($"Snakes prefer living in a {Snake.PreferredClimate}. Snakes like to eat {Snake.PreferredFood}. Snakes have {Snake.Legs} legs. Snakes are wild Animals: {Snake.WildAnimal}");

            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
        
    }

}

