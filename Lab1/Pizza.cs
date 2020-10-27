using System;
namespace Lab1
{
    public class Pizza
    {
        // instance variables
        String size;
        int numCheese, numPepperoni, numHam, numToppings;

        // Constructors
        public Pizza() // default constructor
        {

        }

        public Pizza(String size, int numCheese, int numPepperoni, int numHam)
        {
            this.size = size;
            this.numCheese = numCheese;
            this.numPepperoni = numPepperoni;
            this.numHam = numHam;
            numToppings = numCheese + numPepperoni + numHam;
        }

        // Methods
        public void setSize(String sizeOfPizza)
        {
            size = sizeOfPizza;
        }

        public void setToppings(int numC, int numP, int numH)
        {
            numCheese = numC;
            numPepperoni = numP;
            numHam = numH;
        }

        public void setSizeAndToppings(String sizeOfPizza, int numC, int numP, int numH)
        {
            size = sizeOfPizza;
            numCheese = numC;
            numPepperoni = numP;
            numHam = numH;
        }

        public String getSize()
        {
            return size;
        }

        public int getCheese()
        {
            return numCheese;
        }

        public int getPepperoni()
        {
            return numPepperoni;
        }

        public int getHam()
        {
            return numHam;
        }

        public int getToppings()
        {
            return numToppings;
        }

        public double CalculateCost()
        {
            double pizzaCost = 0;
            int topping = 2;

            if (size == "small")
            {
                pizzaCost = 10;
            } else if (size == "medium")
            {
                pizzaCost = 12;
            } else if (size == "large")
            {
                pizzaCost = 14;
            }

            pizzaCost += (numToppings * topping);

            return pizzaCost;
        }

        public String toString()
        {
            return "A " + size + " pizza with " + numCheese + " cheese, "
                + numPepperoni + " pepperoni, and " + numHam + " ham toppings "
                + "will cost $" + this.CalculateCost();
        }
    }
}
