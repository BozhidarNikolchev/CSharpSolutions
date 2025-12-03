using System;

class Program
{
    static void Main()
    {
        string figureType = Console.ReadLine();
        double result = 0.0;

        if (figureType == "square")
        {
            double sideA = double.Parse(Console.ReadLine());
            result = sideA * sideA; // Area of a square
        }
        else if (figureType == "rectangle")
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            result = sideA * sideB; // Area of a rectangle
        }
        else if (figureType == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            result = (radius * radius) * Math.PI; // Area of a circle
        }
        else if (figureType == "triangle")
        {
            double sideA = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            result = (h * sideA) / 2; // Area of a triangle
        }

        Console.WriteLine(Math.Round(result, 3)); // Round to 3 decimal places
    }
}
