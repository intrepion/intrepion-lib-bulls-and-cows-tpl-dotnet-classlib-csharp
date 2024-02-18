

namespace Intrepion.BullsAndCows.Library;

public class App<T> where T : IComparable
{
    public bool IsReadyForGuesses()
    {
        return false;
    }

    public void SetSecret(List<char> secret)
    {
        throw new SecretTypeMismatchException();
    }
}
