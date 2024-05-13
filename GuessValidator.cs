static class GuessValidator
{
    public static void Validator(string? userGuess, int randomNumber)
    {
        bool isValidGuess = int.TryParse(userGuess, out int validGuess);

        if(isValidGuess)
        {
            if(validGuess == randomNumber)
            {
                DiceGame.CorrectChoice();
            }
            else
            {
                DiceGame.WrongChoice();
            }
        }
    }
}