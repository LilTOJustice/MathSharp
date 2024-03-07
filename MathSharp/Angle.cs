namespace MathSharp
{
    /// <summary>
    /// Interface for representing an angle in degrees or radians.
    /// </summary>
    public interface IAngle
    {
        /// <summary>
        /// Radians representation of the angle.
        /// </summary>
        public double Radians { get; }

        /// <summary>
        /// Degrees representation of the angle.
        /// </summary>
        public double Degrees { get; }
    }
}
