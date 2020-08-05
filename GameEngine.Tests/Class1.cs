using Xunit;

namespace GameEngine.Tests
{
    public class BossEnemyShould
    {
        [Fact]
        public void HaveCorrectPower()
        {

            BossEnemy sut = new BossEnemy();
            var power = sut.SpecialAttackPower;
            Assert.Equal(166.667, power, 3);

        }

    }
}
