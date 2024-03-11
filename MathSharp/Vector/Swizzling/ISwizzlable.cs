namespace MathSharp
{
    // Ideas:
    // Swizzling creates an array instead of a new type. Remove the Swizzle class entirely and use an array instead.
    // Swizzle interface
    /// <summary>
    /// Interface for swizzlable types.
    /// </summary>
    public interface ISwizzlable<TSelf, TBase>
        where TSelf : struct, ISwizzlable<TSelf, TBase>
    {
        /// <summary>
        /// Mapping of swizzle characters to their index in the implementing type.
        /// i.e. SwizzleMap['x'] = 0, SwizzleMap['y'] = 1, etc.
        /// </summary>
        public static abstract Dictionary<char, int> SwizzleMap { get; }

        /// <summary>
        /// For implicitly converting a swizzle to the implementing type. i.e. <c>Vec2 v = vec3["yz"];</c>
        /// </summary>
        public static abstract implicit operator TSelf(TBase[] swizzle);

        /// <summary>
        /// For implicitly converting the implementing type to a swizzle. i.e. <c>Vec2 v["yx"] = other2;</c>
        /// </summary>
        public static abstract implicit operator TBase[](in TSelf swizzler);

        /// <summary>
        /// Used to perform a swizzle. i.e. <c>vec3["yz"] = vec3["xz"];</c>
        /// </summary>
        public TBase[] this[string swizzle] { get; set; }
    }
}
