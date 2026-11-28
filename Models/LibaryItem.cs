using LibraryManagement.Common;

namespace LibraryManagement.Models;

public abstract class LibraryItem : IDisplayable
{
    public int Id { get; }
    public string Title { get; private set; }
    public int PublishedYear { get; private set; }
    public bool IsAvailable { get; private set; }
    public abstract string TypeName { get; }
    public abstract int MaxLoanDays { get; }
    public virtual decimal DailyFine { get; } = 1000;

    protected LibraryItem(int id, string title, int publishedYear)
    {
        this.Id = id;
        this.SetTitle(title);
        this.SetPublishedYear(publishedYear);
    }

    public virtual string GetSummary()
    {
        return $"""
        Umumuy ma'lumot: {Title},
        Published Year - {PublishedYear}
        """;
    }

    public void UpdateInfo(string title, int publishedYear)
    {
        this.SetTitle(title);
        this.SetPublishedYear(publishedYear);

    }

    private void SetTitle(string title)
    {
        if (!string.IsNullOrWhiteSpace(title))
        {
            this.Title = title;

        }
    }
    private void SetPublishedYear(int publishedYear)
    {
        if (publishedYear > 0 && publishedYear <= 3000)
        {
            this.PublishedYear = publishedYear;
        }
    }

    public void MarkAsBorrowed()
    {
        this.IsAvailable = false;
    }
    public void MarkAsReturned()
    {
        this.IsAvailable = true;
    }
    
    public abstract void DisplayInfo();
}
