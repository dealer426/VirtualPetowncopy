using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Menu
    {
        public string MenuName { get; set; }

        public string AppMenu()
        {
            Console.WriteLine("Virtual Pet Menu");
            Console.WriteLine("Welcome to Virtual Pet");
            Console.WriteLine("1. Play the Game");
            Console.Write("2. Exit the App");
            string menuChoice = Console.ReadLine();
            return menuChoice;
      
        }

        public string GameMenu(string menuCHoice)
        {
            return menuCHoice;
        }

    }
}
