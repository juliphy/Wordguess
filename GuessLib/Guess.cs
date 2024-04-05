namespace GuessLib;

public class Guess
{
    private Display _displayer;
    private string _word;
    private bool[] _characterGuessedBoolean;

    public bool[] CharacterGuessedBoolean
    {
        get
        {
            return _characterGuessedBoolean;
        }
    }

    public string Word
    {
        get { return _word; }
    }
    public Guess(string selectedWord)
    {
        _displayer = new Display();
        _word = selectedWord;
        _characterGuessedBoolean = new bool[_word.Length];
        
    }

    public void MakeGuess(char characterGuessed)
    {
        for (byte i = 0; i < _word.Length; i++)
        {
            if (_word[i] == characterGuessed)
            {
                _characterGuessedBoolean[i] = true;
            }
        }

        _displayer.DisplayWord(_word, _characterGuessedBoolean);


    }

    public bool IsWordGuessed()
    {
        byte count = 0;
        
        for (byte i = 0; i < _characterGuessedBoolean.Length; i++)
        {
            if (_characterGuessedBoolean[i] == true)
            {
                count++;
            }
        }

        return count == _characterGuessedBoolean.Length;
    }
}