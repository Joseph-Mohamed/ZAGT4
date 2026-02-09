using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAGSESSION_1
{
    internal class Magazine(string title, string ID) : LibraryItem(title, ID)
    {
        
        public int IssueNumber {  get; set; }
        public string Publisher { get; set; }
        public Magazine(string title, string ID, string author, int pages , int issueNumber , string publ) : this(title, ID)
        {
            IssueNumber = issueNumber;
            Publisher = publ;
        }
        public override void DisplayInfo()
        {
            this.DisplayInfo();
            Console.WriteLine($"\n{IssueNumber}\n{Publisher}");
        }
    }
}
