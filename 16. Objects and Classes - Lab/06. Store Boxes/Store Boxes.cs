// Define a class Item, which contains these properties: Name and Price.
// Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
// Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name}
// {Item Quantity} {itemPrice}"
// The Price of one box has to be calculated: itemQuantity * itemPrice.
// Print all the boxes ordered descending by price for a box, in the following format:
// {boxSerialNumber}
// -- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}
// -- ${boxPrice}
// The price should be formatted to the 2nd digit after the decimal separator.

namespace _06._Store_Boxes
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string boxesinput = Console.ReadLine();

            List<Box> boxes = new List<Box>();
            while (boxesinput != "end")
            {
                List<string> curentBoxs = boxesinput.Split(" ").ToList();
                
                string serialNum = curentBoxs[0];
                string name = curentBoxs[1];
                int itemQty = int.Parse(curentBoxs[2]);
                decimal price = decimal.Parse(curentBoxs[3]);

                Item items = new Item(name , price);
                Box box = new Box(serialNum, items, itemQty);
                boxes.Add(box);


                boxesinput = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(x=> x.PriceForBox).ToList();
            foreach (var boxxx in boxes)
            {
                Console.WriteLine(boxxx);
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox
        {
            get
            {
                return ItemQuantity * Item.Price;
            }

        }

        public override string ToString()
        {
            return $"{this.SerialNumber} \n-- {Item.Name} - ${Item.Price:f2}: {this.ItemQuantity}  \n-- ${PriceForBox:f2}";
        }
    }
}


