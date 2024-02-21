namespace Intrepion.BullsAndCows.Library;

public class App<T> where T : IEquatable<T>
{
    bool _doneWithGuesses = false;
    List<T>? _secret;
    int _size = -1;

    public bool IsDoneWithGuesses()
    {
        return _doneWithGuesses;
    }

    public bool IsReadyForGuesses()
    {
        if (_secret == null)
        {
            return false;
        }

        return true;
    }

    public bool IsSecretFound()
    {
        return false;
    }

    public void MakeGuess(List<T> guess)
    {
        var _ = guess;

        if (_size == -1)
        {
            throw new NotReadyForGuessesException();
        }

        if (guess.Count != _size)
        {
            throw new GuessSizeMismatchException();
        }

        _doneWithGuesses = true;
    }

    public void SetSecret(List<T> secret)
    {
        if (secret.Count != _size)
        {
            throw new SecretSizeMismatchException();
        }

        _secret = secret;
    }

    public void SetSize(int size)
    {
        _size = size;
    }
}
