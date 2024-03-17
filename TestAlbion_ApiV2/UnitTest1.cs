namespace TestAlbion_ApiV2.Pages.Index;
using Bunit;

public class UnitTest1
{
    
    [Fact] 
    public void AreEquals_ReturnsTrue_WhenPlayersAreEqual()
    {
        // Arrange
        var indexPage = new Albion_ApiV2.Pages.Index();
        var player1 = new Albion_ApiV2.Pages.Index.AlbionPlayer { Name = "Test", Id = "1" };
        var player2 = new Albion_ApiV2.Pages.Index.AlbionPlayer { Name = "Test", Id = "1" };

        // Act
        var result = indexPage.areEquals(player1, player2);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void AreEquals_ReturnsFalse_WhenPlayersAreNotEqual()
    {
        // Arrange
        var indexPage = new Albion_ApiV2.Pages.Index();
        var player1 = new Albion_ApiV2.Pages.Index.AlbionPlayer { Name = "Test", Id = "1" };
        var player2 = new Albion_ApiV2.Pages.Index.AlbionPlayer { Name = "Test", Id = "2" };

        // Act
        var result = indexPage.areEquals(player1, player2);

        // Assert
        Assert.False(result);
    }
    
}