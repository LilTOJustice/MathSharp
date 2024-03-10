namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type int.
    /// </summary>
    public struct Vec3 : IVec3<Vec3, int, double, FVec3>, ISwizzlable<Vec3, int>, IEquatable<Vec3>
    {
        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.X"/>
        public int X { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public int Y { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public int Z { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public int[] Components => IVec3<Vec3, int, double, FVec3>.IComponents(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public int this[int i] {
            get => IVec3<Vec3, int, double, FVec3>.IIndexerGet(this, i);
            set => IVec3<Vec3, int, double, FVec3>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public Swizzle<int> this[string swizzle]
        {
            get => IVec3<Vec3, int, double, FVec3>.ISwizzleGet(this, swizzle);
            set => IVec3<Vec3, int, double, FVec3>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator Vec3(Swizzle<int> swizzler) => IVec3<Vec3, int, double, FVec3>.ISwizzleToSelf(swizzler);

        /// <summary>
        /// Constructs a new 3d vector.
        /// </summary>
        public Vec3(int x, int y, int z) { X = x; Y = y; Z = z; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Rotate"/>
        public FVec3 Rotate(in AVec3 angle) => IVec3<Vec3, int, double, FVec3>.IRotate(this, angle);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public int Mag2() => IVec3<Vec3, int, double, FVec3>.IMag2(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => IVec3<Vec3, int, double, FVec3>.IMag(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public int Dot(in Vec3 other) => IVec3<Vec3, int, double, FVec3>.IDot(this, other);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Cross"/>
        public Vec3 Cross(in Vec3 rhs) => IVec3<Vec3, int, double, FVec3>.ICross(this, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public FVec3 Norm() => IVec3<Vec3, int, double, FVec3>.INorm(this);

        /// <summary>
        /// Converts a floating point vector to an integer vector.
        /// </summary>
        public static explicit operator Vec3(in FVec3 vec) => new Vec3((int)vec.X, (int)vec.Y, (int)vec.Z);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static Vec3 operator +(in Vec3 lhs, in Vec3 rhs) => IVec3<Vec3, int, double, FVec3>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static Vec3 operator -(in Vec3 lhs, in Vec3 rhs) => IVec3<Vec3, int, double, FVec3>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static Vec3 operator *(in Vec3 lhs, in Vec3 rhs) => IVec3<Vec3, int, double, FVec3>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static Vec3 operator *(in Vec3 lhs, int scalar) => IVec3<Vec3, int, double, FVec3>.IMul(lhs, scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static FVec3 operator *(in Vec3 lhs, double scalar) => IVec3<Vec3, int, double, FVec3>.IFMul(lhs, scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static Vec3 operator /(in Vec3 lhs, in Vec3 rhs) => IVec3<Vec3, int, double, FVec3>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static Vec3 operator /(in Vec3 lhs, int scalar) => IVec3<Vec3, int, double, FVec3>.IDiv(lhs, scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static FVec3 operator /(in Vec3 lhs, double scalar) => IVec3<Vec3, int, double, FVec3>.IFDiv(lhs, scalar);

        /// <inheritdoc cref="Equals(Vec3)"/>
        public static bool operator ==(in Vec3 lhs, in Vec3 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(Vec3)"/>
        public static bool operator !=(in Vec3 lhs, in Vec3 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(Vec3 other) => IVec3<Vec3, int, double, FVec3>.IEquals(this, other);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => IVec3<Vec3, int, double, FVec3>.IEquals(this, obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => IVec3<Vec3, int, double, FVec3>.IGetHashCode(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec3<Vec3, int, double, FVec3>.IToString(this);
    }
}
