using Microsoft.VisualStudio.TestTools.UnitTesting;
using day0x05;

namespace AoC2020Tests
{
    [TestClass]
    public class Day05
    {
        [TestMethod]
        public void Partition_FBFBBFF_Returns44()
        {
            // Arrange
            var input = "FBFBBFF";
            var lower = 'F';
            var upper = 'B';
            var range = 127;

            // Act
            var result = BSPHelper.Partition(input, lower, upper, range);

            // Assert
            Assert.AreEqual(44, result);
        }

        [TestMethod]
        public void Partition_BFFFBBF_Returns70()
        {
            // Arrange
            var input = "BFFFBBF";
            var lower = 'F';
            var upper = 'B';
            var range = 127;

            // Act
            var result = BSPHelper.Partition(input, lower, upper, range);

            // Assert
            Assert.AreEqual(70, result);
        }

        [TestMethod]
        public void Partition_FFFBBBF_Returns14()
        {
            // Arrange
            var input = "FFFBBBF";
            var lower = 'F';
            var upper = 'B';
            var range = 127;

            // Act
            var result = BSPHelper.Partition(input, lower, upper, range);

            // Assert
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void Partition_BBFFBBF_Returns102()
        {
            // Arrange
            var input = "BBFFBBF";
            var lower = 'F';
            var upper = 'B';
            var range = 127;

            // Act
            var result = BSPHelper.Partition(input, lower, upper, range);

            // Assert
            Assert.AreEqual(102, result);
        }

        [TestMethod]
        public void Partition_RRR_Returns7()
        {
            // Arrange
            var input = "RRR";
            var lower = 'L';
            var upper = 'R';
            var range = 7;

            // Act
            var result = BSPHelper.Partition(input, lower, upper, range);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Partition_RLL_Returns4()
        {
            // Arrange
            var input = "RLL";
            var lower = 'L';
            var upper = 'R';
            var range = 7;

            // Act
            var result = BSPHelper.Partition(input, lower, upper, range);

            // Assert
            Assert.AreEqual(4, result);
        }
    }
}
