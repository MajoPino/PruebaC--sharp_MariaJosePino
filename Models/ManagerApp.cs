using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PruebaC__sharp_MariaJosePino.Models;

public class ManagerApp
{
    public Dog CreateDog()
    {
        Console.WriteLine(@$"Please enter the new dog's id: ");
        int Id = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(@$"Please enter the new dog's name: ");
        string? Name = Console.ReadLine();
        Console.WriteLine(@$"Please enter the new dog's birthdate (yyyy/mm/dd): ");
        DateOnly BirthDate = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine(@$"Please enter the new dog's breed: ");
        string? Breed = Console.ReadLine();
        Console.WriteLine(@$"Please enter the new dog's color: ");
        string? Color = Console.ReadLine();
        Console.WriteLine(@$"Please enter the new dog's weight (in kg): ");
        double WeightInKg = Convert.ToDouble(Console.ReadLine());
        bool BreedingStatus = false;
        while (true)
        {
            Console.WriteLine(@$"Is the new dog already castrated? (y/n): ");
            string? isBred = Console.ReadLine().Trim().ToLower();
            if (isBred == "y")
            {
                BreedingStatus = true;
                break;
            }
            else if (isBred == "n")
            {
                BreedingStatus = false;
                break;
            }
            else
            {
                Console.WriteLine(@$"
Invalid option. Please, try again.");
            }
        }
        Console.WriteLine(@$"Please enter the new dog's temperament: ");
        string? Temperament = Console.ReadLine();
        Console.WriteLine(@$"Please enter the new dog's microchip number: ");
        string? MicrochipNumber = Console.ReadLine();
        Console.WriteLine(@$"Please enter the new dog's barking volume: ");
        string? BarkVolume = Console.ReadLine();
        Console.WriteLine(@$"Please enter the new dog's coat type: ");
        string? CoatType = Console.ReadLine();

        Dog newDog = new Dog(Id, Name, BirthDate, Breed, Color, WeightInKg, BreedingStatus, Temperament, MicrochipNumber, BarkVolume, CoatType);
        
        return newDog;

    }
}
