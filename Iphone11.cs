using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Iphone11 : Apple
    {
        public string releaseDate { get; private set; }
        public string name { get; private set; }
        public Iphone11()
        {
            name = "Iphone11";
            SIMcount = 2;
            processor = "A13 Bionic";
            price = "800 EUR";
            weightInGrams = "194 gram";
            OS = "IOS 13";
            releaseDate = "10.08.2019";
            backCameraCount = 2;
            frontCameraCount = 1;
            RAM = "4 GB";
        }
        public Iphone11(string color) : this()
        {
            this.color = color;
        }
        public override bool IsThereFrontCamera()
        {
            Console.WriteLine("overrided iphone11 function");
            return true;
        }
        public override bool IsThereTwoSimCarts() => true;
        public override void print()
        {
            Console.WriteLine("overrided iphone11 function");
            Console.WriteLine($"Name:{name}\nSIM count: {SIMcount}\nprocessor: {processor}\nprice: {price}\nweigth: {weightInGrams}\nOS: {OS}\nRelease date: {releaseDate}\nBack Camera Count: {backCameraCount}\nFront Camera Count: {frontCameraCount}\nRAM:{RAM}\nColor: {color}");
        }
    }
}
