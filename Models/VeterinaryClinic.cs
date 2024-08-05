using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PruebaC__sharp_MariaJosePino.Models;

    public class VeterinaryClinic
    {
        public static string? Name { get; set; }
        public static string? Address { get; set; }
        public static List<Dog> Dogs = new List<Dog>();
        public static List<Cat> Cats = new List<Cat>();

        public VeterinaryClinic()
        {}

        public VeterinaryClinic(string name, string address)
        {
            Name = name.Trim().ToLower();
            Address = address.Trim().ToLower();
        }

        public static void SaveDog(Dog newDog)
        {
            Dogs.Add(newDog);
        }

        public static void SaveCat(Cat newCat)
        {
            Cats.Add(newCat);
        }

        public void UpdateDog(Dog dog)
        {}

        public void UpdateCat(Cat cat)
        {}

        public void DeleteDog(int id)
        {}

        public void DeleteCat(int id)
        {}

        public static void ShowAllPatients()
        {
            Console.WriteLine(@$"
-----------------------------------------------------------------------
|                              DOGS                                   |
-----------------------------------------------------------------------");
            foreach (Dog dog in Dogs)
            {
                dog.ShowInformation();
                Console.WriteLine(@$"
-----------------------------------------------------------------------");
            }

            Console.WriteLine(@$"
-----------------------------------------------------------------------
|                              CATS                                   |
-----------------------------------------------------------------------");

            foreach (Cat cat in Cats)
            {
                cat.ShowInformation();
                Console.WriteLine(@$"
-----------------------------------------------------------------------");
            }
        }

        public void ShowAllAnimals(string type)
        {}

        public void ShowPatient(int idPatient)
        {}
    }
