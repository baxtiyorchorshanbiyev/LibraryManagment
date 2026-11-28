namespace LibraryManagement.Models;

public sealed class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }
    public string Publisher { get; set; }
    public string PublicationMonth { get; set; }
    public override string TypeName => "Jurnal";
    public override int MaxLoanDays => 7;

    public Magazine(int id, string title, int publishedYear, int issueNumber,
        string publisher, string publicationMonth) : base(id, title, publishedYear)
    {
        this.IssueNumber = issueNumber;
        this.Publisher = publisher;
        this.PublicationMonth = publicationMonth;
    }

    public override string GetSummary()
    {
        return $"""
        {base.GetSummary()}
        ID: {Id}
        Jurnal soni: {IssueNumber}
        Nashriyot: {Publisher}
        Nashr oyi: {PublicationMonth}
        TypeName: {TypeName}
        MaxLoanDays: {MaxLoanDays}
        """;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(GetSummary());
    }
}
