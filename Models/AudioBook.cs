public sealed class AudioBook : LibraryItem
{
    public int DurationMinutes { get; set; }
    public string Narrator { get; set; }
    public string AudioFormat { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nomi: {Title}");
        Console.WriteLine($"Muallif: {Author}");
        Console.WriteLine($"Davomiyligi: {DurationMinutes} minut");
        Console.WriteLine($"Ovozlashtiruvchi: {Narrator}");
        Console.WriteLine($"Format: {AudioFormat}");
    }
}