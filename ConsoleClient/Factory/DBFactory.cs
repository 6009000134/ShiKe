using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient.Factory
{
    public class DBFactory
    {
        public string GetCarName(string car)
        {
            if (car.ToUpper() == "CAR")
            {
                Car c = new Car();
                return c.GetCarName();
            }
            else
            {
                Suv s = new Suv();
                return s.GetCarName();
            }
        }
    }
}
