using System;
using System.Collections.Generic;
using System.Text;

namespace IDF
{
    public class CoffeePowderProvider : ICoffeePowderProvider
    {
        private readonly IBeanContainer _beanContainer;
        private readonly IMill _mill;


        public CoffeePowderProvider(IBeanContainer beanContainer, IMill mill)
        {
            _beanContainer = beanContainer;
            _mill = mill;
        }
        public void gettingPowder()
        {
            Console.WriteLine("Getting Powder");
            _beanContainer.getBeans();
            _mill.grind();
            Console.WriteLine("Pouring coffee");
            Console.WriteLine("Take your cup.");

        }


    }
}
