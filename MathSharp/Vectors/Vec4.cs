namespace MathSharp
{
    /// <summary>
    /// A 4d vector of type int.
    /// </summary>
    public struct Vec4 : IEquatable<Vec4>
    {
        /// <inheritdoc cref="FVec4.X"/>
        public int X { get; set; }

        /// <inheritdoc cref="FVec4.Y"/>
        public int Y { get; set; }

        /// <inheritdoc cref="FVec4.Z"/>
        public int Z { get; set; }

        /// <inheritdoc cref="FVec4.W"/>
        public int W { get; set; }

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

        /// <inheritdoc cref="FVec4.XW"/>
        public Vec2 XW
        {
            get
            {
                return new Vec2(X, W);
            }
            set
            {
                X = value.X;
                W = value.Y;
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

        /// <inheritdoc cref="FVec4.YW"/>
        public Vec2 YW
        {
            get
            {
                return new Vec2(Y, W);
            }
            set
            {
                Y = value.X;
                W = value.Y;
            }
        }

        /// <inheritdoc cref="FVec4.XYZ"/>
        public Vec3 XYZ
        {
            get
            {
                return new Vec3(X, Y, Z);
            }
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <inheritdoc cref="FVec4.XYW"/>
        public Vec3 XYW
        {
            get
            {
                return new Vec3(X, Y, W);
            }
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <inheritdoc cref="FVec4.XZW"/>
        public Vec3 XZW
        {
            get
            {
                return new Vec3(X, Z, W);
            }
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <inheritdoc cref="FVec4.YZW"/>
        public Vec3 YZW
        {
            get
            {
                return new Vec3(Y, Z, W);
            }
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <inheritdoc cref="FVec4.Components"/>
        public int[] Components => new[] { X, Y, Z, W };

        /// <inheritdoc cref="FVec4(double, double, double, double)"/>
        public Vec4(int x, int y, int z, int w) { X = x; Y = y; Z = z; W = w; }

        /// <inheritdoc cref="FVec4.this[int]"/>
        public int this[int i]
        {
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
                    case 3:
                        return W;
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
                    case 3:
                        W = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        /// <inheritdoc cref="FVec4.Mag2"/>
        public int Mag2()
        {
            return X * X + Y * Y + Z * Z + W * W;
        }

        /// <inheritdoc cref="FVec4.Mag"/>
        public double Mag()
        {
            return Math.Sqrt(Mag2());
        }

        /// <inheritdoc cref="FVec4.Dot(FVec4)"/>
        public int Dot(Vec4 other)
        {
            return X * other.X + Y * other.Y + Z * other.Z + W * other.W;
        }

        /// <summary>
        /// Converts a int vector to a float vector by integer casting the components.
        /// </summary>
        public static implicit operator FVec4(Vec4 vec)
        {
            return new FVec4(vec.X, vec.Y, vec.Z, vec.W);
        }

        /// <inheritdoc cref="FVec4.operator +(FVec4, FVec4)"/>
        public static Vec4 operator +(Vec4 lhs, Vec4 rhs)
        {
            return new Vec4(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
        }

        /// <inheritdoc cref="FVec4.operator -(FVec4, FVec4)"/>
        public static Vec4 operator -(Vec4 lhs, Vec4 rhs)
        {
            return new Vec4(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, FVec4)"/>
        public static Vec4 operator *(Vec4 lhs, Vec4 rhs)
        {
            return new Vec4(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z, lhs.W * rhs.W);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, double)"/>
        public static Vec4 operator *(Vec4 lhs, int scalar)
        {
            return new Vec4(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar, lhs.W * scalar);
        }

        /// <inheritdoc cref="FVec4.operator *(FVec4, double)"/>
        public static FVec4 operator *(Vec4 lhs, double scalar)
        {
            return new FVec4(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar, lhs.W * scalar);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, FVec4)"/>
        public static Vec4 operator /(Vec4 lhs, Vec4 rhs)
        {
            return new Vec4(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z, lhs.W / rhs.W);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, double)"/>
        public static Vec4 operator /(Vec4 lhs, int scalar)
        {
            return new Vec4(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar, lhs.W / scalar);
        }

        /// <inheritdoc cref="FVec4.operator /(FVec4, double)"/>
        public static FVec4 operator /(Vec4 lhs, double scalar)
        {
            return new FVec4(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar, lhs.W / scalar);
        }

        /// <inheritdoc cref="FVec4.Equals(FVec4)"/>
        public bool Equals(Vec4 other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        /// <inheritdoc cref="Equals(Vec4)"/>
        public static bool operator ==(Vec4 lhs, Vec4 rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <inheritdoc cref="FVec4.operator !=(FVec4, FVec4)"/>
        public static bool operator !=(Vec4 lhs, Vec4 rhs)
        {
            return !lhs.Equals(rhs);
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj)
        {
            return obj is Vec4 && Equals((Vec4)obj);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return ((object)this).GetHashCode();
        }
    }
}
