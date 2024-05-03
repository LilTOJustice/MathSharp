namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type Radian.
    /// </summary>
    public struct RVec3 : IVec3<RVec3, Radian, double, FVec3>, ISwizzlable<RVec3, Radian>, IEquatable<RVec3>
    {
        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.X"/>
        public Radian X { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public Radian Y { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public Radian Z { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public Radian[] Components => IVec3<RVec3, Radian, double, FVec3>.IComponents(this);

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.SwizzleMap"/>
        public static Dictionary<char, int> SwizzleMap => new Dictionary<char, int>
            {
                { 'x', 0 },
                { 'y', 1 },
                { 'z', 2 }
            };

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public Radian this[int i] {
            get => IVec3<RVec3, Radian, double, FVec3>.IIndexerGet(this, i);
            set => IVec3<RVec3, Radian, double, FVec3>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public Radian[] this[string swizzle]
        {
            get => IVec3<RVec3, Radian, double, FVec3>.ISwizzleGet(this, swizzle);
            set => IVec3<RVec3, Radian, double, FVec3>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator RVec3(Radian[] swizzler) => IVec3<RVec3, Radian, double, FVec3>.ISwizzleToSelf(swizzler);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISelfToSwizzle"/>
        public static implicit operator Radian[](in RVec3 vec) => IVec3<RVec3, Radian, double, FVec3>.ISelfToSwizzle(vec);

        /// <summary>
        /// Constructs a new 3d vector.
        /// </summary>
        public RVec3(double x, double y, double z) { X = new Radian(x); Y = new Radian(y); Z = new Radian(z); }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Rotate"/>
        public FVec3 Rotate(in RVec3 angle) => IVec3<RVec3, Radian, double, FVec3>.IRotate(this, angle);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public Radian Mag2() => IVec3<RVec3, Radian, double, FVec3>.IMag2(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => IVec3<RVec3, Radian, double, FVec3>.IMag(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public Radian Dot(in RVec3 other) => IVec3<RVec3, Radian, double, FVec3>.IDot(this, other);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Cross"/>
        public RVec3 Cross(in RVec3 rhs) => IVec3<RVec3, Radian, double, FVec3>.ICross(this, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Norm()"/>
        public FVec3 Norm() => IVec3<RVec3, Radian, double, FVec3>.INorm(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Norm()"/>
        public FVec3 Norm(out double mag)
        {
            mag = Mag();
            return new FVec3(X.Radians / mag, Y.Radians / mag, Z.Radians / mag);
        }

        /// <summary>
        /// Converts a radian vector to a degree vector.
        /// </summary>
        public static implicit operator DVec3(in RVec3 vec) => new DVec3(vec.X.Degrees, vec.Y.Degrees, vec.Z.Degrees);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static RVec3 operator +(in RVec3 lhs, in RVec3 rhs) => IVec3<RVec3, Radian, double, FVec3>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static RVec3 operator -(in RVec3 lhs, in RVec3 rhs) => IVec3<RVec3, Radian, double, FVec3>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static RVec3 operator *(in RVec3 lhs, in RVec3 rhs) => IVec3<RVec3, Radian, double, FVec3>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static RVec3 operator *(in RVec3 lhs, double scalar) => new RVec3(lhs.X.Radians * scalar, lhs.Y.Radians * scalar, lhs.Z.Radians * scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static RVec3 operator *(double scalar, in RVec3 rhs) => rhs * scalar;

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static RVec3 operator /(in RVec3 lhs, in RVec3 rhs) => IVec3<RVec3, Radian, double, FVec3>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static RVec3 operator /(in RVec3 lhs, double scalar) => new RVec3(lhs.X.Radians / scalar, lhs.Y.Radians / scalar, lhs.Z.Radians / scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static RVec3 operator /(double scalar, in RVec3 rhs) => new RVec3(scalar / rhs.X.Radians, scalar / rhs.Y.Radians, scalar / rhs.Z.Radians);

        /// <inheritdoc cref="Equals(RVec3)"/>
        public static bool operator ==(in RVec3 lhs, in RVec3 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(RVec3)"/>
        public static bool operator !=(in RVec3 lhs, in RVec3 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(RVec3 other) => IVec3<RVec3, Radian, double, FVec3>.IEquals(this, other);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => IVec3<RVec3, Radian, double, FVec3>.IEquals(this, obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => IVec3<RVec3, Radian, double, FVec3>.IGetHashCode(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec3<RVec3, Radian, double, FVec3>.IToString(this);
    }
}
