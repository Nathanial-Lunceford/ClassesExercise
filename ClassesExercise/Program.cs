// See https://aka.ms/new-console-template for more information
using System;
using ClassesExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Car newCar = new Car();
        newCar.Make = "Subaru";
        newCar.Model = "Forester";
        newCar.Year = "2007";

        Console.WriteLine($"My car is a {newCar.Make} {newCar.Model}, from the " +
            $"year {newCar.Year}");    
    }
}
