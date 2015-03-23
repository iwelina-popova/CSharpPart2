using System;

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.

class Strings
{
    static void Main()
    {
        /* In C#, you can use strings as array of characters, however, more common practice is to use the string keyword to declare a string variable. 
         * The string keyword is an alias for the System.String class. The string type allows us to test and manipulate character data.
         * The string type represents a sequence of zero or more Unicode characters. string is an alias for String in the .NET Framework.
           Although string is a reference type, the equality operators (== and !=) are defined to compare the values of string objects, 
         * not references. This makes testing for string equality more intuitive.
         */
 
        string testString = "";
        string otherTest = "";
        int number = 5;

        string.Compare(testString, otherTest);  //  checks if one string is ordered before another when in alphabetical order, 
                                                //   whether it is ordered after, or is equivalent

        string.Copy(testString);  //  Creates a new instance of String with the same value as a specified String.

        string.Equals(testString, otherTest); // Determines whether this instance and another specified String object have the same value.

        testString.IndexOf('b');  //  Reports the zero-based index of the first occurrence of the specified Unicode character in this string.

        string.Join(",", testString); //  combines many strings into one.

        testString.Split(',');  //  Returns a string array that contains the substrings in this instance that are delimited by elements 
                                //  of a specified Unicode character array.

        number.ToString();  // Returns this instance of String; no actual conversion is performed.


        // And more....
    }
}
