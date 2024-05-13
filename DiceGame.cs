static class DiceGame
{
    private static int userLifes = 3;
    private static int randomNumber = NumberGenerator._randomNumberGenerator;
    private static bool gameState = true;

    public static void StartGame()
    {
        do
        {
            Console.WriteLine($"Você tem '{userLifes}' vidas restantes!");
            Console.WriteLine("Digite um número para tentar adivinhar!");
            string? userGuess = Console.ReadLine();
            GuessValidator.Validator(userGuess, randomNumber);

        } while (gameState);
        Console.ReadKey();
    }

    public static void CorrectChoice()
    {
        gameState = false;
        Console.WriteLine("Você ganhou, parabéns! Aperte qualquer tecla para fechar o programa.");
    }

    public static void WrongChoice()
    {
        Console.WriteLine("Você errou!");
        userLifes--;
        if(userLifes == 0)
        {
            gameState = false;
            Console.WriteLine("Você morreu! Aperte qualquer tecla para fechar o programa.");
        }
    }
}
