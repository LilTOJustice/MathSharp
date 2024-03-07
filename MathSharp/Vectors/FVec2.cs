namespace MathSharp
{
    /// <summary>
    /// A 2d vector of type double.
    /// </summary>
    public struct FVec2 : IEquatable<FVec2>
    {
        /// <inheritdoc cref="FVec4.X"/>
        public double X { get; set; }

        /// <inheritdoc cref="FVec4.Y"/>
        public double Y { get; set; }

        /// <inheritdoc cref="FVec4.Components"/>
        public double[] Components => new[] { X, Y };

        /// <inheritdoc cref="FVec4(double, double, double, double)"/>
        public FVec2(double x, double y) { X = x; Y = y; }

        /// <inheritdoc cref="FVec4.this[int]"/>
        public double this[int i] {
            get
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
            set
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
        }

        /// <summary>
        /// Computes the rotated vector by the given angle.
        /// </summary>
        /// <returns>A new vector with the result of the rotation.</returns>
        public FVec2 Rotate(IAngle angle)
        {
            return new FVec2(
                X * Math.Cos(angle.Radians) - Y * Math.Sin(angle.Radians),
                X * Math.Sin(angle.Radians) + Y * Math.Cos(angle.Radians));
        }

        /// <inheritdoc cref="FVec4.Mag2"/>
        public double Mag2()
        {
            return X * X + Y * Y;
        }

        /// <inheritdoc cref="FVec4.Mag"/>
        public double Mag()
        {
            return Math.Sqrt(Mag2());
        }

        /// <inheritdoc cref="FVec4.Dot"/>
        public double Dot(FVec2 other)
        {
            return X * other.X + Y * other.Y;
        }

        /// <summary>
        /// Computes the 2d (scalar) cross product between two vectors <see href="https://en.wikipedia.org/wiki/Cross_product"/>.
        /// </summary>
        public double Cross2d(FVec2 rhs)
        {
            return X * rhs.Y - Y * rhs.X;
        }

        /// <summary>
        /// Computes the cross product between two vectors.
        /// </summary>
        /// <returns>A 3d vector orthogonal to the xy plane.</returns>
        public FVec3 Cross(FVec2 rhs)
        {
            return new FVec3(0, 0, Cross2d(rhs));
        }

        /// <inheritdoc cref="FVec4.explicit operator Vec4(FVec4)"/>
        public static explicit operator Vec2(FVec2 vec)
        {
            return new Vec2((int)vec.X, (int)vec.Y);
        }

        /// <inheritdoc cref="FVec4.operator +(FVec4, FVec4)"/>
        public static FVec2 operator +(FVec2 lhs, FVec2 rhs)
        {
            return new FVec2(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        /// <inheritdoc cref="FVec4.operator -(FVec4, FVec4)"/>
        public static FVec2 operator -(FVec2 lhs, FVec2 rhs)
        {
            return new FVec2(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, FVec4)"/>
        public static FVec2 operator *(FVec2 lhs, FVec2 rhs)
        {
            return new FVec2(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, double)"/>
        public static FVec2 operator *(FVec2 lhs, double scalar)
        {
            return new FVec2(lhs.X * scalar, lhs.Y * scalar);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, FVec4)"/>
        public static FVec2 operator /(FVec2 lhs, FVec2 rhs)
        {
            return new FVec2(lhs.X / rhs.X, lhs.Y / rhs.Y);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, double)"/>
        public static FVec2 operator /(FVec2 lhs, double scalar)
        {
            return new FVec2(lhs.X / scalar, lhs.Y / scalar);
        }

        /// <inheritdoc cref="FVec4.Equals(FVec4)"/>
        public bool Equals(FVec2 other)
        {
            return X == other.X && Y == other.Y;
        }

        /// <inheritdoc cref="Equals(FVec2)"/>
        public static bool operator ==(FVec2 lhs, FVec2 rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <inheritdoc cref="FVec4.Equals(FVec4)"/>
        public static bool operator !=(FVec2 lhs, FVec2 rhs)
        {
            return !lhs.Equals(rhs);
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj)
        {
            return obj is FVec2 && Equals((FVec2)obj);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return ((object)this).GetHashCode();
        }
    }
}
