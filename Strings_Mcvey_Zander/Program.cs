using System;

namespace Strings_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input a character then would input the character to a variable
            Console.WriteLine("Please input a character");
            char myChar = Console.ReadKey().KeyChar;

            // Checks if the character the user inputted is entered
            bool isLetter = Char.IsLetter(myChar);

            // Prints the results to console
            Console.WriteLine($"\n {myChar} is a letter: {isLetter}.");

            Console.WriteLine("Why do you like video games?");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            bool isIn = sentence.Contains(word);

            Console.WriteLine($"{word} exists in {sentence}, {isIn}!");

        }
    }
}
