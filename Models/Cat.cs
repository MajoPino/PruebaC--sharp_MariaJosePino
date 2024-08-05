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
            if (FurLenght == "long")
            {
                Console.WriteLine(@$"What size you want your cat's hair to be?
                1. Medium
                2. Short");
                int mediumOrShort = Convert.ToInt16(Console.ReadLine());

                if (mediumOrShort == 1)
                {
                    FurLenght = "medium";
                    Console.WriteLine(@$"Your Cat's hair has been trimmed to a medium size.");
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
                Console.WriteLine(@$"Your Cat's hair has been trimmed to a short size.");
            }
            else if (FurLenght == "short" || FurLenght == "hairless")
            {
                Console.WriteLine("There's no need to trim your Cat's hair.");
            }
            else
            {
                Console.WriteLine(@$"Invalid, please register the cat again.");
            }
        }
    }
