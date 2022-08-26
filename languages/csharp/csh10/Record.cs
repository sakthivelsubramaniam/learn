// ##Points to note
// Records introduced in C# 9
// Notion of equality of records is diff from class. Class Objects are equal when they refer same object in memory.
//    Two records are equal when they are of same type and have same value. For this reason record type is not used in 
//    Entity framework
namespace Learn.Cs;


// creating the  record type using positional syntax
// creates a immutable data type
public record Person(string FirstName, string LastName, string[] PhoneNumbers);
public  readonly record struct Point(int i, int j, int z);

public class RecordTest
{
   public static void TestRecords()
   {
         Console.WriteLine("Records type");
         Record_RefernceType();
         ReadonlyRecordStruct();
   }

   public static void Record_RefernceType()
   {
      var phoneNumbers = new string[2];
      var person = new Person("Sam", "Peters",phoneNumbers);
      Console.WriteLine(person);

   // Equality
      var person1 = new Person("Sam", "Peters",phoneNumbers);
      Console.WriteLine("Test Equality");
      Console.WriteLine(person == person1);
      Console.WriteLine(ReferenceEquals(person, person1)); // output: False

   // non destructive mutation
   // It is shallow copied
      var person2 = person1 with { LastName = "Chris"};
      Console.WriteLine(person2);
   }

   public static void ReadonlyRecordStruct()
   {
      var point = new Point(10,3,4);
      Console.WriteLine(point);
   }
}