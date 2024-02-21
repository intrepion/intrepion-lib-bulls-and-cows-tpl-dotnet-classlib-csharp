using Intrepion.BullsAndCows.Library;

namespace Intrepion.BullsAndCows.Testing;

public class DoneWithGuesses
{
    [Fact]
    public void New1IntApp_DoNothing_ReturnFalse()
    {
        var expected = false;
        var app = new App<int>();

        var actual = app.IsDoneWithGuesses();

        Assert.Equal(expected, actual);
    }
}
