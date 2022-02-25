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


    public void ShopBasket(string inputItem)
    {
        if (MyShoppingChart == null)
        {
            MyShoppingChart = new List<Item>();
            Sum = 0;
        }

        BasketInfo = "";

        // Tilbuds regel Type A
        var ProduktACollection = from p in MyShoppingChart where p.Price != 0 && p.PLU == "A" select p; // Alle funn av Produkt A i collectin
        var ProduktACollectionTilbud = from p in MyShoppingChart where p.Price == 0 && p.PLU == "A" select p; // Alle funn av Produkt A i collectin

        if (inputItem == ("A"))
        {
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
            Item.Count = 1;
            Item.IsPair = true;
            Item.KiloPrice = 0;
            Item.PLU = "A";
            MyShoppingChart.Add(Item);
        }

        // Tilbuds regel Type B
        var ProduktBCollection = from p in MyShoppingChart where p.Price != 0 && p.PLU == "B" select p; // Alle funn av Produkt B i collection
        var ProduktBCollectionTilbud = from p in MyShoppingChart where p.Price == 999 && p.PLU == "B" select p; // Alle funn av Produkt B i collection

        int AntallTilbudB = 0;
        if (inputItem == ("B"))
        {
            var Item = new RetailSystem.Item();
            Item.Name = "Stetoskop";

            BasketInfo += ProduktBCollectionTilbud.Count();

            if (ProduktBCollection.Count() == 3)
                AntallTilbudB = ((ProduktBCollection.Count()) - ProduktBCollectionTilbud.Count());

            if (AntallTilbudB > 0)
            {
                Item.Price = 999;
            }
            else
            {
                Item.Price = 399;
            }
                Item.Count = 1;
                Item.KiloPrice = 0;
                Item.PLU = "B";
                MyShoppingChart.Add(Item);
            }


            if (inputItem == ("C"))
            {
                var Item = new RetailSystem.Item();
                Item.Name = "Talkum";
                Item.KiloPrice = (decimal)(float)0.01954; // KG-pris skrevet om til pris pr. Gram
                Item.Price = Item.KiloPrice * Item.Count;
                Item.Count = 0;
                Item.PLU = "C";
                MyShoppingChart.Add(Item);
            }





            //int AntalProdukterMedRabatt = 0;  

            //if (ProduktACollection.Count() > 2)
            //{
            //    AntalProdukterMedRabatt = (ProduktACollection.Count()/2);
            //}


            //BasketInfo = "\n\n Antall Gjenstander tilbud: " + AntalProdukterMedRabatt;
            //BasketInfo += "\n\n"; 

            //foreach (Item item in ProduktACollection)
            //{            

            //    if (AntalProdukterMedRabatt >= 1)
            //    {
            //        AntalProdukterMedRabatt -= (ProduktACollection.Count()/2);
            //        item.Price = 0;               
            //    }
            //    else
            //    {
            //        AntalProdukterMedRabatt = 0;
            //    }
            //}
            //


            BasketInfo += "\n\n";

            // Summering
            Sum = 0;
            foreach (Item item in MyShoppingChart)
            {
                BasketInfo += "- " + item.Name + " Pris: " + item.Price + ",-   \n\n";
                Sum += item.Price * item.Count;
            }


            BasketInfo += "\n\n";

            BasketInfo += "Du har nå " + MyShoppingChart.Count() + " gjenstander. Med sum: " +
                Sum.ToString("N2");


        }
    }


