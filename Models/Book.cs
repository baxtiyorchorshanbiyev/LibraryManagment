namespace LibraryManagement.Models;

public class Book : LibraryItem
{
    public string Author { get; private set; }
    public int PageCount { get; private set; }
    public override string TypeName => "Kitob";
    public override int MaxLoanDays => 14;

    public Book(int id, string title, int publishedYear, string author, int pageCount) : base(id, title, publishedYear)
    {
        this.Author = author;
        this.PageCount = pageCount;
    }

    public override string GetSummary()
    {
        return
        $"""
        {base.GetSummary()}
        Author: {Author}, 
        PageCount: {PageCount},
        TypeName: {TypeName}
        MaxLoanDays: {MaxLoanDays}
        """;
    }
}