using System;
using System.Net;
using System.IO;
using System.Text.Json;

namespace MobileHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string JsonFileName = "Mobile.txt";
            Mobile Iphone9 = new Iphone()
            {
                OwnerFirstName = "Tatevik",
                OwnerLastName = "Ishkhanyan",
                Number = "123456789"
                
            };
            SaveAsJsonFormat(Iphone9, JsonFileName);
            
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

        public static void SaveAsJsonFormat(object objGraph, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(objGraph);
            File.WriteAllText(fileName,jsonString);
            Console.WriteLine();
            Console.WriteLine("Saved a Mobile With JSON Format");
            
        }
    }
    
   
}
