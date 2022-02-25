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


        // PLU-koder for ItemList

        Console.WriteLine("Start handel ved å trykke Enter");

        while (true)
        {

            ConsoleKeyInfo cki = Console.ReadKey(true);

            string InputKeyInfoString = $"{cki.Key}";

            system1.ShopBasket(InputKeyInfoString);
            Console.WriteLine(InputKeyInfoString);
            Console.WriteLine(system1.BasketInfo);

        }          

        
    } 



}


