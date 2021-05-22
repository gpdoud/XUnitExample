using MathLib;

using System;

using Xunit;

namespace TestMathematicsLibrary {
    public class UnitTest1 {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 2, 1)]
        public void TestAdd(int i, int j, int ans) {
            Assert.Equal(ans, MathematicsLibrary.Add(i, j));
        }

        [Fact]
        public void TestValueOfPI() {
            Assert.Equal(3.1415927, MathematicsLibrary.PI);
        }
    }
}
