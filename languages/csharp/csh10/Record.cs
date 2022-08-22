
namespace Learn.Cs;

// creating the  record type using positional syntax
// creates a immutable data type
public record Person(string Name, string LastName);

public class RecordTest
{
   public static void TestRecords()
   {
        var person = new Person("Sam", "Peters");
        Console.WriteLine(person);
   }
}