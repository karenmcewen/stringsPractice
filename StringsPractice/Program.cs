using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string example 1 - create a variable string
            //default string is null, which is not the same as empty - computer doesn't like null values
            /*   
               string firstName = "Karen";
               string lastName = "McEwen";
               //string fullName = firstName + " " + lastName;
               //another way to concatenate strings

       string fullName = string.Concat(firstName, " ", lastName);
               Console.WriteLine(fullName);

               Console.WriteLine(firstName.Length);
               Console.WriteLine(lastName.Length);
               Console.WriteLine(firstName[0]);//prints the first letter
               Console.WriteLine(firstName[firstName.Length - 1]);//prints the last letter because index numbering begins at 0
                  Console.WriteLine("my favorite book is the \"Notebook\".");

               //there are lots of things that are built in to do with strings-they follow the dot character
               Console.WriteLine(firstName.Equals(lastName));
               Console.WriteLine(firstName == lastName); //this does exactly the same thing

 
            //if you want to print actual quotation marks within a string, need to use escape characters (backslash)
            // backslash n \n goes to next line
            // backslash a \a makes a bell sound

            string sampleString = "This is a SIMPLE sample string";
            Console.WriteLine("Original string: " + sampleString);
            Console.WriteLine("ToUpper string: " + sampleString.ToUpper());
            Console.WriteLine("ToLower string: " + sampleString.ToLower());

            string newString = sampleString.Replace("SIMPLE", "longer");
            Console.WriteLine("Let's replace a word: " + newString);

            //substring takes part of the string (where to start, how long)
            string example = "onetwothree";
            string sub = example.Substring(3, 8);
            Console.WriteLine(sub);

            //remove some characters???
            string exampleRemove = example.Remove(3);
            Console.WriteLine(exampleRemove);

            //indexof - finds the first occurrence of a char and lastindexof - shows the last - these are case sensitive!
            //string indexString = sampleString.IndexOf(6);
            // Console.WriteLine("the first occurrence of the letter a is at index " +);
                  */

            /*
             Example -  .Length Property

            Find the length of your first name and print it.
            Find the length of your last name and print it.
            If the first name is longer than the last name, print "First is longer."
            If the first name and last name are the same length, print "Samsis!"
            Otherwise, print "last must be longer!"
            EXTENSION: Get user input for the first and last name instead of hardcoding, such as string fName = "Mary";
            */
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            int firstNameLength = firstName.Length;
            Console.WriteLine("Length of the first name is " + firstNameLength);

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            int lastNameLength = lastName.Length;
            Console.WriteLine("Length of the last name is " + lastNameLength);

            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("First name is longer");

            }
           
            else if (firstNameLength == lastNameLength)
            {
                Console.WriteLine("Samesis!");
            }

            else
            {
                Console.WriteLine("Last name is longer!");
            }


            /*
             Example - Escaping Special Characters
                Using the escape sequences for tab, backslash, new line, and bell sound, 
                print this result using only ONE Console.WriteLine(...). 
                \t tab
                \n new line
                \\ backslash
                \a bell sound

               */

            Console.WriteLine("This is a tab \t. \nThis is a backspace \\ \nand this is a bell sound \a");

            /*
             Example - Comparing Strings for Equality *First try the following using == and then try it using .Equals()

Create a variable and assign a person's first name to it.
Create a variable and assign a different person's first name to it.
If the two names are the same, print "The names are the same."
If they're not the same, print "The names are different."

            
            Example - Concatenation 
            *First try the following using + and then try it using .Equals()

Ask the user for his/her first name.
Ask the user for his/her last name.
Using concatenation, print the user's full name including a space to separate the names.

            
            Example - String Methods

Ask the user to guess the type of pet (Hint to the user it's the opposite of a dog)
Assign an answer variable to the answer of cat.
If they guess cat correctly, print "You guessed correctly!"
If they guess incorrectly, print "You guessed incorrectly..."
Use the ToLower() or ToUpper() methods to ensure if they enter cat or CAT or Cat, it will be correct.
*/

        }
    }
}
