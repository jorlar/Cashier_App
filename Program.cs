using System;
using System.Text;
using System.Linq;

class Program
{
    /// <summary>
    /// IDE for testmiljø
    /// </summary>
    /// <param name="args"></param>
    static void Main (string [] args)
    {
        RetailSystem system1 = new RetailSystem();

        system1.MyShoppingChart =new List<RetailSystem.Item> ();

        // PLU-koder for ItemList
        var Item1 = new RetailSystem.Item();
        Item1.Name = "Gummihansker";
        Item1.Price = (decimal)59.90;
        Item1.Count = 2;
        Item1.IsPair = true;
        Item1.KiloPrice = 0;
        Item1.PLU = "A";

        var Item2 = new RetailSystem.Item();
        Item2.Name = "Stetoskop";
        Item2.Price = 399;
        Item2.Count = 1;
        Item2.KiloPrice = 0;
        Item2.PLU = "B";

        var Item3 = new RetailSystem.Item();
        Item3.Name = "Talkum";
        Item3.Price = Item3.KiloPrice*Item3.Count;
        Item3.Count = 0; 
        Item3.KiloPrice = (decimal)(float)0.01954; // Fix tall ref kg
        Item3.PLU = "C";

        system1.MyShoppingChart.Add(Item1);
        system1.MyShoppingChart.Add(Item2);
        system1.MyShoppingChart.Add(Item3);

        system1.ShopBasket(system1.MyShoppingChart);
       
    }




}


