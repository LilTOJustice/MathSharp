using System.Numerics;

namespace MathSharp
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSelf">Type implementing the interface.</typeparam>
    /// <typeparam name="TBase">Base type of the vector. Must be of type <see cref="INumber{TSelf}"/>.</typeparam>
    /// <typeparam name="TFloat">Type used for forced float situations (such as <see cref="Mag"/>). Must be of type <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
    /// <typeparam name="TVFloat">Type used for forced vector float situations (such as <see cref="Norm"/>). Must be of type <see cref="IVec2{TSelf, TBase, TFloat, TVFloat}"/>.</typeparam>
    public interface IVec2<TSelf, TBase, TFloat, TVFloat> : IEquatable<IVec2<TSelf, TBase, TFloat, TVFloat>>
        where TSelf : IVec2<TSelf, TBase, TFloat, TVFloat>, new()
        where TBase : INumber<TBase>
        where TFloat : IFloatingPoint<TFloat>
        where TVFloat : IVec2<TVFloat, TFloat, TFloat, TVFloat>, new()
    {
        /// <summary>
        /// The x component of the vector.
        /// </summary>
        TBase X { get; set; }

        /// <summary>
        /// The y component of the vector.
        /// </summary>
        TBase Y { get; set; }

        /// <summary>
        /// A new array representing the components of the vector.
        /// </summary>
        TBase[] Components { get; }

        /// <summary>
        /// Indexer for the vector. 0 is the x component and so on.
        /// </summary>
        public TBase this[int i] { get; set; }

        /// <summary>
        /// Computes the rotated vector by the given angle.
        /// </summary>
        /// <returns>A new floating point vector with the result of the rotation.</returns>
        public TVFloat Rotate(IAngle angle);

        /// <summary>
        /// Computes the squared magnitude of the vector.
        /// </summary>
        public TBase Mag2();

        /// <summary>
        /// Computes the magnitude of the vector.
        /// </summary>
        public TFloat Mag();

        /// <summary>
        /// Computes the dot product between two vectors (<see href="https://en.wikipedia.org/wiki/Dot_product"/>).
        /// </summary>
        public TBase Dot(in TSelf other);

        /// <summary>
        /// Computes the 2d (scalar) cross product between two vectors (<see href="https://en.wikipedia.org/wiki/Cross_product"/>).
        /// </summary>
        public TBase Cross2d(in TSelf other);

        /// <summary>
        /// Computes the normalized vector.
        /// </summary>
        public TVFloat Norm();

        /// <summary>
        /// Gets the string representation of the vector.
        /// </summary>
        public string ToString();

        // Default implementations of required methods.
        /// <inheritdoc cref="Components"/>
        TBase[] IComponents => new[] { X, Y };

        /// <inheritdoc cref="this[int]"/>
        public TBase IIndexerGet(int i)
        {
            switch (i)
            {
                case 0:
                    return X;
                case 1:
                    return Y;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        /// <inheritdoc cref="this[int]"/>
        public void IIndexerSet(int i, TBase value)
        {
            switch (i)
            {
                case 0:
                    X = value;
                    break;
                case 1:
                    Y = value;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        /// <inheritdoc cref="Rotate(IAngle)"/>
        public TVFloat IRotate(IAngle angle)
            => new TVFloat
            {
                X = ToTFloat(X) * ToTFloat(Math.Cos(angle.Radians)) -
                ToTFloat(Y) * ToTFloat(Math.Sin(angle.Radians)),
                Y = ToTFloat(X) * ToTFloat(Math.Sin(angle.Radians)) +
                ToTFloat(Y) * ToTFloat(Math.Cos(angle.Radians))
            };

        /// <inheritdoc cref="Mag2"/>
        public TBase IMag2() => X * X + Y * Y;

        /// <inheritdoc cref="Mag"/>
        public TFloat IMag() => ToTFloat(Math.Sqrt(Convert.ToDouble(Mag2())));

        /// <inheritdoc cref="Dot"/>
        public TBase IDot(in TSelf other) => X * other.X + Y * other.Y;

        /// <inheritdoc cref="Cross2d"/>
        public TBase ICross2d(in TSelf other) => X * other.Y - Y * other.X;

        /// <inheritdoc cref="Norm"/>
        public TVFloat INorm() => IFDiv(Mag());

        /// <summary>
        /// Computes the sum of two vectors.
        /// </summary>
        public TSelf IAdd(in TSelf other)
            => new TSelf { X = X + other.X, Y = Y + other.Y };

        /// <summary>
        /// Computes the difference of two vectors.
        /// </summary>
        public TSelf ISub(in TSelf other)
            => new TSelf { X = X - other.X, Y = Y - other.Y };

        /// <summary>
        /// Computes the Hadamard product of two vectors, also known as the component-wise product (<see href="https://en.wikipedia.org/wiki/Hadamard_product_(matrices)"/>).
        /// </summary>
        public TSelf IMul(in TSelf other)
            => new TSelf { X = X * other.X, Y = Y * other.Y };

        /// <summary>
        /// Computes the product of a vector and a scalar.
        /// </summary>
        public TSelf IMul(TBase scalar)
            => new TSelf { X = X * scalar, Y = Y * scalar };

        /// <inheritdoc cref="IMul(TBase)"/>
        public TVFloat IFMul(TFloat scalar)
            => new TVFloat { X = ToTFloat(X) * scalar, Y = ToTFloat(Y) * scalar };

        /// <summary>
        /// Computes the Hadamar inverse product (division) of two vectors, also known as the component-wise inverse product (<see href="https://en.wikipedia.org/wiki/Hadamard_product_(matrices)"/>).
        /// </summary>
        public TSelf IDiv(in TSelf other)
            => new TSelf { X = X / other.X, Y = Y / other.Y };

        /// <summary>
        /// Computes the division of a vector by a scalar.
        /// </summary>
        public TSelf IDiv(TBase scalar)
            => new TSelf { X = X / scalar, Y = Y / scalar };

        /// <inheritdoc cref="IDiv(TBase)"/>
        public TVFloat IFDiv(TFloat scalar)
            => new TVFloat { X = ToTFloat(X) / scalar, Y = ToTFloat(Y) / scalar };

        /// <summary>
        /// Computes whether two vectors are equal.
        /// </summary>
        public bool IEquals(in TSelf other) => X == other.X && Y == other.Y;

        /// <inheritdoc cref="IEquals(in TSelf)"/>
        public static virtual bool operator ==(in TSelf lhs, in TSelf rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Computes whether two vectors are not equal.
        /// </summary>
        public static virtual bool operator !=(in TSelf lhs, in TSelf rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public bool IEquals(in object? obj) => obj is TSelf other && IEquals(other);

        /// <inheritdoc cref="object.GetHashCode"/>
        public int IGetHashCode() => ((object)this).GetHashCode();

        /// <inheritdoc cref="ToString"/>
        public string IToString() => $"<{X}, {Y}>";

        private static TFloat ToTFloat(double d) => (TFloat)Convert.ChangeType(d, typeof(TFloat));

        private static TFloat ToTFloat(TBase b) => (TFloat)Convert.ChangeType(b, typeof(TFloat));
    }
}
