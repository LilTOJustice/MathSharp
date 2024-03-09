namespace MathSharp
{
    /// <summary>
    /// A 2d vector of type int.
    /// </summary>
    public struct Vec2 : IVec2<Vec2, int, double, FVec2>
    {
        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.X"/>
        public int X { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public int Y { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public int[] Components => (this as IVec2<Vec2, int, double, FVec2>).IComponents;

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public int this[int i]
        {
            get => (this as IVec2<Vec2, int, double, FVec2>).IIndexerGet(i);
            set => (this as IVec2<Vec2, int, double, FVec2>).IIndexerSet(i, value);
        }

        /// <inheritdoc cref="FVec2(double, double)"/>
        public Vec2(int x, int y) { X = x; Y = y; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Rotate(IAngle)"/>
        public FVec2 Rotate(IAngle angle) => (this as IVec2<Vec2, int, double, FVec2>).IRotate(angle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public int Mag2() => (this as IVec2<Vec2, int, double, FVec2>).IMag2();

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => (this as IVec2<Vec2, int, double, FVec2>).IMag();

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Dot(in TSelf)"/>
        public int Dot(in Vec2 other) => (this as IVec2<Vec2, int, double, FVec2>).IDot(other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Cross2d(in TSelf)"/>
        public int Cross2d(in Vec2 rhs) => (this as IVec2<Vec2, int, double, FVec2>).ICross2d(rhs);

        /// <inheritdoc cref="FVec2.Norm"/>
        public FVec2 Norm() => this / Mag();

        /// <inheritdoc cref="FVec2.Cross"/>
        public Vec3 Cross(in Vec2 rhs) => new Vec3(0, 0, Cross2d(rhs));

        /// <summary>
        /// Converts an integer vector to a floating point vector.
        /// </summary>
        public static implicit operator FVec2(in Vec2 vec) => new FVec2(vec.X, vec.Y);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IAdd(in TSelf)"/>
        public static Vec2 operator +(in Vec2 lhs, in Vec2 rhs) => (lhs as IVec2<Vec2, int, double, FVec2>).IAdd(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISub(in TSelf)"/>
        public static Vec2 operator -(in Vec2 lhs, in Vec2 rhs) => (lhs as IVec2<Vec2, int, double, FVec2>).ISub(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf)"/>
        public static Vec2 operator *(in Vec2 lhs, in Vec2 rhs) => (lhs as IVec2<Vec2, int, double, FVec2>).IMul(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(TBase)"/>
        public static Vec2 operator *(in Vec2 lhs, int scalar) => (lhs as IVec2<Vec2, int, double, FVec2>).IMul(scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IFMul(TFloat)"/>
        public static FVec2 operator *(in Vec2 lhs, double scalar) => (lhs as IVec2<Vec2, int, double, FVec2>).IFMul(scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf)"/>
        public static Vec2 operator /(in Vec2 lhs, in Vec2 rhs) => (lhs as IVec2<Vec2, int, double, FVec2>).IDiv(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(TBase)"/>
        public static Vec2 operator /(in Vec2 lhs, int scalar) => (lhs as IVec2<Vec2, int, double, FVec2>).IDiv(scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IFDiv(TFloat)"/>
        public static FVec2 operator /(in Vec2 lhs, double scalar) => (lhs as IVec2<Vec2, int, double, FVec2>).IFDiv(scalar);

        /// <inheritdoc cref="Equals(IVec2{Vec2, int, double, FVec2}?)"/>
        public static bool operator ==(in Vec2 lhs, in Vec2 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(IVec2{Vec2, int, double, FVec2}?)"/>
        public static bool operator !=(in Vec2 lhs, in Vec2 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf)"/>
        public bool Equals(IVec2<Vec2, int, double, FVec2>? other) => (this as IVec2<Vec2, int, double, FVec2>).IEquals(other);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => (this as IVec2<Vec2, int, double, FVec2>).IEquals(obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => (this as IVec2<Vec2, int, double, FVec2>).IGetHashCode();

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => (this as IVec2<Vec2, int, double, FVec2>).IToString();
    }
}
