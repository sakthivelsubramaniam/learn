namespace Learn.Cs;

public class Book
{

    public Book()
    {
       BookName = string.Empty;
       AuthorInfo = new Author();
    }

    public string BookName { get; set; }
    public Author AuthorInfo { get; set; }
}