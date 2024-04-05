namespace GuessLib;

public class Display
{
    public void DisplayWord(string word, bool[] charactersGuessed)
    {
        string finalWord = "";
        for (byte i = 0; i < charactersGuessed.Length; i++)
        {
            if (charactersGuessed[i] == true)
            {
                finalWord += word[i];
            }
            else
            {
                finalWord += "_";
            }
        }
        
        Console.WriteLine("The word is: " + finalWord);
    }
}