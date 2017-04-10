using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        //
        private string name;
        private int hunger;
        private int intel;
        private int thirst;
        private int boredom;
        private int social;


        public VirtualPet()
        {
            this.name = "Ezra";
            this.hunger = 20;
            this.intel = 10;
            this.thirst = 20;
            this.boredom = 40;
            this.social = 30;
        }

        public VirtualPet(string name, int hunger, int sick, int boredom, int thirst, int intel, int social)
        {
            this.name = name;
        }


        
        //this method can be called to increase the hunger
        public void HungerIncrease()
        {
            this.hunger = hunger + 5;
        }
        //this method can be called to decrease the hunger
        public void HungerDecrease()
        {   
            this.hunger = hunger - 6;
        }
        //this method is called to raise intelligence
        public void IntelIncrease()
        {
            this.intel = intel + 8;
        }
        //this method is called to lower intelligence
        public void IntelDecrease()
        {
            this.hunger = intel - 3;
        }
        //this method, when called, raises thirst 
        public void ThirstIncrease()
        {
            this.thirst = thirst + 5;
        }
        //this method, when called, lowers thirst
        public void ThirstDecrease()
        {
            this.thirst = thirst - 8;
        }
        //this method increases boredom
        public void BoredomIncrease()
        {
            this.boredom = boredom + 8;
        }
        //this method lowers boredom
        public void BoredomDecrease()
        {
            this.boredom = boredom - 10;
        }
        //increase the pet's socialization by calling this method
        public void SocialIncrease()
        {
            this.social = social + 7;
        }
        //decrease the pet's socialization by calling this method
        public void SocialDecrease()
        {
            this.social = social - 3;
        }

        //TODO we need to add more methods to modify the other fields


        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine();
            Console.WriteLine("Let's take a look at Ezra's stats!");
            Console.WriteLine();
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Intelligence: " + intel);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Social: " + social);
            Console.WriteLine();
            //TODO account for more fields
        }
    }
}
