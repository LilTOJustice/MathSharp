namespace MathSharp
{
    /// <summary>
    /// A 4d vector of type int.
    /// </summary>
    public struct Vec4 : IVec4<Vec4, int, double, FVec4>
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
        public int[] Components => (this as IVec4<Vec4, int, double, FVec4>).Components;

        /// <summary>
        /// Constructs a new 4d vector.
        /// </summary>
        public Vec4(int x, int y, int z, int w) { X = x; Y = y; Z = z; W = w; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public int this[int i]
        {
            get => (this as IVec4<Vec4, int, double, FVec4>)[i];
            set => (this as IVec4<Vec4, int, double, FVec4>)[i] = value;
        }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public int Mag2() => (this as IVec4<Vec4, int, double, FVec4>).IMag2();

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => (this as IVec4<Vec4, int, double, FVec4>).IMag();

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Dot(in TSelf)"/>
        public int Dot(in Vec4 other) => (this as IVec4<Vec4, int, double, FVec4>).IDot(other);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public FVec4 Norm() => (this as IVec4<Vec4, int, double, FVec4>).INorm();

        /// <summary>
        /// Converts a float vector to an int vector.
        /// </summary>
        public static explicit operator FVec4(in Vec4 vec) => new FVec4(vec.X, vec.Y, vec.Z, vec.W);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IAdd(in TSelf)"/>
        public static Vec4 operator +(in Vec4 lhs, in Vec4 rhs) => (lhs as IVec4<Vec4, int, double, FVec4>).IAdd(rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.ISub(in TSelf)"/>
        public static Vec4 operator -(in Vec4 lhs, in Vec4 rhs) => (lhs as IVec4<Vec4, int, double, FVec4>).ISub(rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf)"/>
        public static Vec4 operator *(in Vec4 lhs, in Vec4 rhs) => (lhs as IVec4<Vec4, int, double, FVec4>).IMul(rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(TBase)"/>
        public static Vec4 operator *(in Vec4 lhs, int scalar) => (lhs as IVec4<Vec4, int, double, FVec4>).IMul(scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(TBase)"/>
        public static FVec4 operator *(in Vec4 lhs, double scalar) => (lhs as IVec4<Vec4, int, double, FVec4>).IFMul(scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf)"/>
        public static Vec4 operator /(in Vec4 lhs, in Vec4 rhs) => (lhs as IVec4<Vec4, int, double, FVec4>).IDiv(rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(TBase)"/>
        public static Vec4 operator /(in Vec4 lhs, int scalar) => (lhs as IVec4<Vec4, int, double, FVec4>).IDiv(scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(TBase)"/>
        public static FVec4 operator /(in Vec4 lhs, double scalar) => (lhs as IVec4<Vec4, int, double, FVec4>).IFDiv(scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf)"/>
        public bool Equals(IVec4<Vec4, int, double, FVec4>? other) => (this as IVec4<Vec4, int, double, FVec4>).IEquals(other);

        /// <inheritdoc cref="Equals(IVec4{Vec4, int, double, FVec4}?)"/>
        public static bool operator ==(in Vec4 lhs, in Vec4 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(IVec4{Vec4, int, double, FVec4}?)"/>
        public static bool operator !=(in Vec4 lhs, in Vec4 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => (this as IVec4<Vec4, int, double, FVec4>).IEquals(obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => (this as IVec4<Vec4, int, double, FVec4>).IGetHashCode();

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => (this as IVec4<Vec4, int, double, FVec4>).IToString();
    }
}
