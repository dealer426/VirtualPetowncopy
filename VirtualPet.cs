using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class VirtualPet
    {
        // add properties here

        public string Name { get; set; }
        public int HungerLevel { get; set; } = 5;
        public string Species { get; set; }
        public bool IsInShelter { get; set; }


        // add constructors here
        public VirtualPet()
        {
        
        }

        public VirtualPet(string name, int hungerLevel, string species, bool isInShelter)
        {
            Name = name; 
            HungerLevel = hungerLevel;
            Species = species;
            IsInShelter = isInShelter;
        }

        // add methods here
        public void SetPetName()
        {
            Console.WriteLine("What is the Pet's name?");
            string UsersPetsName = Console.ReadLine();
            Name = UsersPetsName;

        }

        public void SetPetSpecies()
        {
            Console.WriteLine("What is your Pets species?");
            string UserPetsSpecies = Console.ReadLine();
            Species = UserPetsSpecies;
        }


        public void ViewPetInfo()
        {
            Console.WriteLine($"My Pets name is {Name}. Its Species is {Species}.");

        }

        public void AddPetToShelter()
        {
            IsInShelter = true;
            Console.WriteLine((IsInShelter) ? "Your Pet is in the shelter." : "Something Went Wrong!");

        }

        public void RemovePetFromShelter()
        {
            IsInShelter = false;
        }

        public void FeedPet()
        {
            Console.WriteLine($"Current Hunger level decreases by 1 {--HungerLevel}"); 
        }

    }
}
