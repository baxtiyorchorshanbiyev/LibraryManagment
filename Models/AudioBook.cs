namespace LibraryManagement.Models;

public sealed class AudioBook : LibraryItem
{
    public string Author { get; set; }
    public int DurationMinutes { get; set; }
    public string Narrator { get; set; }
    public string AudioFormat { get; set; }
    public override string TypeName => "Audiokitob";
    public override int MaxLoanDays => 14;

    public AudioBook(int id, string title, int publishedYear, string author,
        int durationMinutes, string narrator, string audioFormat) : base(id, title, publishedYear)
    {
        this.Author = author;
        this.DurationMinutes = durationMinutes;
        this.Narrator = narrator;
        this.AudioFormat = audioFormat;
    }

    public override string GetSummary()
    {
        return $"""
        {base.GetSummary()}
        ID: {Id}
        Muallif: {Author}
        Davomiyligi: {DurationMinutes} minut
        Ovozlashtiruvchi: {Narrator}
        Format: {AudioFormat}
        TypeName: {TypeName}
        MaxLoanDays: {MaxLoanDays}
        """;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(GetSummary());
    }
}
