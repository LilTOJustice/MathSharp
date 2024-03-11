namespace MathSharp
{
    /// <summary>
    /// Thrown when the left and right sides of a swizzle aren't equal in size.
    /// </summary>
    public class SwizzleMismatchException : Exception
    {
        /// <inheritdoc cref="SwizzleMismatchException"/>
        public SwizzleMismatchException(int len1, int len2) : base($"Left and right sides of swizzle are not equal in size: {len1}, {len2}") { }
    }
}
