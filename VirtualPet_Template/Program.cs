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
            //this is how we instantiate a new instance of our pet
            VirtualPet myPet = new VirtualPet();


            //TODO add a greeting for the user. you can also let the user name the pet if you like

            int selectedOption;

            do
            {
                //TODO fill this out with more options to interact with the pet
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed the pet"); //decreases hunger
                Console.WriteLine("2. Train the pet"); //increases intelligence 
                Console.WriteLine("3. Give them water"); //decreases thirst
                Console.WriteLine("4. Play with them"); //decreases boredom
                Console.WriteLine("5. Tell the pet about your day"); //increases social need
                Console.WriteLine("6. Quit"); //ends the game
                


                selectedOption = int.Parse(Console.ReadLine());

                myPet.MyPetStatus();

                switch (selectedOption)
                {
                    //when the user selects option one we feed the pet
                    case 1:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding the pet");
                        break;
                    case 2:

                        myPet.IntelIncrease();
                        Console.WriteLine("Your pet can now do new tricks!");
                        break;
                    case 3:

                        myPet.ThirstDecrease();
                        Console.WriteLine("Thank you for keeping them hydrated!");
                        break;
                    case 4:

                        myPet.BoredomeDecrease();
                        Console.WriteLine("Wow, your pet sure is having fun");
                        break;
                    case 5:

                        myPet.SocialIncrease();
                        Console.WriteLine("They certainly found your day interesting!");
                        break;
                    case 6:

                        Console.WriteLine("Thank you for playing.");
                        break;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                //TODO We can put method calls here so the pet can have some values change automatically
                //Feel free to add, remove, or modify which methods are called here
                myPet.HungerIncrease();

            } while (selectedOption != 6);

        }
    }
}
