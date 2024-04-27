namespace MathSharp
{
    /// <summary>
    /// A 2d vector of type Radian.
    /// </summary>
    public struct RVec2 : IVec2<RVec2, Radian, double, FVec2>, ISwizzlable<RVec2, Radian>, IEquatable<RVec2>
    {
        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.X"/>
        public Radian X { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public Radian Y { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public Radian[] Components => IVec2<RVec2, Radian, double, FVec2>.IComponents(this);

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.SwizzleMap"/>
        public static Dictionary<char, int> SwizzleMap => new Dictionary<char, int>
        {
            { 'x', 0 },
            { 'y', 1 }
        };

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public Radian this[int i]
        {
            get => IVec2<RVec2, Radian, double, FVec2>.IIndexerGet(this, i);
            set => IVec2<RVec2, Radian, double, FVec2>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public Radian[] this[string swizzle]
        {
            get => IVec2<RVec2, Radian, double, FVec2>.ISwizzleGet(this, swizzle);
            set => IVec2<RVec2, Radian, double, FVec2>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator RVec2(Radian[] swizzle) => IVec2<RVec2, Radian, double, FVec2>.ISwizzleToSelf(swizzle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISelfToSwizzle"/>
        public static implicit operator Radian[](in RVec2 vec) => IVec2<RVec2, Radian, double, FVec2>.ISelfToSwizzle(vec);

        /// <summary>
        /// Constructs a new 2d vector.
        /// </summary>
        public RVec2(double x, double y) { X = new Radian(x); Y = new Radian(y); }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Rotate"/>
        public FVec2 Rotate(Radian angle) => IVec2<RVec2, Radian, double, FVec2>.IRotate(this, angle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public Radian Mag2() => IVec2<RVec2, Radian, double, FVec2>.IMag2(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => IVec2<RVec2, Radian, double, FVec2>.IMag(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public Radian Dot(in RVec2 other) => IVec2<RVec2, Radian, double, FVec2>.IDot(this, other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Cross2d"/>
        public Radian Cross2d(in RVec2 rhs) => IVec2<RVec2, Radian, double, FVec2>.ICross2d(this, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Norm()"/>
        public FVec2 Norm() => IVec2<RVec2, Radian, double, FVec2>.INorm(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Norm()"/>
        public FVec2 Norm(out double mag)
        {
            mag = Mag();
            return new FVec2(X.Radians / mag, Y.Radians / mag);
        }

        /// <summary>
        /// Computes the cross product between two vectors <see href="https://en.wikipedia.org/wiki/Cross_product"/>.
        /// </summary>
        /// <returns>A 3d vector orthogonal to the xy plane.</returns>
        public RVec3 Cross(in RVec2 rhs) => new RVec3(0, 0, Cross2d(rhs).Radians);

        /// <summary>
        /// Converts a radian vector to a degree vector.
        /// </summary>
        public static implicit operator DVec2(in RVec2 vec) => new DVec2(vec.X.Degrees, vec.Y.Degrees);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static RVec2 operator +(in RVec2 lhs, in RVec2 rhs) => IVec2<RVec2, Radian, double, FVec2>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static RVec2 operator -(in RVec2 lhs, in RVec2 rhs) => IVec2<RVec2, Radian, double, FVec2>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static RVec2 operator *(in RVec2 lhs, in RVec2 rhs) => IVec2<RVec2, Radian, double, FVec2>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static RVec2 operator *(in RVec2 lhs, double scalar) => new RVec2(lhs.X.Radians * scalar, lhs.Y.Radians * scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static RVec2 operator *(double scalar, in RVec2 rhs) => rhs * scalar;

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static RVec2 operator /(in RVec2 lhs, in RVec2 rhs) => IVec2<RVec2, Radian, double, FVec2>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static RVec2 operator /(in RVec2 lhs, double scalar) => new RVec2(lhs.X.Radians / scalar, lhs.Y.Radians / scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static RVec2 operator /(double scalar, in RVec2 rhs) => new RVec2(scalar / rhs.X.Radians, scalar / rhs.Y.Radians);

        /// <inheritdoc cref="Equals(RVec2)"/>
        public static bool operator ==(in RVec2 lhs, in RVec2 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(RVec2)"/>
        public static bool operator !=(in RVec2 lhs, in RVec2 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(RVec2 other) => IVec2<RVec2, Radian, double, FVec2>.IEquals(this, other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in object?)"/>
        public override bool Equals(object? obj) => IVec2<RVec2, Radian, double, FVec2>.IEquals(this, obj);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IGetHashCode"/>
        public override int GetHashCode() => IVec2<RVec2, Radian, double, FVec2>.IGetHashCode(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec2<RVec2, Radian, double, FVec2>.IToString(this);
    }
}
