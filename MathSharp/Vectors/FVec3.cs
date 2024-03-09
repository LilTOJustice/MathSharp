namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type double.
    /// </summary>
    public struct FVec3 : IVec3<FVec3, double, double, FVec3>
    {
        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.X"/>
        public double X { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public double Y { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public double Z { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public double[] Components => new[] { X, Y, Z };

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public double this[int i] {
            get => (this as IVec3<FVec3, double, double, FVec3>).IIndexerGet(i);
            set => (this as IVec3<FVec3, double, double, FVec3>).IIndexerSet(i, value);
        }

        /// <summary>
        /// Constructs a new 3d vector.
        /// </summary>
        public FVec3(double x, double y, double z) { X = x; Y = y; Z = z; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Rotate(in AVec3)"/>
        public FVec3 Rotate(in AVec3 angle) => (this as IVec3<FVec3, double, double, FVec3>).IRotate(angle);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public double Mag2() => (this as IVec3<FVec3, double, double, FVec3>).IMag2();

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => (this as IVec3<FVec3, double, double, FVec3>).IMag();

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public double Dot(in FVec3 other) => (this as IVec3<FVec3, double, double, FVec3>).IDot(other);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Cross"/>
        public FVec3 Cross(in FVec3 rhs) => (this as IVec3<FVec3, double, double, FVec3>).ICross(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public FVec3 Norm() => (this as IVec3<FVec3, double, double, FVec3>).INorm();

        /// <summary>
        /// Converts a floating point vector to an integer vector.
        /// </summary>
        public static explicit operator Vec3(FVec3 vec) => new Vec3((int)vec.X, (int)vec.Y, (int)vec.Z);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IAdd(in TSelf)"/>
        public static FVec3 operator +(FVec3 lhs, FVec3 rhs) => (lhs as IVec3<FVec3, double, double, FVec3>).IAdd(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISub(in TSelf)"/>
        public static FVec3 operator -(FVec3 lhs, FVec3 rhs) => (lhs as IVec3<FVec3, double, double, FVec3>).ISub(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf)"/>
        public static FVec3 operator *(FVec3 lhs, FVec3 rhs) => (lhs as IVec3<FVec3, double, double, FVec3>).IMul(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(TBase)"/>
        public static FVec3 operator *(FVec3 lhs, double scalar) => (lhs as IVec3<FVec3, double, double, FVec3>).IMul(scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf)"/>
        public static FVec3 operator /(FVec3 lhs, FVec3 rhs) => (lhs as IVec3<FVec3, double, double, FVec3>).IDiv(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(TBase)"/>
        public static FVec3 operator /(FVec3 lhs, double scalar) => (lhs as IVec3<FVec3, double, double, FVec3>).IDiv(scalar);

        /// <inheritdoc cref="Equals(IVec3{FVec3, double, double, FVec3}?)"/>
        public static bool operator ==(FVec3 lhs, FVec3 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(IVec3{FVec3, double, double, FVec3}?)"/>
        public static bool operator !=(FVec3 lhs, FVec3 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf)"/>
        public bool Equals(IVec3<FVec3, double, double, FVec3>? other) => (this as IVec3<FVec3, double, double, FVec3>).IEquals(other);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => (this as IVec3<FVec3, double, double, FVec3>).IEquals(obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => (this as IVec3<FVec3, double, double, FVec3>).IGetHashCode();

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => (this as IVec3<FVec3, double, double, FVec3>).IToString();
    }
}
