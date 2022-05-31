using Xunit;
  

namespace Grupa4_TicTacToe.Tests
{
    public class PlayersTest
    {
        private string num;

        [Fact]
        //public void GetPlayerString_WhenPlayers1NameEntered_ThenReturnsTrue()  
        //{
        //    bool response = Players.IsPlayer1NameExist();

        //    Assert.Equal("true", response);
        //}

        public void GetPlayerString_WhenPlayers1NameEntered_ThenReturnsYes()
        {
            var Players = new Players();
            string response = Players.IsPlayer1NameExist(1);

              Assert.Equal("True", response);

        }

        [Fact]
        public void GetPlayerString_WhenPlayers2NameEntered_ThenReturnsYes()
        {
            string response = Players.IsPlayer2NameExist(2);

            Assert.Equal("True", response);

        }

        //[Theory]
        //[InlineData()]
        //[InlineData()]

    }
}
