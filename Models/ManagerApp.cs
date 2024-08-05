using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PruebaC__sharp_MariaJosePino.Models;

public static class ManagerApp
{
    public static bool isBred()
    {
        bool BreedingStatus = false;
        bool flag = true;

        while (flag)
        {
            Console.WriteLine(@$"Is the new dog already castrated? (y/n): ");
            string? isBred = Console.ReadLine().Trim().ToLower();
            if (isBred == "y")
            {
                BreedingStatus = true;
                flag = false;
                break;
            }
            else if (isBred == "n")
            {
                BreedingStatus = false;
                flag = false;
                break;
            }
            else
            {
                ShowSeparator();
                Console.WriteLine(@$"Invalid option. Please, try again.
                ");
            }
        }
        return BreedingStatus;
    }

    public static Dog CreateDog()
    {
        Console.WriteLine(@$"Please enter the new dog's id: ");
        int Id = Convert.ToInt16(Console.ReadLine());
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's name: ");
        string? Name = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's birthdate (yyyy/mm/dd): ");
        DateOnly BirthDate = DateOnly.Parse(Console.ReadLine());
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's breed: ");
        string? Breed = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's color: ");
        string? Color = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's weight (in kg): ");
        double WeightInKg = Convert.ToDouble(Console.ReadLine());
        ShowSeparator();
        bool BreedingStatus = isBred();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's temperament: ");
        string? Temperament = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's microchip number: ");
        string? MicrochipNumber = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's barking volume: ");
        string? BarkVolume = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's coat type: ");
        string? CoatType = Console.ReadLine();
        ShowSeparator();

        Dog newDog = new Dog(Id, Name, BirthDate, Breed, Color, WeightInKg, BreedingStatus, Temperament, MicrochipNumber, BarkVolume, CoatType);
        
        return newDog;

    }

    public static Cat CreateCat()
    {
        Console.WriteLine(@$"Please enter the new cat's id: ");
        int Id = Convert.ToInt16(Console.ReadLine());
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new cat's name: ");
        string? Name = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new cat's birthdate (yyyy/mm/dd): ");
        DateOnly BirthDate = DateOnly.Parse(Console.ReadLine());
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new cat's breed: ");
        string? Breed = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new cat's color: ");
        string? Color = Console.ReadLine();
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new cat's weight (in kg): ");
        double WeightInKg = Convert.ToDouble(Console.ReadLine());
        ShowSeparator();
        bool BreedingStatus = false;
        while (true)
        {
            Console.WriteLine(@$"Is the new cat already castrated? (y/n): ");
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
                ShowSeparator();
                Console.WriteLine(@$"Invalid option. Please, try again.
                ");
            }
        }
        ShowSeparator();
        Console.WriteLine(@$"Please enter the new dog's fur lenght (long, medium, short, hairless): ");
        string? FurLenght = Console.ReadLine();
        ShowSeparator();

        Cat newCat = new Cat(Id, Name, BirthDate, Breed, Color, WeightInKg, BreedingStatus, FurLenght);
        
        return newCat;
        

    }

    public static void ShowHeader()
    {
        string veterinaryUpper = VeterinaryClinic.Name.ToUpper();
        Console.WriteLine(@$"
-----------------------------------------------------------------------
|   WELCOME TO THE VETERINARY MANAGEMENT SYSTEM OF {veterinaryUpper}  |
-----------------------------------------------------------------------");
    }

    public static void ShowFooter()
    {
        Console.WriteLine(@$".......................................................................
    {VeterinaryClinic.Name} | {VeterinaryClinic.Address} | 2024");
    }

    public static void ShowSeparator()
    {
        Console.WriteLine(@$"-----------------------------------------------------------------------");
    }

    public static void ShowMenu()
    {
        Console.WriteLine(@$".......................................................................
| These are the program options:                                      |
.......................................................................
| 1. Add a new dog.                                                   |
| 2. Add a new cat.                                                   |
| 3. List all the patients.                                           |
| 4. List animals.                                                    |
| 5. Delete dog.                                                      |
| 6. Delete cat.                                                      |
| 0. Exit the program.                                                |
.......................................................................");
    }



}
