

namespace Intrepion.BullsAndCows.Library;

public class App<T>
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
