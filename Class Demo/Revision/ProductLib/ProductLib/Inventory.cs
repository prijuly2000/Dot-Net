using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductLib
{
   public class Inventory
    {
        Item[] allItems;
        public Inventory(int size)
        {
            allItems = new Item[size];
        }
        public Item this[int index]
        {
            get
            {
                return allItems[index];
            }
            set
            {
                allItems[index] = value;
            }
        }
        public override string ToString()
        {

            string str = "";
            foreach (Item i in allItems)
            {
                str += i.ToString();
            }
            return str;
        }
    }
}
