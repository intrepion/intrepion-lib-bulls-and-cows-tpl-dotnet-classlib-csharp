using Intrepion.BullsAndCows.Library;

namespace Intrepion.BullsAndCows.Testing;

public class ReadyForGuesses
{
    [Fact]
    public void NewApp_DoNothing_ReturnFalse()
    {
        var expected = false;
        var app = new App();

        var actual = app.IsReadyForGuesses();

        Assert.Equal(expected, actual);
    }
}
