namespace ZAGSESSION_1
{
    internal class LibraryItem
    {
        public string Title { get; set; }
        public string ItemId { get; set; }
        public LibraryItem(string title, string ID)
        {
            Title = title;
            ItemId = ID;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Title}\n{ItemId}");
        }
    }
}
