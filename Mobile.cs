using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        public abstract class Mobile
        {
            public int SIMcount { get; protected set; }
            public string processor { get; protected set; }
            public string firstMobile { get; protected set; }
            public string manufacturerCountry { get; protected set; }
            public string price { get; protected set; }
            public string weightInGrams { get; protected set; }
            public string OS { get; protected set; }
            public int backCameraCount { get; protected set; }
            public int frontCameraCount { get; protected set; }
            public string RAM { get; protected set; }

            public virtual bool IsThereFrontCamera()
            {
                Console.WriteLine("mobile function");
                return frontCameraCount == 1;
            }
            public virtual bool IsThereTwoSimCarts() => SIMcount == 2;

        }
    }
