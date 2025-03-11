using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Initialize the services (database and pricing)
        IVehicleDatabase vehicleDatabaseService = new VehicleDatabaseService();
        IVehiclePricing vehiclePricingService = new VehiclePricingService();

        // 2. Create a VehicleRentalSystem with dependencies injected
        var rentalSystem = new VehicleRentalSystem(vehicleDatabaseService, vehiclePricingService);

        // 3. Create some vehicle instances
        var car = new Vehicle
        {
            Model = "Toyota Corolla",
            Year = 2020,
            Type = "Car",
            FuelEfficiency = 30.5, // miles per gallon
            ElectricRange = 0
        };

        var electricCar = new Vehicle
        {
            Model = "Tesla Model 3",
            Year = 2021,
            Type = "Electric",
            FuelEfficiency = 0, // electric vehicles don't use fuel efficiency in this example
            ElectricRange = 250 // miles on a full charge
        };

        var truck = new Vehicle
        {
            Model = "Ford F-150",
            Year = 2022,
            Type = "Truck",
            FuelEfficiency = 20.0, // miles per gallon
            ElectricRange = 0
        };

        // 4. Add vehicles to the rental system
        rentalSystem.AddVehicle(car);
        rentalSystem.AddVehicle(electricCar);
        rentalSystem.AddVehicle(truck);

        // 5. Print vehicle info
        rentalSystem.PrintVehicleInfo();

        // 6. Rent a vehicle
        Console.WriteLine("\nRenting Toyota Corolla for 5 days:");
        decimal rentalCost = rentalSystem.RentVehicle("Toyota Corolla", 5);
        Console.WriteLine($"Rental cost: ${rentalCost}");

        // 7. Rent another vehicle
        Console.WriteLine("\nRenting Tesla Model 3 for 3 days:");
        rentalCost = rentalSystem.RentVehicle("Tesla Model 3", 3);
        Console.WriteLine($"Rental cost: ${rentalCost}");
    }
}
