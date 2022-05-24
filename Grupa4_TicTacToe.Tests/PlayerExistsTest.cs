using Xunit;
  

namespace Grupa4_TicTacToe.Tests
{
    public class PlayerExistsTest
    {
        [Fact]
        public void GetPlayerString_WhenPlayersNameEntered_ThenReturnsTrue()  
        {
            string response = Players.GetPlayerString();

            Assert.Equal("True", response);
        }

    }
}