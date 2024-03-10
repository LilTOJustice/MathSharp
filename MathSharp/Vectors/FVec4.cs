namespace MathSharp
{
    /// <summary>
    /// A 4d vector of type double.
    /// </summary>
    public struct FVec4 : IVec4<FVec4, double, double, FVec4>, ISwizzlable<FVec4, double>, IEquatable<FVec4>
    {
        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.X"/>
        public double X { get; set; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public double Y { get; set; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public double Z { get; set; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.W"/>
        public double W { get; set; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public double[] Components => IVec4<FVec4, double, double, FVec4>.IComponents(this);

        /// <summary>
        /// Constructs a new 4d vector.
        /// </summary>
        public FVec4(double x, double y, double z, double w) { X = x; Y = y; Z = z; W = w; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public double this[int i] {
            get => IVec4<FVec4, double, double, FVec4>.IIndexerGet(this, i);
            set => IVec4<FVec4, double, double, FVec4>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public Swizzle<double> this[string swizzle]
        {
            get => IVec4<FVec4, double, double, FVec4>.ISwizzleGet(this, swizzle);
            set => IVec4<FVec4, double, double, FVec4>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator FVec4(Swizzle<double> swizzler) => IVec4<FVec4, double, double, FVec4>.ISwizzleToSelf(swizzler);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.ISelfToSwizzle(in TSelf)"/>
        public static implicit operator Swizzle<double> (in FVec4 vec) => IVec4<FVec4, double, double, FVec4>.ISelfToSwizzle(vec);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public double Mag2() => IVec4<FVec4, double, double, FVec4>.IMag2(this);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => IVec4<FVec4, double, double, FVec4>.IMag(this);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public double Dot(in FVec4 other) => IVec4<FVec4, double, double, FVec4>.IDot(this, other);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public FVec4 Norm() => IVec4<FVec4, double, double, FVec4>.INorm(this);

        /// <summary>
        /// Converts a float vector to an int vector.
        /// </summary>
        public static explicit operator Vec4(in FVec4 vec) => new Vec4((int)vec.X, (int)vec.Y, (int)vec.Z, (int)vec.W);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static FVec4 operator +(in FVec4 lhs, in FVec4 rhs) => IVec4<FVec4, double, double, FVec4>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static FVec4 operator -(in FVec4 lhs, in FVec4 rhs) => IVec4<FVec4, double, double, FVec4>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static FVec4 operator *(in FVec4 lhs, in FVec4 rhs) => IVec4<FVec4, double, double, FVec4>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static FVec4 operator *(in FVec4 lhs, double scalar) => IVec4<FVec4, double, double, FVec4>.IMul(lhs, scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static FVec4 operator /(in FVec4 lhs, in FVec4 rhs) => IVec4<FVec4, double, double, FVec4>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static FVec4 operator /(in FVec4 lhs, double scalar) => IVec4<FVec4, double, double, FVec4>.IDiv(lhs, scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(FVec4 other) => IVec4<FVec4, double, double, FVec4>.IEquals(this, other);

        /// <inheritdoc cref="Equals(FVec4)"/>
        public static bool operator ==(in FVec4 lhs, in FVec4 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(FVec4)"/>
        public static bool operator !=(in FVec4 lhs, in FVec4 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => IVec4<FVec4, double, double, FVec4>.IEquals(this, obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => IVec4<FVec4, double, double, FVec4>.IGetHashCode(this);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec4<FVec4, double, double, FVec4>.IToString(this);
    }
}
