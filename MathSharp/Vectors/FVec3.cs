namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type double.
    /// </summary>
    public struct FVec3 : IEquatable<FVec3>
    {
        /// <inheritdoc cref="FVec4.X"/>
        public double X { get; set; }

        /// <inheritdoc cref="FVec4.Y"/>
        public double Y { get; set; }

        /// <inheritdoc cref="FVec4.Z"/>
        public double Z { get; set; }

        /// <inheritdoc cref="FVec4.XY"/>
        public FVec2 XY
        {
            get
            {
                return new FVec2(X, Y);
            }
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <inheritdoc cref="FVec4.XZ"/>
        public FVec2 XZ
        {
            get
            {
                return new FVec2(X, Z);
            }
            set
            {
                X = value.X;
                Z = value.Y;
            }
        }

        /// <inheritdoc cref="FVec4.YZ"/>
        public FVec2 YZ
        {
            get
            {
                return new FVec2(Y, Z);
            }
            set
            {
                Y = value.X;
                Z = value.Y;
            }
        }

        /// <inheritdoc cref="FVec4.Components"/>
        public double[] Components => new[] { X, Y, Z };

        /// <inheritdoc cref="FVec4(double, double, double, double)"/>
        public FVec3(double x, double y, double z) { X = x; Y = y; Z = z; }

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
                    case 2:
                        return Z;
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
                    case 2:
                        Z = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        /// <inheritdoc cref="FVec4.Mag2"/>
        public double Mag2()
        {
            return X * X + Y * Y + Z * Z;
        }

        /// <inheritdoc cref="FVec4.Mag"/>
        public double Mag()
        {
            return Math.Sqrt(Mag2());
        }

        /// <inheritdoc cref="FVec4.Dot"/>
        public double Dot(FVec3 other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        /// <summary>
        /// Computes the cross product between two vectors.
        /// </summary>
        public FVec3 Cross(FVec3 rhs)
        {
            return new FVec3(
                Y * rhs.Z - Z * rhs.Y,
                Z * rhs.X - X * rhs.Z,
                X * rhs.Y - Y * rhs.X);
        }

        /// <inheritdoc cref="FVec4.explicit operator Vec4(FVec4)"/>
        public static explicit operator Vec3(FVec3 vec)
        {
            return new Vec3((int)vec.X, (int)vec.Y, (int)vec.Z);
        }

        /// <inheritdoc cref="FVec4.operator +(FVec4, FVec4)"/>
        public static FVec3 operator +(FVec3 lhs, FVec3 rhs)
        {
            return new FVec3(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        /// <inheritdoc cref="FVec4.operator -(FVec4, FVec4)"/>
        public static FVec3 operator -(FVec3 lhs, FVec3 rhs)
        {
            return new FVec3(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, FVec4)"/>
        public static FVec3 operator *(FVec3 lhs, FVec3 rhs)
        {
            return new FVec3(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, double)"/>
        public static FVec3 operator *(FVec3 lhs, double scalar)
        {
            return new FVec3(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, FVec4)"/>
        public static FVec3 operator /(FVec3 lhs, FVec3 rhs)
        {
            return new FVec3(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, double)"/>
        public static FVec3 operator /(FVec3 lhs, double scalar)
        {
            return new FVec3(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar);
        }

        /// <inheritdoc cref="FVec4.Equals(FVec4)"/>
        public bool Equals(FVec3 other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        /// <inheritdoc cref="Equals(FVec3)"/>
        public static bool operator ==(FVec3 lhs, FVec3 rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <inheritdoc cref="FVec4.operator !=(FVec4, FVec4)"/>
        public static bool operator !=(FVec3 lhs, FVec3 rhs)
        {
            return !lhs.Equals(rhs);
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj)
        {
            return obj is FVec3 && Equals((FVec3)obj);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return ((object)this).GetHashCode();
        }
    }
}
