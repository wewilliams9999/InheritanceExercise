using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - Done

            // give this class 4 members that all Animals have in common - Done


            // Create a class Bird - Done

            // give this class 4 members that are specific to Bird - Done
            // Set this class to inherit from your Animal Class - Done

            // Create a class Reptile - Done
            // give this class 4 members that are specific to Reptile - Done
            // Set this class to inherit from your Animal Class - Done




            /*Create an object of your Bird class - Done
             *  give values to your members using the object of your Bird class
             *   
             * Creatively display the class member values 
             */
            Bird parrot = new Bird();
                        
            parrot.Name = "Pete";
            parrot.IsAlive = true;
            parrot.NumberOfLegs = 2;
            parrot.WingColor = "purple";
            parrot.CanFly = true;
            parrot.Migrates = false;
            parrot.BeakLength = 1.5;
            parrot.Age = 55;

            Console.WriteLine($"I have a pet parrot named {parrot.Name}. It is {parrot.IsAlive.ToString().ToLower()} that " +
                $"he is alive and has {parrot.NumberOfLegs} legs. He has {parrot.WingColor} wings and it is {parrot.CanFly.ToString().ToLower()} that he can fly and " +
                $"{parrot.Migrates.ToString().ToLower()} that he migrates. His beak is {parrot.BeakLength} inches long and he is {parrot.Age} years old.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile()
            {
                HasScales = true,
                Environment = "desert",
                Defense = "biting",
                CanRegenerateTail = true,
                Name = "Petunia",
                Age = 7
            };

            Console.WriteLine($"I also have a pet lizard named {lizard.Name}. Here is some info about {lizard.Name}:  Has Scales?  {lizard.HasScales}.   " +
                $"Environment:  {lizard.Environment}.   Can Regenerate tail?  {lizard.CanRegenerateTail}.   Defense:  {lizard.Defense}.   Is Alive?  {lizard.IsAlive}.   " +
                $"Number of Legs:  {lizard.NumberOfLegs}.   Age:  {lizard.Age}");

            var myAnimals = new Animal[] { lizard, parrot };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine("Pet stats:");
                Console.WriteLine($"Name: {animal.Name}");
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"Legs: {animal.NumberOfLegs}");
            }
            

        }
    }
}
