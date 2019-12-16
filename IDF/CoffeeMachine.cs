using System;
using System.Collections.Generic;
using System.Text;

namespace IDF
{

    public class CoffeeMachine : ICoffeeMachine
    {
        private IWaterTank _waterTank;
        private ICoffeePowderProvider _coffeePowderProvider;
        public CoffeeMachine(IWaterTank waterTank, ICoffeePowderProvider coffeePowderProvider)
        {
            _waterTank = waterTank;
            _coffeePowderProvider = coffeePowderProvider;
        }

        public void MakingCoffee()
        {
            Console.WriteLine("Starting to make Coffee");
            _waterTank.getWater();
            _coffeePowderProvider.gettingPowder();


        }
    }
}
