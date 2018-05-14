using System;

namespace NullableReferenceTypesDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      // Tuple fix 7.3
      var areEqual = (10, "abc") == (10, "abc"); // False in the old version!
      areEqual.ToString();

      string? nullableString = "Fadi"; // Fadi to null will
      Console.WriteLine(nullableString.Length);     // WARNING: may be null

      if (nullableString != null)
      {
        Console.WriteLine(nullableString.Length);   // Ok, not null here 
      }

      if (nullableString == null)
      {
        Console.WriteLine(nullableString?.Length);     // No WARNING: ? Opreator
      }

      Person person = new Person();

      // Null Exception old style no warning!
      // var name = person.Name.ToString();

      string? userName = null;
      person.Name = userName;

      // This line will removes the warning! the compiler ist smart!
      // person.NullableName = "Rami";

      // Null Exception with null warning!
      var name = person.NullableName.ToString();

      // Error suppress
      //var nameWithErrorSuppress = person.NullableName!.ToString();

      Person secondPerson = null;
      // Not possible to use a null
      // secondPerson.Name;

      Person? personNullable = null;

      // Possible to use 
      var nullFromNullable = personNullable?.ToString();
    }
  }
}