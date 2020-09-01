using System;

namespace MobileHierarchy
{
    public abstract class Mobile
    {
       public abstract void Display();
       public abstract void TakePhoto();

       public void Call()
       {
           Console.WriteLine("Calling...");
       }
       

    }
}
