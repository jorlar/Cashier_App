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


    public decimal ShopBasket(List<Item> inputItems) 
    {
        decimal NewSum = 0;


        foreach (Item item in inputItems)
        {
            if (item.Price != 0 && item.KiloPrice == 0)
            {
                

            }

        }

        return 0;
    }
}


