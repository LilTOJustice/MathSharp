namespace MathSharp
{
    /// <summary>
    /// Radiant representation of an angle.
    /// </summary>
    public struct Radian : IAngle
    {
        /// <inheritdoc cref="IAngle.Radians"/>
        public double Radians { get; private set; }

        /// <inheritdoc cref="IAngle.Degrees"/>
        public double Degrees => Radians * 180 / Math.PI;

        /// <summary>
        /// Creates a new <see cref="Degree"/> with the given degrees.
        /// </summary>
        public Radian(double radians)
        {
            Radians = radians;
        }
    }
}
