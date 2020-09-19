using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Apple : Mobile
    {

        public string color { get; protected set; }
        public Apple()
        {
            manufacturerCountry = "Cupertino, USA";
            firstMobile = "Iphone 1";
            backCameraCount = 1;
            frontCameraCount = 1;
            SIMcount = 1;
            color = "red,white,green,yellow,red,black,purple";
        }
        public virtual void print()
        {
            Console.WriteLine("Apple");
            Console.WriteLine($"Manufacturer Country: {manufacturerCountry}\nfirstMobile: {firstMobile}");
            Console.WriteLine();
        }

    }
}
