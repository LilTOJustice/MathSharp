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
    public interface IVec2<TSelf, TBase, TFloat, TVFloat>
        where TSelf :
        struct,
        IVec2<TSelf, TBase, TFloat, TVFloat>,
        ISwizzlable<TSelf, TBase>,
        IEquatable<TSelf>
        where TBase : INumber<TBase>
        where TFloat : IFloatingPoint<TFloat>
        where TVFloat :
        struct,
        IVec2<TVFloat, TFloat, TFloat, TVFloat>,
        ISwizzlable<TVFloat, TFloat>,
        IEquatable<TVFloat>
    {
        private static Dictionary<char, int> swizzleDict = new Dictionary<char, int>
        {
            { 'x', 0 },
            { 'y', 1 },
        };

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
        /// For swizzling vectors. <see href="https://en.wikipedia.org/wiki/Swizzling_(computer_graphics)"/>.
        /// I.e. Vec2 v = vec3["yz"];
        /// </summary>
        public Swizzle<TBase> this[string swizzle] { get; set; }

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
        public static TBase[] IComponents(in TSelf self) => new[] { self.X, self.Y };

        /// <inheritdoc cref="this[int]"/>
        public static TBase IIndexerGet(in TSelf self, int i)
        {
            switch (i)
            {
                case 0:
                    return self.X;
                case 1:
                    return self.Y;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        /// <inheritdoc cref="this[int]"/>
        public static void IIndexerSet(ref TSelf self, int i, TBase value)
        {
            switch (i)
            {
                case 0:
                    self.X = value;
                    break;
                case 1:
                    self.Y = value;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        /// <inheritdoc cref="this[string]"/>
        public static Swizzle<TBase> ISwizzleGet(in TSelf self, string swizzle)
        {
            return new Swizzle<TBase>(self.Components, swizzle);
        }

        /// <inheritdoc cref="this[string]"/>
        public static void ISwizzleSet(
            ref TSelf self,
            string swizzleString,
            Swizzle<TBase> swizzle,
            Dictionary<char, int>? swizzleIndicesOverride = null)
        {
            Dictionary <char, int> swizzleIndices = swizzleIndicesOverride ?? swizzleDict;
            if (swizzleString.Length > 2)
            {
                throw new SwizzleException(2, swizzleString.Length);
            }

            if (swizzle.SwizzleString.Length != swizzleString.Length)
            {
                throw new SwizzleException(swizzleString.Length, swizzle.SwizzleString.Length);
            }

            for (int i = 0; i < swizzle.SwizzleString.Length; i++)
            {
                    try
                    {
                        self[swizzleIndices[swizzleString[i]]] = swizzle.Container[swizzleIndices[swizzle.SwizzleString[i]]];
                    }
                    catch (KeyNotFoundException)
                    {
                        throw new SwizzleException(swizzleString[i]);
                    }
            }
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.implicit operator TSelf"/>
        public static TSelf ISwizzleToSelf(
            Swizzle<TBase> swizzle,
            Dictionary<char, int>? swizzleIndicesOverride = null)
        {
            Dictionary<char, int> swizzleIndices = swizzleIndicesOverride ?? swizzleDict;
            if (swizzle.SwizzleString.Length != 2)
            {
                throw new SwizzleException(2, swizzle.SwizzleString.Length);
            }

            TSelf result = new TSelf { };
            for (int i = 0; i < swizzle.SwizzleString.Length; i++)
            {
                try
                {
                    result[i] = swizzle.Container[swizzleIndices[swizzle.SwizzleString[i]]];
                }
                catch (KeyNotFoundException)
                {
                    throw new SwizzleException(swizzle.SwizzleString[i]);
                }
            }

            return result;
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.implicit operator Swizzle{TBase}"/>
        public static Swizzle<TBase> ISelfToSwizzle(in TSelf self, string fullSwizzle)
        {
            return new Swizzle<TBase>(self.Components, fullSwizzle);
        }

        /// <inheritdoc cref="Rotate(IAngle)"/>
        public static TVFloat IRotate(in TSelf self, IAngle angle)
            => new TVFloat
            {
                X = ToTFloat(self.X) * ToTFloat(Math.Cos(angle.Radians)) -
                ToTFloat(self.Y) * ToTFloat(Math.Sin(angle.Radians)),
                Y = ToTFloat(self.X) * ToTFloat(Math.Sin(angle.Radians)) +
                ToTFloat(self.Y) * ToTFloat(Math.Cos(angle.Radians))
            };

        /// <inheritdoc cref="Mag2"/>
        public static TBase IMag2(in TSelf self) => self.X * self.X + self.Y * self.Y;

        /// <inheritdoc cref="Mag"/>
        public static TFloat IMag(in TSelf self) => ToTFloat(Math.Sqrt(Convert.ToDouble(self.Mag2())));

        /// <inheritdoc cref="Dot"/>
        public static TBase IDot(in TSelf self, in TSelf other) => self.X * other.X + self.Y * other.Y;

        /// <inheritdoc cref="Cross2d"/>
        public static TBase ICross2d(in TSelf self, in TSelf other) => self.X * other.Y - self.Y * other.X;

        /// <inheritdoc cref="Norm"/>
        public static TVFloat INorm(in TSelf self) => IFDiv(self, self.Mag());

        /// <summary>
        /// Computes the sum of two vectors.
        /// </summary>
        public static TSelf IAdd(in TSelf self, in TSelf other)
            => new TSelf { X = self.X + other.X, Y = self.Y + other.Y };

        /// <summary>
        /// Computes the difference of two vectors.
        /// </summary>
        public static TSelf ISub(in TSelf self, in TSelf other)
            => new TSelf { X = self.X - other.X, Y = self.Y - other.Y };

        /// <summary>
        /// Computes the Hadamard product of two vectors, also known as the component-wise product (<see href="https://en.wikipedia.org/wiki/Hadamard_product_(matrices)"/>).
        /// </summary>
        public static TSelf IMul(in TSelf self, in TSelf other)
            => new TSelf { X = self.X * other.X, Y = self.Y * other.Y };

        /// <summary>
        /// Computes the product of a vector and a scalar.
        /// </summary>
        public static TSelf IMul(in TSelf self, TBase scalar)
            => new TSelf { X = self.X * scalar, Y = self.Y * scalar };

        /// <inheritdoc cref="IMul(in TSelf, TBase)"/>
        public static TVFloat IFMul(in TSelf self, TFloat scalar)
            => new TVFloat { X = ToTFloat(self.X) * scalar, Y = ToTFloat(self.Y) * scalar };

        /// <summary>
        /// Computes the Hadamar inverse product (division) of two vectors, also known as the component-wise inverse product (<see href="https://en.wikipedia.org/wiki/Hadamard_product_(matrices)"/>).
        /// </summary>
        public static TSelf IDiv(in TSelf self, in TSelf other)
            => new TSelf { X = self.X / other.X, Y = self.Y / other.Y };

        /// <summary>
        /// Computes the division of a vector by a scalar.
        /// </summary>
        public static TSelf IDiv(in TSelf self, TBase scalar)
            => new TSelf { X = self.X / scalar, Y = self.Y / scalar };

        /// <inheritdoc cref="IDiv(in TSelf, TBase)"/>
        public static TVFloat IFDiv(in TSelf self, TFloat scalar)
            => new TVFloat { X = ToTFloat(self.X) / scalar, Y = ToTFloat(self.Y) / scalar };

        /// <summary>
        /// Computes whether two vectors are equal.
        /// </summary>
        public static bool IEquals(in TSelf self, in TSelf other) => self.X == other.X && self.Y == other.Y;

        /// <inheritdoc cref="object.Equals(object?)"/>
        public static bool IEquals(in TSelf self, in object? obj) => obj is TSelf other && IEquals(self, other);

        /// <inheritdoc cref="object.GetHashCode"/>
        public static int IGetHashCode(in TSelf self) => ((object)self).GetHashCode();

        /// <inheritdoc cref="ToString"/>
        public static string IToString(in TSelf self) => $"<{self.X}, {self.Y}>";

        private static TFloat ToTFloat(double d) => (TFloat)Convert.ChangeType(d, typeof(TFloat));

        private static TFloat ToTFloat(TBase b) => (TFloat)Convert.ChangeType(b, typeof(TFloat));
    }
}
