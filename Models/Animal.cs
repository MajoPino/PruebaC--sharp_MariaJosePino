using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC__sharp_MariaJosePino.Models;

public class Animal
{
    protected int Id { get; set; }
    protected string? Name { get; set; }
    protected DateOnly Birthdate { get; set; }
    protected string? Breed { get; set; }
    protected string? Color { get; set; }
    protected double WeightInKg { get; set; }

    public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Breed = breed;
        Color = color;
        WeightInKg = weightInKg;
    }

    public void ShowInformation()
    {
        string? birthToString = Convert.ToString(Birthdate.Year);
        Console.WriteLine(@$"Name: {Name} | Birthdate: {birthToString} | Breed: {Breed} | Color: {Color} | Weight: {WeightInKg} Kg");
    }

    protected void BasicReview()
    {
        Console.WriteLine(@$"Name {Name} of breed {Breed} weights {WeightInKg} kg");
    }

    protected int CalculateAgeInMonths()
    {
        int birth = Convert.ToInt32(Birthdate.Year);
        int today = Convert.ToInt32(DateTime.Now);
        int ageInYears = today - birth;
        int ageInMonths = ageInYears * 12;
        return ageInMonths;
    }
}
