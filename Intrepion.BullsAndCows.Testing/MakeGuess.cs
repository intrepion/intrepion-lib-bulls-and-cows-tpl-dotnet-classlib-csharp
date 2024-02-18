using Intrepion.BullsAndCows.Library;

namespace Intrepion.BullsAndCows.Testing;

public class MakeGuess
{
    [Fact]
    public void New1IntApp_DoNothingGuess_ThrowsNotReadyForGuessesException()
    {
        var app = new App<int>();
        var guess = new List<int>
        {
            1,
        };

        Assert.Throws<NotReadyForGuessesException>(() => app.MakeGuess(guess));
    }
}
