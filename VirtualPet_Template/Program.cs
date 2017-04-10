using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //new instance of the pet
            VirtualPet myPet = new VirtualPet();


            //greet the user here
            Console.WriteLine("Hello, thank you for taking care of Ezra!");
            Console.WriteLine();

        
        int selectedOption;

            do
            {
                //these are the pet interactions
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("1. Feed the pet"); //decreases hunger
                Console.WriteLine("2. Train the pet"); //increases intelligence 
                Console.WriteLine("3. Give them water"); //decreases thirst
                Console.WriteLine("4. Play with them"); //decreases boredom
                Console.WriteLine("5. Tell the pet about your day"); //increases social need
                Console.WriteLine("6. Quit"); //ends the game
                Console.WriteLine();
                


                selectedOption = int.Parse(Console.ReadLine());

                myPet.MyPetStatus();

                switch (selectedOption)
                {
                    //when the user selects options, these switch cases change the stats
                    case 1:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding Ezra!");
                        break;
                    case 2:

                        myPet.IntelIncrease();
                        Console.WriteLine("Ezra can now do new tricks!");
                        break;
                    case 3:

                        myPet.ThirstDecrease();
                        Console.WriteLine("Thank you for keeping Ezra hydrated!");
                        break;
                    case 4:

                        myPet.BoredomDecrease();
                        Console.WriteLine("Wow, Ezra sure is having fun!");
                        break;
                    case 5:

                        myPet.SocialIncrease();
                        Console.WriteLine("Ezra certainly found your day interesting!");
                        break;
                    case 6:

                        Console.WriteLine("Come back any time! (^_^)\"/\"");
                        break;

                    default:

                        Console.WriteLine("Yikes! You chose to do nothing with that invalid option...");
                        break;
                }

                myPet.HungerIncrease();
                myPet.SocialDecrease();
                myPet.ThirstIncrease();
                myPet.BoredomIncrease();
                

            } while (selectedOption != 6);

        }
    }
}
