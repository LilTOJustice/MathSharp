﻿namespace MathSharp
{
    /// <summary>
    /// Interface for swizzlable types.
    /// </summary>
    public interface ISwizzlable<TSelf, TBase>
        where TSelf : struct, ISwizzlable<TSelf, TBase>
    {
        /// <summary>
        /// For implicitly converting a swizzle to the implementing type. i.e. <c>Vec2 v = vec3["yz"];</c>
        /// </summary>
        public static abstract implicit operator TSelf(Swizzle<TBase> swizzler);

        /// <summary>
        /// For implicitly converting the implementing type to a swizzle. i.e. <c>Vec2 v["yx"] = other2;</c>
        /// </summary>
        public static abstract implicit operator Swizzle<TBase>(in TSelf swizzler);

        /// <summary>
        /// Used to perform a swizzle. i.e. <c>vec3["yz"] = vec3["xz"];</c>
        /// </summary>
        public Swizzle<TBase> this[string swizzle] { get; set; }
    }
}
