using System;
using Xunit;
using Lab02_UnitTesting;
namespace TestLab02_UnitTesting
{
    public class UnitTest1
    {

        [Fact]
        public void TestViewBalance1() {

            Assert.Equal(5, Program.ViewBalance(5));



        }
        [Theory]
        [InlineData(5 ,5)]
        [InlineData(4.5,4.5)]
        [InlineData(0,0)]
        public void TestViewBalance2(decimal result , decimal amount) {

            Assert.Equal(result, Program.ViewBalance(amount));
        }


       
        [Fact]
        public void TestWithdraw1()
        {

            Assert.Equal(50, Program.Withdraw(100, 50));


        }
        [Theory]
        [InlineData(59,100,41)]
        [InlineData(0,100,100)]
        [InlineData(29.5,100,70.5)]
        public void TestWithdraw2(decimal result,decimal balance, decimal amount)
        {

            Assert.Equal(result, Program.Withdraw(balance, amount));
        }


        [Fact]
        public void TestDeposit1()
        {


            Assert.Equal(40, Program.Deposit(10,30));

        }
        [Theory]
        [InlineData(1000,250,750)]
        [InlineData(240,120,120)]
        [InlineData(56.22,30.79,25.43)]
        public void TestDeposit2(decimal result, decimal balance, decimal amount)
        {
            Assert.Equal(result, Program.Deposit(balance, amount));

        }


        [Fact]
        public void TestSearchForAccount1()
        {
            string user = "ahmad";

            Assert.Equal(0, Program.SearchForAccount(user));

        }
        [Theory]
        [InlineData(1,"omar")]
        [InlineData(0,"ahmad")]
        [InlineData(-1,"ali")]
        public void TestSearchForAccount2(int result ,string user)
        {
            Assert.Equal(result, Program.SearchForAccount(user));


        }


    }
}
