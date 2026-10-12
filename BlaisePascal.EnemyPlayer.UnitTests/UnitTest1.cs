using BlaisePascal.EnemyPlayer.Domain;

namespace BlaisePascal.EnemyPlayer.UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void Player_ShouldStartAtLevelOne()
        {
            Player player = new Player("Paul");

            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void Player_ShouldStartWithZeroExperience()
        {
            Player player = new Player("Paul");

            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void Player_ShouldStartWithFullHealth()
        {
            Player player = new Player("Paul");

            Assert.Equal(100, player.Health);
            Assert.Equal(100, player.MaxHealth);
        }

        [Fact]
        public void Player_ShouldStartAlive()
        {
            Player player = new Player("Paul");

            Assert.True(player.IsAlive);
        }

        [Fact]
        public void Player_ShouldStartWithZeroGold()
        {
            Player player = new Player("Paul");

            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void Player_ShouldStoreName()
        {
            Player player = new Player("Paul");

            Assert.Equal("Paul", player.Name);
        }

        [Fact]
        public void AddExperience_ShouldIncreaseExperience()
        {
            Player player = new Player("Paul");

            player.AddExperience(50);

            Assert.Equal(50, player.Experience);
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void AddExperience_ShouldLevelUpAt100()
        {
            Player player = new Player("Paul");

            player.AddExperience(100);

            Assert.Equal(2, player.Level);
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void AddExperience_ShouldKeepRemainingExperience()
        {
            Player player = new Player("Paul");

            player.AddExperience(250);

            Assert.Equal(3, player.Level);
            Assert.Equal(50, player.Experience);
        }

        [Fact]
        public void AddExperience_ShouldHandleMultipleLevelUps()
        {
            Player player = new Player("Paul");

            player.AddExperience(350);

            Assert.Equal(4, player.Level);
            Assert.Equal(50, player.Experience);
        }

        [Fact]
        public void ResetExperience_ShouldSetExperienceToZero()
        {
            Player player = new Player("Paul");
            player.AddExperience(50);

            player.ResetExperience();

            Assert.Equal(0, player.Experience);
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void TakeDamage_ShouldDecreaseHealth()
        {
            Player player = new Player("Paul");

            player.TakeDamage(30);

            Assert.Equal(70, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void TakeDamage_ShouldSetHealthToZeroWhenDamageExceedsHealth()
        {
            Player player = new Player("Paul");

            player.TakeDamage(150);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void TakeDamage_ShouldKillPlayerWhenHealthReachesZero()
        {
            Player player = new Player("Paul");

            player.TakeDamage(100);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void TakeDamage_ShouldNotDamageDeadPlayer()
        {
            Player player = new Player("Paul");
            player.TakeDamage(100);

            player.TakeDamage(30);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void Heal_ShouldIncreaseHealth()
        {
            Player player = new Player("Paul");
            player.TakeDamage(30);

            player.Heal(20);

            Assert.Equal(90, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void Heal_ShouldNotExceedMaxHealth()
        {
            Player player = new Player("Paul");
            player.TakeDamage(20);

            player.Heal(50);

            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Heal_ShouldNotReviveDeadPlayer()
        {
            Player player = new Player("Paul");
            player.TakeDamage(100);

            player.Heal(50);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void ResetHealth_ShouldRestoreFullHealth()
        {
            Player player = new Player("Paul");
            player.TakeDamage(60);

            player.ResetHealth();

            Assert.Equal(100, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void ResetHealth_ShouldReviveDeadPlayer()
        {
            Player player = new Player("Paul");
            player.TakeDamage(100);

            player.ResetHealth();

            Assert.Equal(100, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void AddGold_ShouldIncreaseGold()
        {
            Player player = new Player("Paul");

            player.AddGold(100);

            Assert.Equal(100, player.Gold);
        }

        [Fact]
        public void AddGold_ShouldAccumulateGold()
        {
            Player player = new Player("Paul");

            player.AddGold(100);
            player.AddGold(50);

            Assert.Equal(150, player.Gold);
        }

    }
}