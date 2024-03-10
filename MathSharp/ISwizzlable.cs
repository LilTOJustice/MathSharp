namespace MathSharp
{
    /// <summary>
    /// Interface for swizzlable types.
    /// </summary>
    public interface ISwizzlable<TSelf>
        where TSelf : ISwizzlable<TSelf>
    {
        /// <summary>
        /// For implicitly converting a swizzle to the implementing type. i.e. <c>Vec2 v = vec3.Swizzle("yz");</c>
        /// </summary>
        public static abstract implicit operator TSelf(Swizzle<TSelf> swizzler);

        /// <summary>
        /// For creating the swizzle object. i.e. <c>vec3.Swizzle("yz")</c>
        /// </summary>
        public abstract Swizzle<TSelf> Swizzle(string swizzle);
    }
}
