using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC__sharp_MariaJosePino.Models;

public class Dog : Animal
{
    public bool BreedingStatus { get; set; }
    public string? Temperament { get; set; }
    public string? MicrochipNumber { get; set; }
    public string? BarkVolume { get; set; }
    public string? CoatType { get; set; }

    public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base(id, name, birthdate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        Temperament = temperament.Trim().ToLower();
        MicrochipNumber = microchipNumber.Trim().ToLower();
        BarkVolume = barkVolume.Trim().ToLower();
        CoatType = coatType.Trim().ToLower();
    }

    public override void ShowInformation()
    {
        string? birthToString = Convert.ToString(Birthdate);
        string? ageInMonths = Convert.ToString(CalculateAgeInMonths());
        base.ShowInformation();
        Console.WriteLine(@$"| Name: {Name} | Birthdate: {birthToString} | Age: {ageInMonths} months | Breed: {Breed} | Color: {Color} | Weight: {WeightInKg} Kg | Temperament: {Temperament} | Microchip number: {MicrochipNumber} | Barking Volume: {BarkVolume} | Coat type: {CoatType} |");
    }
    public static bool isBred()
    {
        bool BreedingStatus = false;
        bool flag = true;

        while (flag)
        {
            Console.WriteLine(@$"Is the dog already castrated? (y/n): ");
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
                Console.WriteLine(@$"-----------------------------------------------------------------------");
                Console.WriteLine(@$"Invalid option. Please, try again.
                ");
            }
        }
        return BreedingStatus;
    }

    public override void UpdateSelf()
    {
        base.UpdateSelf();
        BreedingStatus = isBred();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
        Console.WriteLine(@$"Please enter the new temperament: ");
        Temperament = Console.ReadLine().Trim().ToLower();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
        Console.WriteLine(@$"Please enter the new microchip number: ");
        MicrochipNumber = Console.ReadLine().Trim().ToLower();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
        Console.WriteLine(@$"Please enter the new barking volume: ");
        BarkVolume = Console.ReadLine().Trim().ToLower();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
        Console.WriteLine(@$"Please enter the new coat type (long, medium, short, hairless): ");
        CoatType = Console.ReadLine().Trim().ToLower();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
    }

    public void CastrateAnimal()
    {
        if (BreedingStatus == false)
        {
            BreedingStatus = true;
            Console.WriteLine(@$"Your Cat is Castrated now!");
        }
        else
        {
            Console.WriteLine(@$"Your Cat has been castrated already, it's time for another type of care.");
        }
    }

    public void HairDress()
    {
        if (CoatType == "long")
        {
            Console.WriteLine(@$"What size you want your Dog's coat lenght to be?
                1. Medium
                2. Short");
            int mediumOrShort = Convert.ToInt16(Console.ReadLine());

            if (mediumOrShort == 1)
            {
                CoatType = "medium";
                Console.WriteLine(@$"Your Dog's coat has been trimmed to a medium size.");
            }
            else if (mediumOrShort == 2)
            {
                CoatType = "short";
                Console.WriteLine(@$"Your Dog's coat has been trimmed to a short size.");
            }
            else
            {
                Console.WriteLine(@$"Invalid option. Please, try again.");
            }
        }
        else if (CoatType == "medium")
        {
            CoatType = "short";
            Console.WriteLine(@$"Your Dog's coat has been trimmed to a short size.");
        }
        else if (CoatType == "short" || CoatType == "hairless")
        {
            Console.WriteLine("There's no need to trim your Dog's coat.");
        }
        else
        {
            Console.WriteLine(@$"Invalid, please register the dog again.");
        }
    }
}
