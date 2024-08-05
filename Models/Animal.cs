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
        Name = name.Trim().ToLower();
        Birthdate = birthdate;
        Breed = breed.Trim().ToLower();
        Color = color.Trim().ToLower();
        WeightInKg = weightInKg;
    }

    public int ReturnId()
    {
        return Id;
    }

    public string ReturnName()
    {
        return Name;
    }

    public virtual void UpdateSelf()
    {
        Console.WriteLine(@$"Please enter the new name: ");
        Name = Console.ReadLine().Trim().ToLower();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
        Console.WriteLine(@$"Please enter the new birthdate (yyyy/mm/dd): ");
        Birthdate = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine(@$"-----------------------------------------------------------------------");
        Console.WriteLine(@$"Please enter the new breed: ");
        Breed = Console.ReadLine().Trim().ToLower();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
        Console.WriteLine(@$"Please enter the new color: ");
        Color = Console.ReadLine().Trim().ToLower();
        Console.WriteLine(@$"-----------------------------------------------------------------------");
        Console.WriteLine(@$"Please enter the new weight (in kg): ");
        WeightInKg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(@$"-----------------------------------------------------------------------");
    }

    
    public virtual void ShowInformation()
    {
        string? birthToString = Convert.ToString(Birthdate);
        string? ageInMonths = Convert.ToString(CalculateAgeInMonths());
    }

    protected void BasicReview()
    {
        Console.Write(@$"Name {Name} of breed {Breed} weights {WeightInKg} kg ");
    }

    protected int CalculateAgeInMonths()
    {
        int birth = Birthdate.Year;
        int today = DateTime.Now.Year;
        int ageInYears = today - birth;
        int ageInMonths = ageInYears * 12;
        return ageInMonths;
    }
}
