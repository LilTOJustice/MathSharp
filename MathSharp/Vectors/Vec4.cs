namespace MathSharp
{
    /// <summary>
    /// A 4d vector of type int.
    /// </summary>
    public struct Vec4 : IVec4<Vec4, int, double, FVec4>, ISwizzlable<Vec4, int>, IEquatable<Vec4>
    {
        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.X"/>
        public int X { get; set; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public int Y { get; set; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public int Z { get; set; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.W"/>
        public int W { get; set; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public int[] Components => IVec4<Vec4, int, double, FVec4>.IComponents(this);

        /// <summary>
        /// Constructs a new 4d vector.
        /// </summary>
        public Vec4(int x, int y, int z, int w) { X = x; Y = y; Z = z; W = w; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public int this[int i]
        {
            get => IVec4<Vec4, int, double, FVec4>.IIndexerGet(this, i);
            set => IVec4<Vec4, int, double, FVec4>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public Swizzle<int> this[string swizzle]
        {
            get => IVec4<Vec4, int, double, FVec4>.ISwizzleGet(this, swizzle);
            set => IVec4<Vec4, int, double, FVec4>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator Vec4(Swizzle<int> swizzler) => IVec4<Vec4, int, double, FVec4>.ISwizzleToSelf(swizzler);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public int Mag2() => IVec4<Vec4, int, double, FVec4>.IMag2(this);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => IVec4<Vec4, int, double, FVec4>.IMag(this);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public int Dot(in Vec4 other) => IVec4<Vec4, int, double, FVec4>.IDot(this, other);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public FVec4 Norm() => IVec4<Vec4, int, double, FVec4>.INorm(this);

        /// <summary>
        /// Converts a float vector to an int vector.
        /// </summary>
        public static explicit operator FVec4(in Vec4 vec) => new FVec4(vec.X, vec.Y, vec.Z, vec.W);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static Vec4 operator +(in Vec4 lhs, in Vec4 rhs) => IVec4<Vec4, int, double, FVec4>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static Vec4 operator -(in Vec4 lhs, in Vec4 rhs) => IVec4<Vec4, int, double, FVec4>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static Vec4 operator *(in Vec4 lhs, in Vec4 rhs) => IVec4<Vec4, int, double, FVec4>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static Vec4 operator *(in Vec4 lhs, int scalar) => IVec4<Vec4, int, double, FVec4>.IMul(lhs, scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static FVec4 operator *(in Vec4 lhs, double scalar) => IVec4<Vec4, int, double, FVec4>.IFMul(lhs, scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static Vec4 operator /(in Vec4 lhs, in Vec4 rhs) => IVec4<Vec4, int, double, FVec4>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static Vec4 operator /(in Vec4 lhs, int scalar) => IVec4<Vec4, int, double, FVec4>.IDiv(lhs, scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static FVec4 operator /(in Vec4 lhs, double scalar) => IVec4<Vec4, int, double, FVec4>.IFDiv(lhs, scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(Vec4 other) => IVec4<Vec4, int, double, FVec4>.IEquals(this, other);

        /// <inheritdoc cref="Equals(Vec4)"/>
        public static bool operator ==(in Vec4 lhs, in Vec4 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(Vec4)"/>
        public static bool operator !=(in Vec4 lhs, in Vec4 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => IVec4<Vec4, int, double, FVec4>.IEquals(this, obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => IVec4<Vec4, int, double, FVec4>.IGetHashCode(this);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec4<Vec4, int, double, FVec4>.IToString(this);
    }
}
