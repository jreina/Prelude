using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Prelude.Prelude;

namespace PreludeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void should_compose_right_to_left()
        {
            Func<int, int> f = x => x * 2;
            Func<int, int> g = x => x + 1;

            var h = Compose(g, f);

            var expected = 21;
            var actual = h(10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void should_left_to_right()
        {
            Func<int, int> f = x => x * 2;
            Func<int, int> g = x => x + 1;

            var h = Pipe(f, g);

            var expected = 21;
            var actual = h(10);

            Assert.AreEqual(expected, actual);
        }
    }
}
