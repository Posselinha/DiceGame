static class NumberGenerator
{
    public static int _randomNumberGenerator { get; private set; } = new Random().Next(1, 7);
}
