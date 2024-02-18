public class NotReadyForGuessesException : Exception
{
    public NotReadyForGuessesException()
    {
    }

    public NotReadyForGuessesException(string message)
        : base(message)
    {
    }

    public NotReadyForGuessesException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
