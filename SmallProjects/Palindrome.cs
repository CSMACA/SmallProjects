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

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("Racecar"));
        Console.ReadKey();
    }
}