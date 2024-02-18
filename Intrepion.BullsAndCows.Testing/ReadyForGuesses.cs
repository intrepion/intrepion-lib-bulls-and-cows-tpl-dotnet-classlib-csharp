using Intrepion.BullsAndCows.Library;

namespace Intrepion.BullsAndCows.Testing;

public class ReadyForGuesses
{
    [Fact]
    public void NewIntApp_DoNothing_ReturnFalse()
    {
        var expected = false;
        var app = new App<int>();

        var actual = app.IsReadyForGuesses();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void New1IntApp_Set1IntSecret_ReturnTrue()
    {
        var expected = true;
        var app = new App<int>();
        app.SetSize(1);
        var secret = new List<int>
        {
            1,
        };
        app.SetSecret(secret);

        var actual = app.IsReadyForGuesses();

        Assert.Equal(expected, actual);
    }
}
