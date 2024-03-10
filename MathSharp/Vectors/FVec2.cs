namespace MathSharp
{
    /// <summary>
    /// A 2d vector of type double.
    /// </summary>
    public struct FVec2 : IVec2<FVec2, double, double, FVec2>, ISwizzlable<FVec2>, IEquatable<FVec2>
    {
        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.X"/>
        public double X { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public double Y { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public double[] Components => IVec2<FVec2, double, double, FVec2>.IComponents(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public double this[int i]
        {
            get => IVec2<FVec2, double, double, FVec2>.IIndexerGet(this, i);
            set => IVec2<FVec2, double, double, FVec2>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf(Swizzle{TSelf})"/>
        public static implicit operator FVec2(Swizzle<FVec2> swizzle) => IVec2<FVec2, double, double, FVec2>.ISwizzleToSelf(swizzle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISwizzle(in TSelf, string)"/>
        public Swizzle<FVec2> Swizzle(string swizzle) => IVec2<FVec2, double, double, FVec2>.ISwizzle(this, swizzle);

        /// <summary>
        /// Constructs a new 2d vector.
        /// </summary>
        public FVec2(double x, double y) { X = x; Y = y; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Rotate(IAngle)"/>
        public FVec2 Rotate(IAngle angle) => IVec2<FVec2, double, double, FVec2>.IRotate(this, angle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public double Mag2() => IVec2<FVec2, double, double, FVec2>.IMag2(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => IVec2<FVec2, double, double, FVec2>.IMag(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Dot(in TSelf)"/>
        public double Dot(in FVec2 other) => IVec2<FVec2, double, double, FVec2>.IDot(this, other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Cross2d(in TSelf)"/>
        public double Cross2d(in FVec2 rhs) => IVec2<FVec2, double, double, FVec2>.ICross2d(this, rhs);

        /// <summary>
        /// Computes the normalized vector.
        /// </summary>
        public FVec2 Norm() => this / Mag();

        /// <summary>
        /// Computes the cross product between two vectors <see href="https://en.wikipedia.org/wiki/Cross_product"/>.
        /// </summary>
        /// <returns>A 3d vector orthogonal to the xy plane.</returns>
        public FVec3 Cross(in FVec2 rhs) => new FVec3(0, 0, Cross2d(rhs));

        /// <summary>
        /// Converts a floating point vector to an integer vector.
        /// </summary>
        public static explicit operator Vec2(in FVec2 vec) => new Vec2((int)vec.X, (int)vec.Y);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IAdd(in TSelf, in TSelf)"/>
        public static FVec2 operator +(in FVec2 lhs, in FVec2 rhs) => (lhs as IVec2<FVec2, double, double, FVec2>).IAdd(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISub(in TSelf, in TSelf)"/>
        public static FVec2 operator -(in FVec2 lhs, in FVec2 rhs) => (lhs as IVec2<FVec2, double, double, FVec2>).ISub(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static FVec2 operator *(in FVec2 lhs, in FVec2 rhs) => (lhs as IVec2<FVec2, double, double, FVec2>).IMul(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static FVec2 operator *(in FVec2 lhs, double scalar) => (lhs as IVec2<FVec2, double, double, FVec2>).IMul(scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static FVec2 operator /(in FVec2 lhs, in FVec2 rhs) => (lhs as IVec2<FVec2, double, double, FVec2>).IDiv(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static FVec2 operator /(in FVec2 lhs, double scalar) => (lhs as IVec2<FVec2, double, double, FVec2>).IDiv(scalar);

        /// <inheritdoc cref="Equals(FVec2)"/>
        public static bool operator ==(in FVec2 lhs, in FVec2 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(FVec2)"/>
        public static bool operator !=(in FVec2 lhs, in FVec2 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(FVec2 other) => IVec2<FVec2, double, double, FVec2>.IEquals(this, other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in object?)"/>
        public override bool Equals(object? obj) => IVec2<FVec2, double, double, FVec2>.IEquals(this, obj);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IGetHashCode"/>
        public override int GetHashCode() => IVec2<FVec2, double, double, FVec2>.IGetHashCode(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec2<FVec2, double, double, FVec2>.IToString(this);
    }
}
