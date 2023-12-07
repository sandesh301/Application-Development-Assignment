using System;

public class Car
{
    private string brand;
    private int year;
    private float price;

    // Constructor
    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    // Method to display car details
    public void DisplayDetails()
    {
        Console.WriteLine($"Brand: {brand}, Year: {year}, Price: {price}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Car
        Car myCar = new Car("Toyota", 2020, 30000.50f);

        // Print out the details of the car
        myCar.DisplayDetails();
    }
}
