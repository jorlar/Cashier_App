using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class RetailSystem
{

    public List<Item> MyShoppingChart { get; set; }
    public decimal Sum { get; set; }
    public string BasketInfo { get; set; }

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


    public void ShopBasket(string inputItem, int Antall)
    {
        if (MyShoppingChart == null)
        {
            MyShoppingChart = new List<Item>();
            Sum = 0;
        }

        BasketInfo = "";

        // Tilbuds regel Type A      
        
        if (inputItem == ("A"))
        {
            var ProduktACollection = from p in MyShoppingChart where p.Price != 0 && p.PLU == "A" select p; // Alle funn av Produkt A i collection
            var ProduktACollectionTilbud = from p in MyShoppingChart where p.Price == 0 && p.PLU == "A" select p; // Alle funn av Produkt A med sum 0,- i collection

            var Item = new RetailSystem.Item();
            Item.Name = "Gummihansker";

            BasketInfo += ProduktACollectionTilbud.Count();

            int AntallTilbud = 0;
            if (ProduktACollection.Count() >= 2)
            AntallTilbud = ((ProduktACollection.Count() / 2) - ProduktACollectionTilbud.Count());

            if (AntallTilbud > 0)
            {
                Item.Price = 0;
            }
            else
            {
                Item.Price = (decimal)59.90;
            }
            Item.Count = Antall;
            Item.IsPair = true;
            Item.KiloPrice = 0;
            Item.PLU = "A";
            MyShoppingChart.Add(Item);
        }

        // Tilbuds regel Type B        
     
        if (inputItem == ("B"))
        {
            var ProduktBCollection = from p in MyShoppingChart where p.Price != 333 && p.PLU == "B" select p; // Alle funn av Produkt B i collection

            var Item = new RetailSystem.Item();
            Item.Name = "Stetoskop";

            if (ProduktBCollection.Count() == 2 || ProduktBCollection.Count() / 3 > 0)
            {
                foreach (var olditem in ProduktBCollection)
                {
                    olditem.Price = 333;
                }
                Item.Price = 333;
            }
            else
            {
                Item.Price = 399;
            }
                Item.Count = Antall;
                Item.KiloPrice = 0;
                Item.PLU = "B";
                MyShoppingChart.Add(Item);
            }

        // Utregning for produkt C med omgjort kilopris til gram

            if (inputItem == ("C"))
            {
                var Item = new RetailSystem.Item();
                Item.Count = Antall;
                Item.Name = "Talkum Gram: ";
                Item.KiloPrice = (decimal)0.01954; // KG-pris skrevet om til pris pr. Gram                
                Item.PLU = "C";
                Item.Price = Item.KiloPrice; // kr
                MyShoppingChart.Add(Item);
            }

        BasketInfo += "\n\n";

            // Summering av MyShoppingChart
            Sum = 0;
            foreach (Item item in MyShoppingChart)
            {
                BasketInfo += "- " + item.Name + "("+item.Count+") Pris: " + (item.Price*item.Count).ToString("N2") + ",-   \n\n";
                Sum += (int)(item.Price * item.Count);
            }


            BasketInfo += "\n\n";

            // Output Sum 
            BasketInfo += "Du har nå " + MyShoppingChart.Count() + " gjenstander. Med sum: " +
                Sum.ToString("N2");


        }
    }


