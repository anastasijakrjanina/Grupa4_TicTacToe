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
