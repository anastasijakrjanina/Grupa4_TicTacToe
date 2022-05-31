using Xunit;


namespace Grupa4_TicTacToe.Tests
{
    public class PlayersTest
    {


        [Fact]
        //public void GetPlayerString_WhenPlayers1NameEntered_ThenReturnsTrue()  
        //{
        //    bool response = Players.IsPlayer1NameExist();

        //    Assert.Equal("true", response);
        //}

        public void GetPlayerString_WhenPlayers1NameEntered_ThenReturnsYes()

        {

            var players = new Grupa4_TicTacToe.Players();

            string playerName = "Dace";
            bool response = Players.IsPlayer1NameExist(playerName);

            Assert.True(response);



        }



        [Theory]
        [InlineData("Dace")]
        [InlineData("  ")]
        [InlineData("")]
    

        public void GetPlayerString_WhenPlayers2NameEntered_ThenReturnsYes(string playerName)

        {


            var players = new Grupa4_TicTacToe.Players();
  

            bool response = Players.IsPlayer2NameExist(playerName);

            Assert.True(response);


        }

       

    }
}
