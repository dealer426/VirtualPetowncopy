using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu();
            string mainMenuChoice = "";
            string gameMenuChoice = "";

            while(mainMenuChoice != "2")
            { 
                mainMenuChoice = myMenu.AppMenu();
                
                while (gameMenuChoice != "10")
                {
                    gameMenuChoice = myMenu.GameMenu();
                    myMenu.ExecuteMenuChoice(gameMenuChoice);
                }
            }
        }
    }
}
