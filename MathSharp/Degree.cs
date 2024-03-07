using System;
using System.Collections.Generic;
using System.Linq;
namespace MathSharp
{
    /// <summary>
    /// Degree representation of an angle.
    /// </summary>
    public struct Degree : IAngle
    {
        /// <inheritdoc cref="IAngle.Radians"/>
        public double Radians => Math.PI * Degrees / 180;

        /// <inheritdoc cref="IAngle.Degrees"/>
        public double Degrees { get; private set; }

        /// <summary>
        /// Creates a new <see cref="Degree"/> with the given degrees.
        /// </summary>
        public Degree(double degrees)
        {
            Degrees = degrees;
        }
    }
}
