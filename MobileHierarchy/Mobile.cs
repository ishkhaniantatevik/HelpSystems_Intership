using System;

namespace MobileHierarchy
{
    public abstract class Mobile
    {
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string Number { get; set; }

        public abstract void Display();
       public abstract void TakePhoto();

       public void Call()
       {
           Console.WriteLine("Calling...");
       }
       

    }
}
