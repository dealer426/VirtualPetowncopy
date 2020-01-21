using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Menu
    {
        public string MenuName { get; set; }

        readonly VirtualPet myCat = new VirtualPet();

        public string AppMenu()
        {
            Console.WriteLine("Virtual Pet Menu");
            Console.WriteLine("Welcome to Virtual Pet");
            Console.WriteLine("1. Play the Game");
            Console.Write("2. Exit the App");
            string menuChoice = Console.ReadLine();
            return menuChoice;
      
        }

        public string GameMenu()
        {
            Console.WriteLine("1. Add a Pet to shelter");
            Console.WriteLine("2. View the Pets Name and Species");
            Console.WriteLine("3. Feed your Pet.");
            Console.Write("10. Exit this Game");
            string gameMenuChoice = Console.ReadLine();
            return gameMenuChoice;
        }

        public void ExecuteMenuChoice(string menuChoice)
        {
            switch (menuChoice)
            {
                case "1":
                    myCat.IsInShelter = true;
                    myCat.AddPetToShelter();
                    myCat.SetPetName();
                    myCat.SetPetSpecies();
                    break;
                case "2":
                    myCat.ViewPetInfo();
                    break;
                case "3":
                    Console.WriteLine(myCat.HungerLevel);
                    myCat.FeedPet();
                    break;
                default:
                    break;
            }
        }

    }
}
