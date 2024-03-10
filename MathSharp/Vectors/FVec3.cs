namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type double.
    /// </summary>
    public struct FVec3 : IVec3<FVec3, double, double, FVec3>, ISwizzlable<FVec3>, IEquatable<FVec3>
    {
        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.X"/>
        public double X { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public double Y { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public double Z { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public double[] Components => IVec3<FVec3, double, double, FVec3>.IComponents(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public double this[int i] {
            get => IVec3<FVec3, double, double, FVec3>.IIndexerGet(this, i);
            set => IVec3<FVec3, double, double, FVec3>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator FVec3(Swizzle<FVec3> swizzler) => IVec3<FVec3, double, double, FVec3>.ISwizzleToSelf(swizzler);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISwizzle"/>
        public Swizzle<FVec3> Swizzle(string swizzle) => IVec3<FVec3, double, double, FVec3>.ISwizzle(this, swizzle);

        /// <summary>
        /// Constructs a new 3d vector.
        /// </summary>
        public FVec3(double x, double y, double z) { X = x; Y = y; Z = z; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Rotate"/>
        public FVec3 Rotate(in AVec3 angle) => IVec3<FVec3, double, double, FVec3>.IRotate(this, angle);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public double Mag2() => IVec3<FVec3, double, double, FVec3>.IMag2(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => IVec3<FVec3, double, double, FVec3>.IMag(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public double Dot(in FVec3 other) => IVec3<FVec3, double, double, FVec3>.IDot(this, other);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Cross"/>
        public FVec3 Cross(in FVec3 rhs) => IVec3<FVec3, double, double, FVec3>.ICross(this, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public FVec3 Norm() => IVec3<FVec3, double, double, FVec3>.INorm(this);

        /// <summary>
        /// Converts a floating point vector to an integer vector.
        /// </summary>
        public static explicit operator Vec3(in FVec3 vec) => new Vec3((int)vec.X, (int)vec.Y, (int)vec.Z);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static FVec3 operator +(in FVec3 lhs, in FVec3 rhs) => IVec3<FVec3, double, double, FVec3>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static FVec3 operator -(in FVec3 lhs, in FVec3 rhs) => IVec3<FVec3, double, double, FVec3>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static FVec3 operator *(in FVec3 lhs, in FVec3 rhs) => IVec3<FVec3, double, double, FVec3>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static FVec3 operator *(in FVec3 lhs, double scalar) => IVec3<FVec3, double, double, FVec3>.IMul(lhs, scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static FVec3 operator /(in FVec3 lhs, in FVec3 rhs) => IVec3<FVec3, double, double, FVec3>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static FVec3 operator /(in FVec3 lhs, double scalar) => IVec3<FVec3, double, double, FVec3>.IDiv(lhs, scalar);

        /// <inheritdoc cref="Equals(FVec3)"/>
        public static bool operator ==(in FVec3 lhs, in FVec3 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(FVec3)"/>
        public static bool operator !=(in FVec3 lhs, in FVec3 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(FVec3 other) => IVec3<FVec3, double, double, FVec3>.IEquals(this, other);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => IVec3<FVec3, double, double, FVec3>.IEquals(this, obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => IVec3<FVec3, double, double, FVec3>.IGetHashCode(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec3<FVec3, double, double, FVec3>.IToString(this);
    }
}
