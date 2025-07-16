namespace ASS.Classes;

internal class PrintedBook : Book
{
    public int PageCount { get; set; }

    public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
    {
        PageCount = pageCount;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Page Count: {PageCount}");
    }
}
