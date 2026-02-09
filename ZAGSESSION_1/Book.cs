using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAGSESSION_1
{
    internal class Book(string title,string ID) :LibraryItem(title,ID)
    {
        public string Authour {  get; set; }
        public int Pages { get; set; }
        public Book(string title, string ID , string author , int pages):this(title,ID)
        {
            Authour = author;
            Pages = pages;
        }
        public override void DisplayInfo()
        {
           base.DisplayInfo();
            Console.WriteLine($"\n{Authour}\n{Pages}");
        }
    }
}
