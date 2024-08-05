
using PruebaC__sharp_MariaJosePino.Models;

//Raw data

var newVet = new VeterinaryClinic("Veterinary Center", "Cra #83 2295");

VeterinaryClinic.SaveDog(new Dog(1, "Pete", new DateOnly (12,02,2009), "Border Collie", "black & white", 32, true, "feisty", "43124", "loud", "medium"));
VeterinaryClinic.SaveDog(new Dog(2, "Steve", new DateOnly (08,05,2012), "Golden retreiver", "Yellow", 30, false, "playful", "73994", "moderate", "long"));
VeterinaryClinic.SaveDog(new Dog(3, "Mary Poppins", new DateOnly (11,11,2023), "Stray", "brown", 15, false, "spoiled", "13158", "low", "short"));

VeterinaryClinic.SaveCat(new Cat(1, "Spok", new DateOnly (07,04,2010), "Persian", "black & white", 07, false, "long"));
VeterinaryClinic.SaveCat(new Cat(2, "Bills", new DateOnly (14,07,2018), "Sphynx", "pink", 5.5, true, "hairless"));
VeterinaryClinic.SaveCat(new Cat(3, "Coffee", new DateOnly (30,10,2020), "Stray", "brown, white & black", 7.5, true, "medium"));

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
    ManagerApp.CreateDog();
    Dog newDog = ManagerApp.CreateDog();
    VeterinaryClinic.SaveDog(newDog);
    BackToMenu();
}

void NewCat()
{
    ManagerApp.CreateCat();
    Cat newCat = ManagerApp.CreateCat();
    VeterinaryClinic.SaveCat(newCat);
    BackToMenu();
}

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
        Console.Clear();
        NewDog();
        break;

        case 2:
        Console.Clear();
        NewCat();
        break;

        case 3:
        Console.Clear();
        Console.WriteLine("Work in progress...");
        break;

        case 4:
        Console.Clear();
        Console.WriteLine("Work in progress...");
        break;

        case 0:
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