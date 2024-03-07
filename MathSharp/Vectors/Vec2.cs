namespace MathSharp
{
    /// <summary>
    /// A 2d vector of type int.
    /// </summary>
    public struct Vec2 : IEquatable<Vec2>
    {
        /// <inheritdoc cref="FVec4.X"/>
        public int X { get; set; }

        /// <inheritdoc cref="FVec4.Y"/>
        public int Y { get; set; }

        /// <inheritdoc cref="FVec4.Components"/>
        public int[] Components => new int[] { X, Y };

        /// <inheritdoc cref="FVec4(double, double, double, double)"/>
        public Vec2(int x, int y) { X = x; Y = y; }

        /// <inheritdoc cref="FVec4.this[int]"/>
        public int this[int i] {
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

        /// <inheritdoc cref="FVec2.Rotate(IAngle)"/>
        public FVec2 Rotate(IAngle angle)
        {
            return new FVec2(
                X * Math.Cos(angle.Radians) - Y * Math.Sin(angle.Radians),
                X * Math.Sin(angle.Radians) + Y * Math.Cos(angle.Radians));
        }

        /// <inheritdoc cref="FVec4.Equals(FVec4)"/>
        public int Mag2()
        {
            return X * X + Y * Y;
        }

        /// <inheritdoc cref="FVec4.Mag"/>
        public double Mag()
        {
            return Math.Sqrt(Mag2());
        }

        /// <inheritdoc cref="FVec4.Dot"/>
        public int Dot(Vec2 other)
        {
            return X * other.X + Y * other.Y;
        }

        /// <inheritdoc cref="FVec2.Cross2d"/>
        public int Cross2d(Vec2 rhs)
        {
            return X * rhs.Y - Y * rhs.X;
        }

        /// <inheritdoc cref="FVec2.Cross"/>
        public Vec3 Cross(Vec2 rhs)
        {
            return new Vec3(0, 0, Cross2d(rhs));
        }

        /// <inheritdoc cref="Vec4.implicit operator FVec4(Vec4)"/>
        public static implicit operator FVec2(Vec2 vec)
        {
            return new FVec2(vec.X, vec.Y);
        }

        /// <inheritdoc cref="FVec4.operator +(FVec4, FVec4)"/>
        public static Vec2 operator +(Vec2 lhs, Vec2 rhs)
        {
            return new Vec2(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        /// <inheritdoc cref="FVec4.operator -(FVec4, FVec4)"/>
        public static Vec2 operator -(Vec2 lhs, Vec2 rhs)
        {
            return new Vec2(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, FVec4)"/>
        public static Vec2 operator *(Vec2 lhs, Vec2 rhs)
        {
            return new Vec2(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, double)"/>
        public static Vec2 operator *(Vec2 lhs, int scalar)
        {
            return new Vec2(lhs.X * scalar, lhs.Y * scalar);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, double)"/>
        public static FVec2 operator *(Vec2 lhs, double scalar)
        {
            return new FVec2(lhs.X * scalar, lhs.Y * scalar);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, FVec4)"/>
        public static Vec2 operator /(Vec2 lhs, Vec2 rhs)
        {
            return new Vec2(lhs.X / rhs.X, lhs.Y / rhs.Y);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, double)"/>
        public static Vec2 operator /(Vec2 lhs, int scalar)
        {
            return new Vec2(lhs.X / scalar, lhs.Y / scalar);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, double)"/>
        public static FVec2 operator /(Vec2 lhs, double scalar)
        {
            return new FVec2(lhs.X / scalar, lhs.Y / scalar);
        }

        /// <inheritdoc cref="FVec4.Equals(FVec4)"/>
        public bool Equals(Vec2 other)
        {
            return X == other.X && Y == other.Y;
        }

        /// <inheritdoc cref="Equals(Vec2)"/>
        public static bool operator ==(Vec2 lhs, Vec2 rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <inheritdoc cref="FVec4.operator !=(FVec4, FVec4)"/>
        public static bool operator !=(Vec2 lhs, Vec2 rhs)
        {
            return !lhs.Equals(rhs);
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj)
        {
            return obj is Vec2 && Equals((Vec2)obj);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return ((object)this).GetHashCode();
        }
    }
}
