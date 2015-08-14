using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductLib
{
    public class Item
    {
        int id;
        string itemName;
        double price;
        public Item()
        {
            id = 0;
            itemName = "";
            price = 0;
        }
        public Item(int i,string nm,double p)
        {
            id = i;
            itemName = nm;
            price = p;
        }
        public override string ToString()
        {
            return "Id="+id+"\tName="+itemName+"\tPrice="+price;
        }
    }
}
