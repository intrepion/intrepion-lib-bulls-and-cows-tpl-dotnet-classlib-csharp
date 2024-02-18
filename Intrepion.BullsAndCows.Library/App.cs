

namespace Intrepion.BullsAndCows.Library;

public class App<T> where T : IComparable
{
    public bool IsReadyForGuesses()
    {
        return false;
    }

    public void SetSecret(List<T> secret)
    {
        throw new SecretSizeMismatchException();
    }

    public void SetSize(int size)
    {
        _ = size;
    }
}
