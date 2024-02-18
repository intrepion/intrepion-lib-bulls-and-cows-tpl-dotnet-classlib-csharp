public class SecretTypeMismatchException : Exception
{
    public SecretTypeMismatchException()
    {
    }

    public SecretTypeMismatchException(string message)
        : base(message)
    {
    }

    public SecretTypeMismatchException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
