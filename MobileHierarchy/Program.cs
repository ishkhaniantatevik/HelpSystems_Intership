
using System;

namespace MobileHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile Iphone9 = new Iphone();
            Iphone9.Display();
            Iphone9.Call();
            Iphone9.TakePhoto();
            
            Mobile RedmiNote95 = new Xiaomi();
            RedmiNote95.Display();
            RedmiNote95.Call();
            RedmiNote95.TakePhoto();
            
            Mobile NokiaX6 = new Nokia();
            NokiaX6.Display();
            NokiaX6.Call();
            NokiaX6.TakePhoto();
            
        }
    }
}
