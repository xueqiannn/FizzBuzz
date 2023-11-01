using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_Fizz_when_CountOff_given_3()
        {
            FizzBuzzGame game = new FizzBuzzGame();

            //then
            Assert.NotNull(game);
        }

        [Fact]
        public void Should_return_the_given_number_when_CountOff_given_a_normal_case_number()
        {
            //given
            int number = 1;

            //when
            FizzBuzzGame game = new FizzBuzzGame();
            string res = game.CountOff(number);

            //then
            Assert.Equal("1", res);
        }
    }
}