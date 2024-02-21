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

    [Fact]
    public void New1IntApp_GuessCorrectly_ReturnTrue()
    {
        var expected = true;
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
        };

        app.MakeGuess(guess);
        var actual = app.IsDoneWithGuesses();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void New1IntApp_GuessIncorrectly_ReturnFalse()
    {
        var expected = false;
        var app = new App<int>();
        app.SetSize(1);
        var secret = new List<int>
        {
            1,
        };
        app.SetSecret(secret);
        var guess = new List<int>
        {
            2,
        };

        app.MakeGuess(guess);
        var actual = app.IsDoneWithGuesses();

        Assert.Equal(expected, actual);
    }
}
