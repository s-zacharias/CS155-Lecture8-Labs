/// Lecture No. 8		Lab No. 1
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  October 26, 2020
///
/// Problem Statement: Define a Pizza class that stores information about a
/// single pizza.
/// 
/// 
/// Overall Plan:
/// 1) Create new Pizza object using the constructors.
/// 2) Test each getter method.
/// 3) Test each setter method and the toString method.
/// 4) Test the equals method.
/// 

using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Pizza objects
            Pizza pizza1 = new Pizza();
            Pizza pizza2 = new Pizza("small", 2, 1, 3);
            Pizza pizza3 = new Pizza("large", 1, 1, 0);

            // Test the getter methods
            Console.WriteLine("The size of Pizza 1 is: " + pizza1.getSize());

            Console.WriteLine("The toppings on Pizza 2 are:\n " +
                pizza2.getCheese() + "cheese\n" + pizza2.getPepperoni() +
                " pepperoni\n" + pizza2.getHam() + " ham");

            // Test the CalculateCost method
            Console.WriteLine("The cost of Pizza 2 is: $" + pizza2.CalculateCost());

            // Test the setter methods
            pizza1.setSizeAndToppings("medium", 1, 0, 1);
            Console.WriteLine("The size of Pizza 1 is: " + pizza1.getSize());
            Console.WriteLine("The total number of toppings on Pizza 1 is: " +
                pizza1.getToppings());

            // Test the toString Method
            Console.WriteLine(pizza1.toString());
            Console.WriteLine(pizza2.toString());
            Console.WriteLine(pizza3.toString());

        }
    }
}
