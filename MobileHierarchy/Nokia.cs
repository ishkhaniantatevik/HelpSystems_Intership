using System;

namespace MobileHierarchy
{
    public class Nokia : Mobile
    {
        public override void Display()
        {
            Console.WriteLine("Showing Nokia Display!!!");
        }

        public override void TakePhoto()
        {
            Console.WriteLine("Taking a photo with Nokia!!!");
        }
    }
}
