// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Tracing;
using GuessLib;
string[] words = ["apple", "orange", "dog", "cat", "gamepad", "laptop", "unfortunately", "replay", "context", "queue"];

Random random = new Random();

GuessLib.Guess guesser;
bool isFirstGuess;
InitBasics(out guesser, out isFirstGuess);


void InitBasics(out GuessLib.Guess guesser, out bool isFirstGuess)
{
    string word;
    int randomIndex = random.Next(0, words.Length);
    word = words[randomIndex];
    guesser = new Guess(word);
    isFirstGuess = true;
}

Console.WriteLine("Hello! This is WordGuess.");
Console.WriteLine("The word is selected. Enter your first guess: ");

while (true)
{

    if (!isFirstGuess)
    {
        Console.WriteLine("Enter your guess:");
    }

    isFirstGuess = false;
    
    if (guesser.IsWordGuessed())
    {
        Console.WriteLine("Congrats! The word is " + guesser.Word);
        break;
    }
    char chr;
    bool isParsed;

    isParsed = Char.TryParse(Console.ReadLine().ToLower(), out chr);

    if (!isParsed)
    {
        Console.WriteLine("Parsing the character failed.");
        continue;
    }

    if (guesser.IsWordGuessed())
    {
        Console.WriteLine("Congrats! The word is " + guesser.Word);
    }
    
    guesser.MakeGuess(chr);
}