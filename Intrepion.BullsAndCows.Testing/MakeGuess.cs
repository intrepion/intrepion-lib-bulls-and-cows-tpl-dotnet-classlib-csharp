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

    [Fact]
    public void New1IntApp_DoNothingGuess_ThrowsGuessSizeMismatchException()
    {
        var app = new App<int>();
        app.SetSize(1);
        var secret = new List<int>
        {
            1,
        };
        app.SetSecret(secret);
        var guess = new List<int>
        {
            1,
            2,
        };

        Assert.Throws<GuessSizeMismatchException>(() => app.MakeGuess(guess));
    }
}
