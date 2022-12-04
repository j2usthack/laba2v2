namespace AllStaffNet6.laba2;

public class Paper
{
    public string Title { get; set; }
    public Person Author { get; set; }
    public DateTime PublicationDate { get; set; }
    public Paper(string title, Person author, DateTime publicationDate)
    {
        Title = title;
        Author = author;
        PublicationDate = publicationDate;
    }
    public Paper()
    {
        Title = "Дорога: путь длинною в жизнь";
        Author = new();
        PublicationDate = new(2024, 8, 25, 11, 12, 13);
    }
    public string ToFullString() => $"Название: {Title}\n" +
        $"Автор:\n{Author.ToFullString()}\n" +
        $"Дата публикации: {PublicationDate:dd.MM.yyyy}";
}