namespace MathSharp
{
    public class Operations
    {
        /// <summary>
        /// True modulo operation that works with negative numbers.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="modulo"></param>
        /// <returns></returns>
        public static int Mod(int input, int modulo)
        {
            return (input % modulo + modulo) % modulo;
        }
    }
}
