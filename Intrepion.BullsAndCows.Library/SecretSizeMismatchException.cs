public class SecretSizeMismatchException : Exception
{
    public SecretSizeMismatchException()
    {
    }

    public SecretSizeMismatchException(string message)
        : base(message)
    {
    }

    public SecretSizeMismatchException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
