namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type int.
    /// </summary>
    public struct Vec3 : IEquatable<Vec3>
    {
        /// <inheritdoc cref="FVec4.X"/>
        public int X { get; set; }

        /// <inheritdoc cref="FVec4.Y"/>
        public int Y { get; set; }

        /// <inheritdoc cref="FVec4.Z"/>
        public int Z { get; set; }

        /// <inheritdoc cref="FVec4.XY"/>
        public Vec2 XY
        {
            get
            {
                return new Vec2(X, Y);
            }
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <inheritdoc cref="FVec4.XZ"/>
        public Vec2 XZ
        {
            get
            {
                return new Vec2(X, Z);
            }
            set
            {
                X = value.X;
                Z = value.Y;
            }
        }

        /// <inheritdoc cref="FVec4.YZ"/>
        public Vec2 YZ
        {
            get
            {
                return new Vec2(Y, Z);
            }
            set
            {
                Y = value.X;
                Z = value.Y;
            }
        }

        /// <inheritdoc cref="FVec4.Components"/>
        public int[] Components => new int[] { X, Y, Z };

        /// <inheritdoc cref="FVec4(double, double, double, double)"/>
        public Vec3(int x, int y, int z) { X = x; Y = y; Z = z; }

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
        public int Mag2()
        {
            return X * X + Y * Y + Z * Z;
        }

        /// <inheritdoc cref="FVec4.Mag"/>
        public double Mag()
        {
            return Math.Sqrt(Mag2());
        }

        /// <inheritdoc cref="FVec4.Dot(FVec4)"/>
        public int Dot(Vec3 other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        /// <inheritdoc cref="FVec3.Cross(FVec3)"/>
        public Vec3 Cross(Vec3 rhs)
        {
            return new Vec3(
                Y * rhs.Z - Z * rhs.Y,
                Z * rhs.X - X * rhs.Z,
                X * rhs.Y - Y * rhs.X);
        }

        /// <inheritdoc cref="Vec4.implicit operator FVec4(Vec4)"/>
        public static implicit operator FVec3(Vec3 vec)
        {
            return new FVec3(vec.X, vec.Y, vec.Z);
        }

        /// <inheritdoc cref="FVec4.operator +(FVec4, FVec4)"/>
        public static Vec3 operator +(Vec3 lhs, Vec3 rhs)
        {
            return new Vec3(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        /// <inheritdoc cref="FVec4.operator -(FVec4, FVec4)"/>
        public static Vec3 operator -(Vec3 lhs, Vec3 rhs)
        {
            return new Vec3(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, FVec4)"/>
        public static Vec3 operator *(Vec3 lhs, Vec3 rhs)
        {
            return new Vec3(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, double)"/>
        public static Vec3 operator *(Vec3 lhs, int scalar)
        {
            return new Vec3(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, double)"/>
        public static FVec3 operator *(Vec3 lhs, double scalar)
        {
            return new FVec3(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, FVec4)"/>
        public static Vec3 operator /(Vec3 lhs, Vec3 rhs)
        {
            return new Vec3(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, double)"/>
        public static Vec3 operator /(Vec3 lhs, int scalar)
        {
            return new Vec3(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, double)"/>
        public static FVec3 operator /(Vec3 lhs, double scalar)
        {
            return new FVec3(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar);
        }

        /// <inheritdoc cref="FVec4.Equals(FVec4)"/>
        public bool Equals(Vec3 other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        /// <inheritdoc cref="Equals(Vec3)"/>
        public static bool operator ==(Vec3 lhs, Vec3 rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <inheritdoc cref="FVec4.operator !=(FVec4, FVec4)"/>
        public static bool operator !=(Vec3 lhs, Vec3 rhs)
        {
            return !lhs.Equals(rhs);
        }

        /// <inheritdoc cref="FVec4.Equals(object?)"/>
        public override bool Equals(object? obj)
        {
            return obj is Vec3 && Equals((Vec3)obj);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return ((object)this).GetHashCode();
        }
    }
}
