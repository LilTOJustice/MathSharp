namespace MathSharp
{
    /// <summary>
    /// A 4d vector of type double.
    /// </summary>
    public struct FVec4 : IEquatable<FVec4>
    {
        /// <summary>
        /// The x component of the vector.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// The y component of the vector.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// The z component of the vector.
        /// </summary>
        public double Z { get; set; }

        /// <summary>
        /// The w component of the vector.
        /// </summary>
        public double W { get; set; }

        /// <summary>
        /// A vector representing the x and y components of the vector.
        /// </summary>
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

        /// <summary>
        /// A vector representing the x and z components of the vector.
        /// </summary>
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

        /// <summary>
        /// A vector representing the x and w components of the vector.
        /// </summary>
        public FVec2 XW
        {
            get
            {
                return new FVec2(X, W);
            }
            set
            {
                X = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// A vecctor representing the y and z components of the vector.
        /// </summary>
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

        /// <summary>
        /// A vector representing the y and w components of the vector.
        /// </summary>
        public FVec2 YW
        {
            get
            {
                return new FVec2(Y, W);
            }
            set
            {
                Y = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// A vector representing the x, y and z components of the vector.
        /// </summary>
        public FVec3 XYZ
        {
            get
            {
                return new FVec3(X, Y, Z);
            }
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// A vector representing the x, y and w components of the vector.
        /// </summary>
        public FVec3 XYW
        {
            get
            {
                return new FVec3(X, Y, W);
            }
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// A vector representing the x, z and w components of the vector.
        /// </summary>
        public FVec3 XZW
        {
            get
            {
                return new FVec3(X, Z, W);
            }
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// A vector representing the y, z and w components of the vector.
        /// </summary>
        public FVec3 YZW
        {
            get
            {
                return new FVec3(Y, Z, W);
            }
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// A new array containing the components of the vector.
        /// </summary>
        public double[] Components => new[] { X, Y, Z, W };

        /// <summary>
        /// Creates a new vector with the given components.
        /// </summary>
        public FVec4(double x, double y, double z, double w) { X = x; Y = y; Z = z; W = w; }

        /// <summary>
        /// Access the <paramref name="i"/>th component of the vector.
        /// </summary>
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

        /// <summary>
        /// Squared magnitude of the vector.
        /// </summary>
        public double Mag2()
        {
            return X * X + Y * Y + Z * Z + W * W;
        }

        /// <summary>
        /// Magnitude of the vector.
        /// </summary>
        public double Mag()
        {
            return Math.Sqrt(Mag2());
        }

        /// <summary>
        /// Computes the dot product of this vector and <paramref name="other"/>.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public double Dot(FVec4 other)
        {
            return X * other.X + Y * other.Y + Z * other.Z + W * other.W;
        }

        /// <summary>
        /// Converts a float vector to an int vector by integer casting the components.
        /// </summary>
        public static explicit operator Vec4(FVec4 vec)
        {
            return new Vec4((int)vec.X, (int)vec.Y, (int)vec.Z, (int)vec.W);
        }

        /// <summary>
        /// Computes addition between two vectors.
        /// </summary>
        public static FVec4 operator +(FVec4 lhs, FVec4 rhs)
        {
            return new FVec4(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
        }

        /// <summary>
        /// Computes subtraction between two vectors.
        /// </summary>
        public static FVec4 operator -(FVec4 lhs, FVec4 rhs)
        {
            return new FVec4(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);
        }

        /// <summary>
        /// Computes the hadamard product between two vectors (<see href="https://en.wikipedia.org/wiki/Hadamard_product_(matrices)"/>).
        /// </summary>
        public static FVec4 operator *(FVec4 lhs, FVec4 rhs)
        {
            return new FVec4(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z, lhs.W * rhs.W);
        }

        /// <summary>
        /// Computes the scalar product between a vector and a scalar.
        /// </summary>
        public static FVec4 operator *(FVec4 lhs, double scalar)
        {
            return new FVec4(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar, lhs.W * scalar);
        }

        /// <summary>
        /// Computes the Hadamard division between two vectors (<see href="https://en.wikipedia.org/wiki/Hadamard_product_(matrices)"/>).
        /// </summary>
        public static FVec4 operator /(FVec4 lhs, FVec4 rhs)
        {
            return new FVec4(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z, lhs.W / rhs.W);
        }

        /// <summary>
        /// Computes scalar division between a vector and a scalar.
        /// </summary>
        public static FVec4 operator /(FVec4 lhs, double scalar)
        {
            return new FVec4(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar, lhs.W / scalar);
        }

        /// <summary>
        /// Equality comparison between two vectors.
        /// </summary>
        public bool Equals(FVec4 other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        /// <inheritdoc cref="Equals(FVec4)"/>
        public static bool operator ==(FVec4 lhs, FVec4 rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Inequality comparison between two vectors.
        /// </summary>
        public static bool operator !=(FVec4 lhs, FVec4 rhs)
        {
            return !lhs.Equals(rhs);
        }

        /// <summary>
        /// Object equality comparison.
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FVec4 && Equals((FVec4)obj);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return ((object)this).GetHashCode();
        }
    }
}
