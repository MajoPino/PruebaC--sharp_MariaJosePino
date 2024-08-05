using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PruebaC__sharp_MariaJosePino.Models;

    public class VeterinaryClinic
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Dog> Dogs = new List<Dog>();
        public List<Cat> Cats = new List<Cat>();

        public VeterinaryClinic()
        {}

        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void SaveDog(Dog newDog)
        {
            Dogs.Add(newDog);
        }

        public void SaveCat(Cat newCat)
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

        public void ShowAllPatients()
        {}

        public void ShowAllAnimals(string type)
        {}

        public void ShowPatient(int idPatient)
        {}
    }
