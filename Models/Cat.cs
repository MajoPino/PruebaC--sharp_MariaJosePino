using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC__sharp_MariaJosePino.Models;

    public class Cat : Animal
    {
        public bool BreedingStatus { get; set; }
        public string? FurLenght { get; set; }

        public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLenght) : base(id, name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            FurLenght = furLenght.Trim().ToLower();
        }

    public override void ShowInformation()
    {
        string? birthToString = Convert.ToString(Birthdate);
        string? ageInMonths = Convert.ToString(CalculateAgeInMonths());
        base.ShowInformation();
        Console.WriteLine(@$"| Name: {Name} | Birthdate: {birthToString} | Age: {ageInMonths} months | Breed: {Breed} | Color: {Color} | Weight: {WeightInKg} Kg | Fur lenght: {FurLenght}");
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

        public static bool isBred()
    {
        bool BreedingStatus = false;
        bool flag = true;

        while (flag)
        {
            Console.WriteLine(@$"Is the cat already castrated? (y/n): ");
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
        Console.WriteLine(@$"Please enter the new fur lenght (long, medium, short, hairless): ");
        FurLenght = Console.ReadLine().Trim().ToLower();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
    }

        public void HairDress()
        {
            if (FurLenght == "long")
            {
                Console.WriteLine(@$"What size you want your cat's fur lenght to be?
                1. Medium
                2. Short");
                int mediumOrShort = Convert.ToInt16(Console.ReadLine());

                if (mediumOrShort == 1)
                {
                    FurLenght = "medium";
                    Console.WriteLine(@$"Your Cat's fur has been trimmed to a medium size.");
                }
                else if (mediumOrShort == 2)
                {
                    FurLenght = "short";
                    Console.WriteLine(@$"Your Cat's fur has been trimmed to a short size.");
                }
                else
                {
                    Console.WriteLine(@$"Invalid option. Please, try again.");
                }
            }
            else if (FurLenght == "medium")
            {
                FurLenght = "short";
                Console.WriteLine(@$"Your Cat's fur has been trimmed to a short size.");
            }
            else if (FurLenght == "short" || FurLenght == "hairless")
            {
                Console.WriteLine("There's no need to trim your Cat's fur.");
            }
            else
            {
                Console.WriteLine(@$"Invalid, please register the cat again.");
            }
        }
    }
