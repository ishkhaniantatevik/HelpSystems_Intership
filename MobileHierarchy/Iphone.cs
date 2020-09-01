using System;

namespace MobileHierarchy
{
    public class Iphone : Mobile
    {
        public override void Display()
        {
            Console.WriteLine("Showing Iphone Display!!!");
        }

        public override void TakePhoto()
        {
            Console.WriteLine("Taking a photo with Iphone!!!");
        }
    }
}
