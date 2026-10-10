using BlaisePascal.EnemyPlayer.Domain;

namespace BlaisePascal.EnemyPlayer.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Player_ShouldStartAtLevelOne()
        {
            Player player = new Player("Mario");
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void Player_ShouldStartWithZeroExperience()
        {
            Player player = new Player("Luigi");
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void Player_ShouldStartWithFullHealth()
        {
            Player player = new Player("Luigi");
            Assert.Equal(100, player.Health);
        }
        

    }
}
