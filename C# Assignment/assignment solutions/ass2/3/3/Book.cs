using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Book
    {
        string bname, id, author, price;

        public Book()
        {
            bname = id = author = price = "";
        }

        public Book(string b,string i,string a,string p)
        {
            bname = b;
            id = i;
            author = a;
            price = p;
        }

        public void display()
        {
            Console.WriteLine("---Book---\nname:"+bname+"\nId:"+id+"\nAuthor:"+ author+"\nPrice:"+price);
        }

        public string getbname()
        {
            return bname;
        }
        public string getid()
        {
            return id;
        }
        public string getauthor()
        {
            return author;
        }
        public string getprice()
        {
            return price;
        }

        public void setbname(string s)
        {
            bname=s;
        }
        public void setid(string i)
        {
            id=i;
        }
        public void setauthor(string a)
        {
            author = a;
        }
        public void setprice(string p)
        {
            price = p;
        }

        public static void Main()
        {
            Book b = new Book();
            b.setbname("3 mistakes");
            b.setid("1");
            b.setauthor("Chetan Bhagat");
            b.setprice("100");

            Console.WriteLine("\n---Book---\nname:"+b.getbname()+"\nId:"+b.getid()+"\nAuthor:"+b.getauthor()+"\nPrice:"+b.getprice());
            Console.ReadLine();
        }
    }
}
