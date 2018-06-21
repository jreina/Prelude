using System;

namespace Prelude
{
    public static partial class Prelude
    {
        /// <summary>
        /// Compose two functions into a new function.
        /// </summary>
        /// <returns>A function which is the left-to-right composition of the two functions.</returns>
        public static Func<a, c> Pipe<a, b, c>(Func<a, b> g, Func<b, c> f) => x => f(g(x));
    }
}
