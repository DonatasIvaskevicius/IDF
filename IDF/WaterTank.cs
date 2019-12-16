using System;
using System.Collections.Generic;
using System.Text;

namespace IDF
{
    public class WaterTank : IWaterTank
    {
        public void getWater()
        {
            Console.WriteLine("Filling up the water tank");
        }

    }
}
