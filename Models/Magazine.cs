using LibraryManagement.Common

namespace LibraryManagement.Models;

public sealed class Magazine:LibraryItem
{
    public int IssuNumber { get;set; }
    public string Publishedyear {get; set; }
    public string PublicationMonth {get; set; }
      
    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nomi: {Title}");
        Console.WriteLine($"Muallif: {Author}");
        Console.WriteLine($"Jurnal soni: {IssueNumber}");
        Console.WriteLine($"Nashriyot: {Publisher}");
        Console.WriteLine($"Nashr oyi: {PublicationMonth}");
    }
}