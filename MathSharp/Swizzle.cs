namespace MathSharp
{
    /// <summary>
    /// Created to allow swizzling of vectors. <see href="https://en.wikipedia.org/wiki/Swizzling_(computer_graphics)"/>.
    /// Usage:
    /// Vec3 v3 = v2.Swizzle("xyx");
    /// v2.Swizzle("yx") = v3.Swizzle("yz");
    /// </summary>
    /// <typeparam name="T">Type stored in the swizzlable.</typeparam>
    public class Swizzle<T>
    {
        /// <summary>
        /// Swizzlable container.
        /// </summary>
        internal T[] Container { get; set; }

        /// <summary>
        /// String representing the swizzle.
        /// </summary>
        internal string SwizzleString { get; set; }

        /// <summary>
        /// Constructs a new swizzle object.
        /// </summary>
        internal Swizzle(T[] container, string swizzleString)
        {
            Container = container;
            SwizzleString = swizzleString;
        }
    }
}
