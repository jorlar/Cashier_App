using System;
using System.Text;

class Program
{
    /// <summary>
    /// IDE for testmiljø
    /// </summary>
    /// <param name="args"></param>
    /// 



    static void Main(string[] args)
    {
        RetailSystem system1 = new RetailSystem();

        Random random = new Random();
        int Antall = 0;

        // While-løkke for handlekurv
        Console.WriteLine("Start handel ved å trykke Enter");

        while (true)
        {

            ConsoleKeyInfo cki = Console.ReadKey(true);

            string InputKeyInfoString = $"{cki.Key}";

            /* Unntaksregel for PLU C med random av gram 
            minstevalør = 52 gram av hensyn til krav om 1 øre. Max valør 1000 gram
            av hensyn til KG-pris */

            if (InputKeyInfoString != "C")
            {
                Antall = 1;
            }
            else if (InputKeyInfoString == "C")
            {
                Antall = random.Next(52, 1000);
            }

            system1.ShopBasket(InputKeyInfoString, Antall);


            // Output av Handlekurv i console
            Console.WriteLine(system1.BasketInfo);
        }
    }



}


