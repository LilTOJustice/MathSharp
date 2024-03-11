namespace MathSharp
{
    /// <summary>
    /// Thrown when an unexpected swizzle value is encountered or a swizzle string is too large.
    /// </summary>
    public class SwizzleException : Exception
    {
        /// <summary>
        /// Thrown when an unexpected swizzle value is encountered.
        /// </summary>
        public SwizzleException(char badValue) : base($"Unexpected swizzle value: {badValue}") { }

        /// <summary>
        /// Thrown when a swizzle string is too large.
        /// </summary>
        public SwizzleException(int expectedLength, int badLength) : base($"Swizzle string is too large, expected <= {expectedLength}, got {badLength}.") { }
    }
}
