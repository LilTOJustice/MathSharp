namespace MathSharp
{
    /// <summary>
    /// A 4d vector of type double.
    /// </summary>
    public struct FVec4 : IVec4<FVec4, double, double, FVec4>
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
        public double[] Components => (this as IVec4<FVec4, double, double, FVec4>).Components;

        /// <summary>
        /// Constructs a new 4d vector.
        /// </summary>
        public FVec4(double x, double y, double z, double w) { X = x; Y = y; Z = z; W = w; }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public double this[int i] {
            get => (this as IVec4<FVec4, double, double, FVec4>)[i];
            set => (this as IVec4<FVec4, double, double, FVec4>)[i] = value;
        }

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public double Mag2() => (this as IVec4<FVec4, double, double, FVec4>).IMag2();

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => (this as IVec4<FVec4, double, double, FVec4>).IMag();

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Dot(in TSelf)"/>
        public double Dot(in FVec4 other) => (this as IVec4<FVec4, double, double, FVec4>).IDot(other);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public FVec4 Norm() => (this as IVec4<FVec4, double, double, FVec4>).INorm();

        /// <summary>
        /// Converts a float vector to an int vector.
        /// </summary>
        public static explicit operator Vec4(in FVec4 vec) => new Vec4((int)vec.X, (int)vec.Y, (int)vec.Z, (int)vec.W);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IAdd(in TSelf)"/>
        public static FVec4 operator +(in FVec4 lhs, in FVec4 rhs) => (lhs as IVec4<FVec4, double, double, FVec4>).IAdd(rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.ISub(in TSelf)"/>
        public static FVec4 operator -(in FVec4 lhs, in FVec4 rhs) => (lhs as IVec4<FVec4, double, double, FVec4>).ISub(rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf)"/>
        public static FVec4 operator *(in FVec4 lhs, in FVec4 rhs) => (lhs as IVec4<FVec4, double, double, FVec4>).IMul(rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IMul(TBase)"/>
        public static FVec4 operator *(in FVec4 lhs, double scalar) => (lhs as IVec4<FVec4, double, double, FVec4>).IMul(scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf)"/>
        public static FVec4 operator /(in FVec4 lhs, in FVec4 rhs) => (lhs as IVec4<FVec4, double, double, FVec4>).IDiv(rhs);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IDiv(TBase)"/>
        public static FVec4 operator /(in FVec4 lhs, double scalar) => (lhs as IVec4<FVec4, double, double, FVec4>).IDiv(scalar);

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf)"/>
        public bool Equals(IVec4<FVec4, double, double, FVec4>? other) => (this as IVec4<FVec4, double, double, FVec4>).IEquals(other);

        /// <inheritdoc cref="Equals(IVec4{FVec4, double, double, FVec4}?)"/>
        public static bool operator ==(in FVec4 lhs, in FVec4 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(IVec4{FVec4, double, double, FVec4}?)"/>
        public static bool operator !=(in FVec4 lhs, in FVec4 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => (this as IVec4<FVec4, double, double, FVec4>).IEquals(obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => (this as IVec4<FVec4, double, double, FVec4>).IGetHashCode();

        /// <inheritdoc cref="IVec4{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => (this as IVec4<FVec4, double, double, FVec4>).IToString();
    }
}
