using Intrepion.BullsAndCows.Library;

namespace Intrepion.BullsAndCows.Testing;

public class SetSecret
{
    [Fact]
    public void New1IntApp_Set2IntSecret_ThrowsSecretSizeMismatchException()
    {
        var app = new App<int>();
        app.SetSize(1);
        var secret = new List<int>
        {
            1,
            2,
        };

        Assert.Throws<SecretSizeMismatchException>(() => app.SetSecret(secret));
    }
}
