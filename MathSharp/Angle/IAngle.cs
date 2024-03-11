using System.Numerics;

namespace MathSharp
{
    /// <summary>
    /// Interface for representing an angle in degrees or radians.
    /// <see cref="Degree"/> or <see cref="Radian"/> should be used to represent an angle.
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
