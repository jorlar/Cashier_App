using System;
using System.Text;
using System.Linq;

class Program
{
    /// <summary>
    /// IDE for testmiljø
    /// </summary>
    /// <param name="args"></param>
    /// 



    static void Main (string [] args)
    {
        RetailSystem system1 = new RetailSystem();   

        Random random = new Random();
        int Antall = 0;


        Console.WriteLine("Start handel ved å trykke Enter");

        while (true)
        {

            ConsoleKeyInfo cki = Console.ReadKey(true);
            
            string InputKeyInfoString = $"{cki.Key}";

         
            if (InputKeyInfoString != "C")
            {
                Antall = 1;
            }
            else if (InputKeyInfoString == "C")
            {
                Antall = random.Next(52, 1000);
            }


            system1.ShopBasket(InputKeyInfoString, Antall);

            Console.WriteLine(InputKeyInfoString);
            Console.WriteLine(system1.BasketInfo);

        }          

        
    } 



}


