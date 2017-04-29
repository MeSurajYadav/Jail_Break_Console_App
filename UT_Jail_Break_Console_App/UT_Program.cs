using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jail_Break_Console_App;

namespace UT_Jail_Break_Console_App
{
    [TestClass]
    public class UT_Program
    {
        [TestMethod]
        public void UT_GetJumpCount()
        {
            //Arrange
            int jumpCapacity = 10;
            int slipingCount = 1;
            int wallsCount = 1;
            int[] heightsOfWalls = new int[] { 10 };

            int jumpCount = 0;

            //Act
            jumpCount = Program.GetJumpCount(jumpCapacity, slipingCount, wallsCount, heightsOfWalls);

            //Assert
            Assert.AreEqual(1, jumpCount);
        }


        [TestMethod]
        public void UT2_GetJumpCount()
        {
            //Arrange
            int jumpCapacity = 5;
            int slipingCount = 1;
            int wallsCount = 2;
            int[] heightsOfWalls = new int[] { 9, 10 };

            int jumpCount = 0;

            //Act
            jumpCount = Program.GetJumpCount(jumpCapacity, slipingCount, wallsCount, heightsOfWalls);

            //Assert
            Assert.AreEqual(5, jumpCount);
        }
    }
}
