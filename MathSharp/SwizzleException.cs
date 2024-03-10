namespace MathSharp
{
    class SwizzleException : Exception
    {
        public SwizzleException(char badValue) : base($"Unexpected swizzle value: {badValue}") { }

        public SwizzleException(int expectedLength, int badLength) : base($"Incorrect length of swizzle string. Expected {expectedLength}, got {badLength}.") { }
    }
}
