namespace MathSharp
{
    /// <summary>
    /// A 2d vector of type int.
    /// </summary>
    public struct Vec2 : IVec2<Vec2, int, double, FVec2>, ISwizzlable<Vec2, int>, IEquatable<Vec2>
    {
        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.X"/>
        public int X { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public int Y { get; set; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public int[] Components => IVec2<Vec2, int, double, FVec2>.IComponents(this);

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.SwizzleMap"/>
        public static Dictionary<char, int> SwizzleMap => new Dictionary<char, int>
        {
            { 'x', 0 },
            { 'y', 1 }
        };

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public int this[int i]
        {
            get => IVec2<Vec2, int, double, FVec2>.IIndexerGet(this, i);
            set => IVec2<Vec2, int, double, FVec2>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public int[] this[string swizzle]
        {
            get => IVec2<Vec2, int, double, FVec2>.ISwizzleGet(this, swizzle);
            set => IVec2<Vec2, int, double, FVec2>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator Vec2(int[] swizzler) => IVec2<Vec2, int, double, FVec2>.ISwizzleToSelf(swizzler);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISelfToSwizzle"/>
        public static implicit operator int[](in Vec2 vec) => IVec2<Vec2, int, double, FVec2>.ISelfToSwizzle(vec);

        /// <inheritdoc cref="FVec2(double, double)"/>
        public Vec2(int x, int y) { X = x; Y = y; }

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Rotate"/>
        public FVec2 Rotate(Radian angle) => IVec2<Vec2, int, double, FVec2>.IRotate(this, angle);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public int Mag2() => IVec2<Vec2, int, double, FVec2>.IMag2(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => IVec2<Vec2, int, double, FVec2>.IMag(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public int Dot(in Vec2 other) => IVec2<Vec2, int, double, FVec2>.IDot(this, other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.Cross2d"/>
        public int Cross2d(in Vec2 rhs) => IVec2<Vec2, int, double, FVec2>.ICross2d(this, rhs);

        /// <inheritdoc cref="FVec2.Norm"/>
        public FVec2 Norm() => this / Mag();

        /// <inheritdoc cref="FVec2.Cross"/>
        public Vec3 Cross(in Vec2 rhs) => new Vec3(0, 0, Cross2d(rhs));

        /// <summary>
        /// Converts an integer vector to a floating point vector.
        /// </summary>
        public static implicit operator FVec2(in Vec2 vec) => new FVec2(vec.X, vec.Y);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static Vec2 operator +(in Vec2 lhs, in Vec2 rhs) => IVec2<Vec2, int, double, FVec2>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static Vec2 operator -(in Vec2 lhs, in Vec2 rhs) => IVec2<Vec2, int, double, FVec2>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static Vec2 operator *(in Vec2 lhs, in Vec2 rhs) => IVec2<Vec2, int, double, FVec2>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static Vec2 operator *(in Vec2 lhs, int scalar) => IVec2<Vec2, int, double, FVec2>.IMul(lhs, scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static FVec2 operator *(in Vec2 lhs, double scalar) => IVec2<Vec2, int, double, FVec2>.IFMul(lhs, scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static Vec2 operator /(in Vec2 lhs, in Vec2 rhs) => IVec2<Vec2, int, double, FVec2>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static Vec2 operator /(in Vec2 lhs, int scalar) => IVec2<Vec2, int, double, FVec2>.IDiv(lhs, scalar);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static FVec2 operator /(in Vec2 lhs, double scalar) => IVec2<Vec2, int, double, FVec2>.IFDiv(lhs, scalar);

        /// <inheritdoc cref="Equals(Vec2)"/>
        public static bool operator ==(in Vec2 lhs, in Vec2 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(Vec2)"/>
        public static bool operator !=(in Vec2 lhs, in Vec2 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(Vec2 other) => IVec2<Vec2, int, double, FVec2>.IEquals(this, other);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in object?)"/>
        public override bool Equals(object? obj) => IVec2<Vec2, int, double, FVec2>.IEquals(this, obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => IVec2<Vec2, int, double, FVec2>.IGetHashCode(this);

        /// <inheritdoc cref="IVec2{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec2<Vec2, int, double, FVec2>.IToString(this);

    }
}
