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
    { }

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

    public static void UpdateDog(string name, int id)
    {
        var dog = Dogs.FirstOrDefault(x => x.ReturnId() == id && x.ReturnName() == name);

    }

    public void UpdateCat(Cat cat)
    { }

    public static void DeleteDog(int id)
    {
        var dog = Dogs.FirstOrDefault(x => x.ReturnId() == id);
        if (dog != null)
        {
            Dogs.Remove(dog);
            Console.WriteLine("Dog deleted succesfully!");
        }
        else
        {
            Console.WriteLine($"The dog with the id {id} doesn't exist. Please, try again.");
        }
    }

    public static void DeleteCat(int id)
    {
        var cat = Cats.FirstOrDefault(x => x.ReturnId() == id);
        if (cat != null)
        {
            Cats.Remove(cat);
            Console.WriteLine("Cat deleted succesfully!");
        }
        else
        {
            Console.WriteLine($"The cat with the id {id} doesn't exist. Please, try again.");
        }
    }

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

    public static void ShowAllAnimals(string type)
    {
        if (type == "cats")
        {
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
        else if (type == "dogs")
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
        }
        else
        {
            Console.WriteLine(@"Invalid option. Please, try again.");
        }
    }

    public static void ShowPatient(string namePatient, int idPatient)
    {
        var cat = Cats.FirstOrDefault(x => x.ReturnId() == idPatient && x.ReturnName() == namePatient);
        var dog = Dogs.FirstOrDefault(x => x.ReturnId() == idPatient && x.ReturnName() == namePatient);

        if (cat != null)
        {
            cat.ShowInformation();
        }
        else if (dog != null)
        {
            dog.ShowInformation();
        }
        else
        {
            Console.WriteLine($"The animal with the id {idPatient} and the name {namePatient} doesn't exist. Please, try again.");
        }
    }

    public static void TrimFur(string animal)
    {
        if (animal == "cat")
        {
            Console.Write("Please, enter the id of the cat you want to trim their fur: ");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(@$"-----------------------------------------------------------------------");
            var cat = Cats.FirstOrDefault(x => x.ReturnId() == id);
            if (cat != null)
            {
                cat.HairDress();
            }
            else
            {
                Console.WriteLine($"The cat with the id {id} doesn't exist. Please, try again.");
            }
        }
        if (animal == "dog")
        {
            Console.Write("Please, enter the id of the dog you want to trim their fur: ");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(@$"-----------------------------------------------------------------------");
            var dog = Dogs.FirstOrDefault(x => x.ReturnId() == id);
            if (dog != null)
            {
                dog.HairDress();
            }
            else
            {
                Console.WriteLine($"The dog with the id {id} doesn't exist. Please, try again.");
            }
        }
    }

    public static void Castrate(string animal)
    {
        if (animal == "cat")
        {
            Console.Write("Please, enter the id of the cat you want to castrate: ");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(@$"-----------------------------------------------------------------------");
            var cat = Cats.FirstOrDefault(x => x.ReturnId() == id);
            if (cat != null)
            {
                cat.CastrateAnimal();
            }
            else
            {
                Console.WriteLine($"The cat with the id {id} doesn't exist. Please, try again.");
            }
        }
        if (animal == "dog")
        {
            Console.Write("Please, enter the id of the dog you want to castrate: ");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(@$"-----------------------------------------------------------------------");
            var dog = Dogs.FirstOrDefault(x => x.ReturnId() == id);
            if (dog != null)
            {
                dog.CastrateAnimal();
            }
            else
            {
                Console.WriteLine($"The dog with the id {id} doesn't exist. Please, try again.");
            }
        }
    }

}
