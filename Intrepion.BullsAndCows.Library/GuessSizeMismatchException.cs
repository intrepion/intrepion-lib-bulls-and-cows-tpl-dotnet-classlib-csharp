public class GuessSizeMismatchException : Exception
{
    public GuessSizeMismatchException()
    {
    }

    public GuessSizeMismatchException(string message)
        : base(message)
    {
    }

    public GuessSizeMismatchException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
