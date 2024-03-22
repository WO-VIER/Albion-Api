    using System.Text;
    using System.Text.Json;
    using Albion_ApiV2.Pages;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.FileProviders;
    using Bunit.Web;
    using Bunit;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.JSInterop;
    using Moq;
    using Xunit;
    using Index = Albion_ApiV2.Pages.Index;

    public class UnitTest1 : TestContext
    {


        [Fact]
        public void AreEquals_ReturnsTrue_WhenPlayersAreEqual()
        {
            // Arrange
            var indexPage = new Index();
            var player1 = new Index.AlbionPlayer() { Name = "Test", Id = "1" };
            var player2 = new Index.AlbionPlayer { Name = "Test", Id = "1" };

            // Act
            var result = indexPage.areEquals(player1, player2);

            // Assert
            Assert.True(result);
        }

        //Scénario 1 Scénario 1 : Deux joueurs avec les mêmes attributs doivent être considérés comme égaux.
        //Scénario 2 : Deux joueurs avec des attributs différents ne doivent pas être considérés comme égaux.

        [Fact]
        public void AreEquals_ReturnsFalse_WhenPlayersAreNotEqual()
        {
            // Arrange
            var indexPage = new Index();
            var player1 = new Index.AlbionPlayer { Name = "Test", Id = "1" };
            var player2 = new Index.AlbionPlayer { Name = "Test", Id = "2" };

            // Act
            var result = indexPage.areEquals(player1, player2);

            // Assert
            Assert.False(result);
        }


        

        //Scénario 1 :: Cette méthode ne renvoie pas de valeur et modifie l'état interne de la page. Vous pouvez utiliser un mock ou un stub pour votre stockage local afin de vérifier que les bonnes méthodes ont été appelées avec les bonnes valeurs.

        [Fact]
        public void GetAlbionPlayerTest()
        {
            
            //Arrange
            var ctx = new TestContext();
             var mockHttpClient = new Mock<HttpClient>();
             var mockJsRuntime = new Mock<IJSRuntime>();
             var mockLicenseChecker = new Mock<Blazorise.Licensing.BlazoriseLicenseChecker>();
          
            
            // // Setup your mocks here if needed
            //
             ctx.Services.AddSingleton(mockHttpClient.Object); 
             ctx.Services.AddSingleton(mockJsRuntime.Object);
             ctx.Services.AddSingleton(mockLicenseChecker.Object);
             

            // Act
            var cut = RenderComponent<Index>();

            // Assert
            // Add your assertions here
        }





    }
    
    
       