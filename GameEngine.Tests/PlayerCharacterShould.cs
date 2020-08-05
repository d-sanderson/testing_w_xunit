using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            // System Under Test (sut)
            PlayerCharacter sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void CalculateFullName()
        {
            // System Under Test (sut)
            PlayerCharacter sut = new PlayerCharacter();

            string fullName = $"{sut.FirstName} {sut.LastName}";

            Assert.Equal(fullName, sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void InitialHealthIsOneHunded()
        {
            // System Under Test (sut)
            PlayerCharacter sut = new PlayerCharacter();



            Assert.Equal(100, sut.Health);
        }
        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            // System Under Test (sut)
            PlayerCharacter sut = new PlayerCharacter();

            int health = sut.Health;

            sut.Sleep();

            Assert.InRange(sut.Health, 101, 200);
        }

        [Fact]
        public void NickNameNullWhenNew()
        {
            var sut = new PlayerCharacter();
            Assert.Null(sut.Nickname);
        }
        [Fact]
        public void HasStarterWeapons()
        {
            var sut = new PlayerCharacter();

            Assert.Contains("Long Bow", sut.Weapons);
            Assert.Contains("Short Bow", sut.Weapons);
            Assert.Contains(sut.Weapons, weapon => weapon.Contains("Sword"));

        }

        [Fact]
        public void HasNoEmptyOrNullDefaultWeapons()
        {
            var sut = new PlayerCharacter();

            Assert.All(sut.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));

        }
    }
}
