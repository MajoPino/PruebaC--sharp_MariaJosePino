
using PruebaC__sharp_MariaJosePino.Models;

//Raw data

var newVet = new VeterinaryClinic("Veterinary Center", "Cra #83 2295");

VeterinaryClinic.SaveDog(new Dog(1, "Pete", new DateOnly (2009,12,02), "Border Collie", "black & white", 32, true, "feisty", "43124", "loud", "medium"));
VeterinaryClinic.SaveDog(new Dog(2, "Steve", new DateOnly (2012,08,27), "Golden retreiver", "Yellow", 30, false, "playful", "73994", "moderate", "long"));
VeterinaryClinic.SaveDog(new Dog(3, "Mary Poppins", new DateOnly (2023,08,07), "Stray", "brown", 15, false, "spoiled", "13158", "low", "short"));

VeterinaryClinic.SaveCat(new Cat(1, "Spok", new DateOnly (2010,07,04), "Persian", "black & white", 07, false, "long"));
VeterinaryClinic.SaveCat(new Cat(2, "Bills", new DateOnly (2018,01,13), "Sphynx", "pink", 5.5, true, "hairless"));
VeterinaryClinic.SaveCat(new Cat(3, "Coffee", new DateOnly (2020,09,01), "Stray", "brown, white & black", 7.5, true, "medium"));

// Program functions

void BackToMenu()
{
    ManagerApp.ShowFooter();
    ManagerApp.ShowSeparator();
    Console.WriteLine(@$"Press any key to return to the main menu.");
    Console.ReadKey();
    Main();
}

void NewDog()
{
    Dog newDog = ManagerApp.CreateDog();
    VeterinaryClinic.SaveDog(newDog);
    Console.WriteLine(@"New dog added successfully!");
    BackToMenu();
}

void NewCat()
{
    Cat newCat = ManagerApp.CreateCat();
    VeterinaryClinic.SaveCat(newCat);
    Console.WriteLine(@"New cat added successfully!");
    BackToMenu();
}

void ShowAllPatients()
{
    VeterinaryClinic.ShowAllPatients();
    BackToMenu();
}

void ShowAllAnimals()
{
    Console.WriteLine("Which animal you want to see the information listed? (cats/dogs): ");
    string? option = Console.ReadLine().Trim().ToLower();
    VeterinaryClinic.ShowAllAnimals(option);
    BackToMenu();
}

void DeleteDog()
{
    Console.WriteLine("Please, enter the id of the dog you'd like to delete: ");
    int id = Convert.ToInt16(Console.ReadLine().Trim());
    VeterinaryClinic.DeleteDog(id);
    BackToMenu();
}

void DeleteCat()
{
    Console.WriteLine("Please, enter the id of the cat you'd like to delete: ");
    int id = Convert.ToInt16(Console.ReadLine().Trim());
    VeterinaryClinic.DeleteCat(id);
    BackToMenu();
}

void ShowPatient()
{
    Console.WriteLine("Please, enter the id of the animal you'd like to search: ");
    int id = Convert.ToInt16(Console.ReadLine().Trim());
    ManagerApp.ShowSeparator();
    Console.WriteLine("Please, enter the name of the animal you'd like to search: ");
    string? name = Console.ReadLine().Trim().ToLower(); 
    VeterinaryClinic.ShowPatient(name, id);
    BackToMenu();
}

void TrimFur()
{
    Console.WriteLine("Please, enter the kind of animal you want to trim their fur (cat/dog): ");
    string? animal = Console.ReadLine().Trim().ToLower();
    ManagerApp.ShowSeparator();
    VeterinaryClinic.TrimFur(animal);
    BackToMenu();
}

void Castrate()
{
    Console.WriteLine("Please, enter the kind of animal you want to castrate (cat/dog): ");
    string? animal = Console.ReadLine().Trim().ToLower();
    ManagerApp.ShowSeparator();
    VeterinaryClinic.Castrate(animal);
    BackToMenu();
}

/* void UpdateDog()
{
    Console.WriteLine("Please, enter the id of the dog you'd like to update: ");
    int id = Convert.ToInt16(Console.ReadLine().Trim());
    ManagerApp.ShowSeparator();
    Console.WriteLine("Please, enter the name of the dog you'd like to update: ");
    string? name = Console.ReadLine().Trim().ToLower(); 
    VeterinaryClinic.UpdateDog(name, id);
    BackToMenu();
} */

// Program function

void Main()
{
    // Menu with options

    Console.Clear();
    ManagerApp.ShowHeader();
    ManagerApp.ShowMenu();
    Console.Write("Please, choose one of the options from above: ");
    int option = Convert.ToInt16(Console.ReadLine());

    //Program switch

    switch (option)
    {
        case 1:
        //New dog
        Console.Clear();
        NewDog();
        break;

        case 2:
        //New cat
        Console.Clear();
        NewCat();
        break;

        case 3:
        //Show all patients
        Console.Clear();
        ShowAllPatients();
        break;

        case 4:
        //Show Animals
        Console.Clear();
        ShowAllAnimals();
        break;

        case 5:
        //Delete dog
        Console.Clear();
        DeleteDog();
        break;

        case 6:
        //Delete cat
        Console.Clear();
        DeleteCat();
        break;
        
        case 7:
        //Search patient
        Console.Clear();
        ShowPatient();
        break;

        case 8:
        //Trim fur
        Console.Clear();
        TrimFur();
        break;

        case 9:
        //Castrate Animal
        Console.Clear();
        Castrate();
        break;

        case 0:
        //Exit the program
        Console.Clear();
        Console.WriteLine("Thanks for using the program!");
        ManagerApp.ShowFooter();
        Environment.Exit(0);
        break;

        default:
        Main();
        break;
    }
}

Main();