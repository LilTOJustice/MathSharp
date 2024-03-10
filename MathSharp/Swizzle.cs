namespace MathSharp
{
    /// <summary>
    /// Created to allow swizzling of vectors. <see href="https://en.wikipedia.org/wiki/Swizzling_(computer_graphics)"/>.
    /// Usage:
    /// Vec3 v3 = v2.Swizzle("xyx");
    /// v2.Swizzle("yx") = v3.Swizzle("yz");
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Swizzle<T>
        where T : ISwizzlable<T>
    {
        /// <summary>
        /// Swizzlable container.
        /// </summary>
        public T Container { get; set; }

        /// <summary>
        /// String representing the swizzle.
        /// </summary>
        public string SwizzleString { get; set; }

        /// <summary>
        /// Constructs a new swizzle object.
        /// </summary>
        public Swizzle(T container, string swizzleString)
        {
            Container = container;
            SwizzleString = swizzleString;
        }
    }
}
