namespace MathSharp
{
    /// <summary>
    /// A 2d vector of type double.
    /// </summary>
    public struct FVec2 : IVec2<FVec2, double, double, FVec2>
    {
        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.X"/>
        public double X { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public double Y { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public double[] Components => (this as IVec2<FVec2, double, double, FVec2>).IComponents;

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public double this[int i]
        {
            get => (this as IVec2<FVec2, double, double, FVec2>).IIndexerGet(i);
            set => (this as IVec2<FVec2, double, double, FVec2>).IIndexerSet(i, value);
        }

        /// <summary>
        /// Constructs a new 2d vector.
        /// </summary>
        public FVec2(double x, double y) { X = x; Y = y; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Rotate(IAngle)"/>
        public FVec2 Rotate(IAngle angle) => (this as IVec2<FVec2, double, double, FVec2>).IRotate(angle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public double Mag2() => (this as IVec2<FVec2, double, double, FVec2>).IMag2();

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => (this as IVec2<FVec2, double, double, FVec2>).IMag();

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Dot(in TSelf)"/>
        public double Dot(in FVec2 other) => (this as IVec2<FVec2, double, double, FVec2>).IDot(other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Cross2d(in TSelf)"/>
        public double Cross2d(in FVec2 rhs) => (this as IVec2<FVec2, double, double, FVec2>).ICross2d(rhs);

        /// <summary>
        /// Computes the normalized vector.
        /// </summary>
        public FVec2 Norm() => this / Mag();

        /// <summary>
        /// Computes the cross product between two vectors <see href="https://en.wikipedia.org/wiki/Cross_product"/>.
        /// </summary>
        /// <returns>A 3d vector orthogonal to the xy plane.</returns>
        public FVec3 Cross(in FVec2 rhs)
        {
            return new FVec3(0, 0, Cross2d(rhs));
        }

        /// <summary>
        /// Converts a floating point vector to an integer vector.
        /// </summary>
        public static explicit operator Vec2(in FVec2 vec)
        {
            return new Vec2((int)vec.X, (int)vec.Y);
        }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.operator +(in IVec2{TSelf, TBase, TFloat, TVFloat}, in IVec2{TSelf, TBase, TFloat, TVFloat})"/>
        public static FVec2 operator +(in FVec2 lhs, in FVec2 rhs) => lhs + (rhs as IVec2<FVec2, double, double, FVec2>);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.operator -(in IVec2{TSelf, TBase, TFloat, TVFloat}, in IVec2{TSelf, TBase, TFloat, TVFloat})"/>
        public static FVec2 operator -(in FVec2 lhs, in FVec2 rhs) => lhs - (rhs as IVec2<FVec2, double, double, FVec2>);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.operator *(in IVec2{TSelf, TBase, TFloat, TVFloat}, in IVec2{TSelf, TBase, TFloat, TVFloat})"/>
        public static FVec2 operator *(in FVec2 lhs, in FVec2 rhs) => lhs * (rhs as IVec2<FVec2, double, double, FVec2>);

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        public static FVec2 operator *(in FVec2 lhs, double scalar) => new FVec2(lhs.X * scalar, lhs.Y * scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.operator /(in IVec2{TSelf, TBase, TFloat, TVFloat}, in IVec2{TSelf, TBase, TFloat, TVFloat})"/>
        public static FVec2 operator /(in FVec2 lhs, in FVec2 rhs) => lhs / (rhs as IVec2<FVec2, double, double, FVec2>);

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        public static FVec2 operator /(in FVec2 lhs, double scalar) => new FVec2(lhs.X / scalar, lhs.Y / scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.operator ==(in TSelf, in TSelf)"/>
        public static bool operator ==(in FVec2 lhs, in FVec2 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.operator !=(in TSelf, in TSelf)"/>
        public static bool operator !=(in FVec2 lhs, in FVec2 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf)"/>
        public bool Equals(IVec2<FVec2, double, double, FVec2>? other) => (this as IVec2<FVec2, double, double, FVec2>).IEquals(other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => (this as IVec2<FVec2, double, double, FVec2>).IToString();

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in object?)"/>
        public override bool Equals(object? obj) => (this as IVec2<FVec2, double, double, FVec2>).IEquals(obj);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IGetHashCode"/>
        public override int GetHashCode() => (this as IVec2<FVec2, double, double, FVec2>).IGetHashCode();
    }
}
