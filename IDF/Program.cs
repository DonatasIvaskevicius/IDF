using System;

namespace IDF
{
    class Program
    {
        static void Main(string[] args)
        {
            IWaterTank WaterTank = new WaterTank();
            IMill Mill = new Mill();
            IBeanContainer BeanContainer = new BeanContainer();
            ICoffeePowderProvider CoffeePowderProvider = new CoffeePowderProvider(BeanContainer, Mill);
            ICoffeeMachine CoffeeMachine = new CoffeeMachine(WaterTank,CoffeePowderProvider);

            CoffeeMachine.MakingCoffee();
            

            
        }
    }
}
