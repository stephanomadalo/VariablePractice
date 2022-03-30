using System;

namespace variablePracticeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string myName;
            bool isAlive;
            char favoriteLetter;
            double favoriteNumber;
            decimal bankAccountAmount;

            age = 22;
            myName = "auugggh";
            isAlive = false;
            favoriteLetter = 'S';
            favoriteNumber = 9;
            bankAccountAmount = 0.89m;

            Console.WriteLine($"Hi, my name is {myName}, I am {age} years old. My favorite number and letter is {favoriteNumber} & {favoriteLetter}, respectively.");
            Console.WriteLine($"I have {bankAccountAmount} in my bank account. Am I really living? {isAlive}");
        }
    }
}