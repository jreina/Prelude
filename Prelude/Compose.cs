using System;

namespace Prelude
{
    public static partial class Prelude
    {
        /// <summary>
        /// Compose two functions into a new function.
        /// </summary>
        /// <returns>A function which is the right-to-left composition of the two functions.</returns>
        public static Func<a, c> Compose<a, b, c>(Func<b, c> f, Func<a, b> g) => x => f(g(x));
    }
}
