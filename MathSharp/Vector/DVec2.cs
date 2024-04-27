namespace MathSharp
{
    /// <summary>
    /// A 2d vector of type Degree.
    /// </summary>
    public struct DVec2 : IVec2<DVec2, Degree, Degree, DVec2>, ISwizzlable<DVec2, Degree>, IEquatable<DVec2>
    {
        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.X"/>
        public Degree X { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public Degree Y { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public Degree[] Components => IVec2<DVec2, Degree, Degree, DVec2>.IComponents(this);

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.SwizzleMap"/>
        public static Dictionary<char, int> SwizzleMap => new Dictionary<char, int>
        {
            { 'x', 0 },
            { 'y', 1 }
        };

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public Degree this[int i]
        {
            get => IVec2<DVec2, Degree, Degree, DVec2>.IIndexerGet(this, i);
            set => IVec2<DVec2, Degree, Degree, DVec2>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public Degree[] this[string swizzle]
        {
            get => IVec2<DVec2, Degree, Degree, DVec2>.ISwizzleGet(this, swizzle);
            set => IVec2<DVec2, Degree, Degree, DVec2>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator DVec2(Degree[] swizzle) => IVec2<DVec2, Degree, Degree, DVec2>.ISwizzleToSelf(swizzle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISelfToSwizzle"/>
        public static implicit operator Degree[](in DVec2 vec) => IVec2<DVec2, Degree, Degree, DVec2>.ISelfToSwizzle(vec);

        /// <summary>
        /// Constructs a new 2d vector.
        /// </summary>
        public DVec2(double x, double y) { X = new Degree(x); Y = new Degree(y); }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Rotate"/>
        public DVec2 Rotate(Radian angle) => IVec2<DVec2, Degree, Degree, DVec2>.IRotate(this, angle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public Degree Mag2() => IVec2<DVec2, Degree, Degree, DVec2>.IMag2(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public Degree Mag() => IVec2<DVec2, Degree, Degree, DVec2>.IMag(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public Degree Dot(in DVec2 other) => IVec2<DVec2, Degree, Degree, DVec2>.IDot(this, other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Cross2d"/>
        public Degree Cross2d(in DVec2 rhs) => IVec2<DVec2, Degree, Degree, DVec2>.ICross2d(this, rhs);

        /// <summary>
        /// Computes the normalized vector.
        /// </summary>
        public DVec2 Norm() => this / Mag();

        /// <summary>
        /// Computes the cross product between two vectors <see href="https://en.wikipedia.org/wiki/Cross_product"/>.
        /// </summary>
        /// <returns>A 3d vector orthogonal to the xy plane.</returns>
        public DVec3 Cross(in DVec2 rhs) => new DVec3(0, 0, Cross2d(rhs).Degrees);

        /// <summary>
        /// Converts a degree vector to a radian vector.
        /// </summary>
        public static implicit operator RVec2(in DVec2 vec) => new RVec2(vec.X.Radians, vec.Y.Radians);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static DVec2 operator +(in DVec2 lhs, in DVec2 rhs) => IVec2<DVec2, Degree, Degree, DVec2>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static DVec2 operator -(in DVec2 lhs, in DVec2 rhs) => IVec2<DVec2, Degree, Degree, DVec2>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static DVec2 operator *(in DVec2 lhs, in DVec2 rhs) => IVec2<DVec2, Degree, Degree, DVec2>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static DVec2 operator *(in DVec2 lhs, double scalar) => new DVec2(lhs.X.Degrees * scalar, lhs.Y.Degrees * scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static DVec2 operator *(double scalar, in DVec2 rhs) => rhs * scalar;

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static DVec2 operator /(in DVec2 lhs, in DVec2 rhs) => IVec2<DVec2, Degree, Degree, DVec2>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static DVec2 operator /(in DVec2 lhs, double scalar) => new DVec2(lhs.X.Degrees / scalar, lhs.Y.Degrees / scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static DVec2 operator /(double scalar, in DVec2 rhs) => new DVec2(scalar / rhs.X.Degrees, scalar / rhs.Y.Degrees);

        /// <inheritdoc cref="Equals(DVec2)"/>
        public static bool operator ==(in DVec2 lhs, in DVec2 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(DVec2)"/>
        public static bool operator !=(in DVec2 lhs, in DVec2 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(DVec2 other) => IVec2<DVec2, Degree, Degree, DVec2>.IEquals(this, other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in object?)"/>
        public override bool Equals(object? obj) => IVec2<DVec2, Degree, Degree, DVec2>.IEquals(this, obj);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IGetHashCode"/>
        public override int GetHashCode() => IVec2<DVec2, Degree, Degree, DVec2>.IGetHashCode(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec2<DVec2, Degree, Degree, DVec2>.IToString(this);
    }
}
