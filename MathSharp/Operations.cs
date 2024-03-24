namespace MathSharp
{
    /// <summary>
    /// Collection of math operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// True modulo operation that works with negative numbers.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="modulo"></param>
        /// <returns></returns>
        public static double Mod(double input, double modulo)
        {
            return (input % modulo + modulo) % modulo;
        }

        /// <summary>
        /// Performs linear interpolation between two values.
        /// </summary>
        public static double Lerp(double low, double high, double alpha)
        {
            return low + (high - low) * alpha;
        }

        /// <summary>
        /// Solve a quadratic equation.
        /// </summary>
        /// <returns>Whether there is at least one root. If there is exactly one root, plusRoot == minusRoot.</returns>
        public static bool SolveQuadratic(double a, double b, double c, out double plusRoot, out double minusRoot)
        {
            plusRoot = 0;
            minusRoot = 0;
            if (a == 0)
            {
                return false;
            }

            double sqrt = b * b - 4 * a * c;
            if (sqrt < 0)
            {
                return false;
            }

            double sqrtResult = Math.Sqrt(sqrt);
            plusRoot = (-b + sqrtResult) / (2 * a);
            minusRoot = (-b - sqrtResult) / (2 * a);
            return true;
        }
    }
}
