using Intrepion.BullsAndCows.Library;

namespace Intrepion.BullsAndCows.Testing;

public class SetSecret
{
    [Fact]
    public void NewIntApp_SetCharSecret_ThrowsSecretTypeMismatchException()
    {
        var app = new App<int>();
        var secret = new List<char>
        {
            'a',
            'b',
            'c',
            'd',
        };

        Assert.Throws<SecretTypeMismatchException>(() => app.SetSecret(secret));
    }
}
