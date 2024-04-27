namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type Degree.
    /// </summary>
    public struct DVec3 : IVec3<DVec3, Degree, Degree, DVec3>, ISwizzlable<DVec3, Degree>, IEquatable<DVec3>
    {
        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.X"/>
        public Degree X { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public Degree Y { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public Degree Z { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public Degree[] Components => IVec3<DVec3, Degree, Degree, DVec3>.IComponents(this);

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.SwizzleMap"/>
        public static Dictionary<char, int> SwizzleMap => new Dictionary<char, int>
            {
                { 'x', 0 },
                { 'y', 1 },
                { 'z', 2 }
            };

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public Degree this[int i] {
            get => IVec3<DVec3, Degree, Degree, DVec3>.IIndexerGet(this, i);
            set => IVec3<DVec3, Degree, Degree, DVec3>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public Degree[] this[string swizzle]
        {
            get => IVec3<DVec3, Degree, Degree, DVec3>.ISwizzleGet(this, swizzle);
            set => IVec3<DVec3, Degree, Degree, DVec3>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator DVec3(Degree[] swizzler) => IVec3<DVec3, Degree, Degree, DVec3>.ISwizzleToSelf(swizzler);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISelfToSwizzle"/>
        public static implicit operator Degree[](in DVec3 vec) => IVec3<DVec3, Degree, Degree, DVec3>.ISelfToSwizzle(vec);

        /// <summary>
        /// Constructs a new 3d vector.
        /// </summary>
        public DVec3(double x, double y, double z) { X = new Degree(x); Y = new Degree(y); Z = new Degree(z); }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Rotate"/>
        public DVec3 Rotate(in RVec3 angle) => IVec3<DVec3, Degree, Degree, DVec3>.IRotate(this, angle);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public Degree Mag2() => IVec3<DVec3, Degree, Degree, DVec3>.IMag2(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public Degree Mag() => IVec3<DVec3, Degree, Degree, DVec3>.IMag(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public Degree Dot(in DVec3 other) => IVec3<DVec3, Degree, Degree, DVec3>.IDot(this, other);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Cross"/>
        public DVec3 Cross(in DVec3 rhs) => IVec3<DVec3, Degree, Degree, DVec3>.ICross(this, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public DVec3 Norm() => IVec3<DVec3, Degree, Degree, DVec3>.INorm(this);

        /// <summary>
        /// Converts a degree vector to a radian vector.
        /// </summary>
        public static implicit operator RVec3(in DVec3 vec) => new RVec3(vec.X.Radians, vec.Y.Radians, vec.Z.Radians);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static DVec3 operator +(in DVec3 lhs, in DVec3 rhs) => IVec3<DVec3, Degree, Degree, DVec3>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static DVec3 operator -(in DVec3 lhs, in DVec3 rhs) => IVec3<DVec3, Degree, Degree, DVec3>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static DVec3 operator *(in DVec3 lhs, in DVec3 rhs) => IVec3<DVec3, Degree, Degree, DVec3>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static DVec3 operator *(in DVec3 lhs, double scalar) => new DVec3(lhs.X.Degrees * scalar, lhs.Y.Degrees * scalar, lhs.Y.Degrees * scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static DVec3 operator *(double scalar, in DVec3 rhs) => rhs * scalar;

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static DVec3 operator /(in DVec3 lhs, in DVec3 rhs) => IVec3<DVec3, Degree, Degree, DVec3>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static DVec3 operator /(in DVec3 lhs, double scalar) => new DVec3(lhs.X.Degrees / scalar, lhs.Y.Degrees / scalar, lhs.Y.Degrees / scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static DVec3 operator /(double scalar, in DVec3 rhs) => new DVec3(scalar / rhs.X.Degrees, scalar / rhs.Y.Degrees, scalar / rhs.Z.Degrees );

        /// <inheritdoc cref="Equals(DVec3)"/>
        public static bool operator ==(in DVec3 lhs, in DVec3 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(DVec3)"/>
        public static bool operator !=(in DVec3 lhs, in DVec3 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(DVec3 other) => IVec3<DVec3, Degree, Degree, DVec3>.IEquals(this, other);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => IVec3<DVec3, Degree, Degree, DVec3>.IEquals(this, obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => IVec3<DVec3, Degree, Degree, DVec3>.IGetHashCode(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec3<DVec3, Degree, Degree, DVec3>.IToString(this);
    }
}
