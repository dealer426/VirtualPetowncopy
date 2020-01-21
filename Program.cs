using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Virtual Pet
            VirtualPet myCat = new VirtualPet();
            string mainMenuChoice = "";
            string gameMenuChoice = "";


            while(mainMenuChoice != "2")
            {
                Console.WriteLine("Virtual Pet Menu");
                Console.WriteLine("Welcome to Virtual Pet");
                Console.WriteLine("1. Play the Game");
                Console.Write("2. Exit the App");
                mainMenuChoice = Console.ReadLine();

                while (gameMenuChoice != "10")
                {
                    Console.WriteLine("1. Add a Pet to shelter");
                    Console.WriteLine("2. View the Pets Name and Species");
                    Console.WriteLine("3. Feed your Pet.");
                    Console.Write("10. Exit this Game");
                    gameMenuChoice = Console.ReadLine();

                    switch (gameMenuChoice)
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
    }
}
