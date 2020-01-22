using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Menu
    {
        public string MenuName { get; set; }
        readonly VirtualPet myPet = new VirtualPet();
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
            Console.WriteLine("4. Play with your Pet.");
            Console.WriteLine("5. Take your Pet to the Dr.");
            Console.Write("10. Exit this Game");
            string gameMenuChoice = Console.ReadLine();
            return gameMenuChoice;
        }

        public void ExecuteMenuChoice(string menuChoice)
        {
            switch (menuChoice)
            {
                case "1":
                    myPet.AddPetToShelter();
                    myPet.SetPetName();
                    myPet.SetPetSpecies();
                    break;
                case "2":
                    myPet.ViewPetInfo();
                    break;
                case "3":
                    myPet.FeedPet();
                    break;
                case "4":
                    myPet.PlayWithPet();
                    break;
                case "5":
                    myPet.TakePetToDoctor();
                    break;
                default:
                    break;
            }
        }
    }
}
