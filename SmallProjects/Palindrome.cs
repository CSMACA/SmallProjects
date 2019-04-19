using System;

public class Palindrome
{
    /// <summary>
    /// Reverses the given string.
    /// </summary>
    /// <param name="word"> Contains the word to be reversed.</param>
    /// <returns></returns>
    public static string ReverseString(string word)
    {
        
        string reversedWord = "";

        foreach (char c in word)
        {
            reversedWord = c + reversedWord;
        }

        return reversedWord;
    }
    /// <summary>
    /// Checks to see if the given word is a palindrome.
    /// </summary>
    /// <param name="word"> Contains the string that is to be checked. </param>
    /// <returns></returns>
    public static bool IsPalindrome(string word)
    {
        word = word.ToLower();
        string wordReversed = ReverseString(word);

        return (word == wordReversed);
    }

    public static string input()
    {
        string str;
        Console.WriteLine("Enter word to check if it is a palindrome:");
        str = Console.ReadLine();
        return str;
    }

    public static void Main(string[] args)
    {
        bool rerun = true;
        do
        {
            string word = input();
            Console.WriteLine(IsPalindrome(word));
            Console.WriteLine("Would you like to go again? (Y/n)");
            if (Console.ReadLine() == "n")
            {
                rerun = false;
            }
            Console.Clear();
        } while (rerun);
    }
}