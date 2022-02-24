using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class RetailSystem
{

    public List<Item> MyShoppingChart { get; set; }
    public decimal Sum { get; set; }

    public class Item
    {

        // navn på produkt
        public string Name { get; set; }
        // PLU for produkt
        public string PLU { get; set; }
        // Pris på produkt
        public decimal Price { get; set; }
        // Kilopris for produkt
        public decimal KiloPrice { get; set; }
        // Antall produkter i samling 
        public int Count { get; set; }
        // Er det par
        public bool IsPair { get; set; }

    }


    public List<Item>[] ShopBasket(List<Item> inputItems) 
    {
        decimal NewSum = 0;
        List<Item> Hansker = new List<Item>();
        List<Item> Stetoskop = new List<Item>();
        List<Item> Talkum = new List<Item>();



        foreach (Item item in inputItems)
        {
            Console.WriteLine("Tast inn valg av vare: ");
            //Console.ReadLine();
            if (item.PLU == "A")
            {
                Hansker.Add(item);
                NewSum = NewSum + item.Price;
            }
            else if (item.PLU == "B")
            {
                Stetoskop.Add(item);
                NewSum = NewSum + item.Price;
            }
            else if (item.PLU == "C")
            {
                Talkum.Add(item);
                Console.WriteLine("Hvor mange gram Talkum ønsker du?");
                Console.ReadLine();
                NewSum = NewSum + item.Price;
            } else
            {
                Console.WriteLine("Din sum er: "+NewSum);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
        
        //Console.WriteLine(NewSum);
        return null;
    }
}


