
using Learn.Cs;

public class PatternMatching
{
    public static void  ProperyMatching()
    {
      var sample1 = new Author()
      {
         Name ="sakthivel",
         LastName = "Sainathan"
      };

     var sample2 = new Author()
     {
         Name ="sakthivei",
         LastName = "Sainathan"
     };

     var book1 = new Book() {
     AuthorInfo = sample1,
     BookName = "samplebook"
     };
     var book2 = new Book() {
     AuthorInfo = sample2,
     BookName = "samplebook"
     };
      Console.WriteLine(MatchFristName(book1));
      Console.WriteLine(MatchFristName(book2));
    }
    private static string MatchFristName(Book book)
    {
       return book switch
       {
         { AuthorInfo.Name: "sakthivel"} => "matched with firstName",
            _ => "default match"
       };
    }



}