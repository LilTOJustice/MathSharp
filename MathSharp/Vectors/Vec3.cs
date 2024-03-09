namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type int.
    /// </summary>
    public struct Vec3 : IVec3<Vec3, int, double, FVec3>
    {
        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.X"/>
        public int X { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public int Y { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public int Z { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public int[] Components => (this as IVec3<Vec3, int, double, FVec3>).IComponents;

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public int this[int i] {
            get => (this as IVec3<Vec3, int, double, FVec3>).IIndexerGet(i);
            set => (this as IVec3<Vec3, int, double, FVec3>).IIndexerSet(i, value);
        }

        /// <summary>
        /// Constructs a new 3d vector.
        /// </summary>
        public Vec3(int x, int y, int z) { X = x; Y = y; Z = z; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Rotate(in AVec3)"/>
        public FVec3 Rotate(in AVec3 angle) => (this as IVec3<Vec3, int, double, FVec3>).IRotate(angle);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public int Mag2() => (this as IVec3<Vec3, int, double, FVec3>).IMag2();

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public double Mag() => (this as IVec3<Vec3, int, double, FVec3>).IMag();

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public int Dot(in Vec3 other) => (this as IVec3<Vec3, int, double, FVec3>).IDot(other);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Cross"/>
        public Vec3 Cross(in Vec3 rhs) => (this as IVec3<Vec3, int, double, FVec3>).ICross(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public FVec3 Norm() => (this as IVec3<Vec3, int, double, FVec3>).INorm();

        /// <summary>
        /// Converts a floating point vector to an integer vector.
        /// </summary>
        public static explicit operator Vec3(in FVec3 vec) => new Vec3((int)vec.X, (int)vec.Y, (int)vec.Z);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IAdd(in TSelf)"/>
        public static Vec3 operator +(in Vec3 lhs, in Vec3 rhs) => (lhs as IVec3<Vec3, int, double, FVec3>).IAdd(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISub(in TSelf)"/>
        public static Vec3 operator -(in Vec3 lhs, in Vec3 rhs) => (lhs as IVec3<Vec3, int, double, FVec3>).ISub(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf)"/>
        public static Vec3 operator *(in Vec3 lhs, in Vec3 rhs) => (lhs as IVec3<Vec3, int, double, FVec3>).IMul(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(TBase)"/>
        public static Vec3 operator *(in Vec3 lhs, int scalar) => (lhs as IVec3<Vec3, int, double, FVec3>).IMul(scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(TBase)"/>
        public static FVec3 operator *(in Vec3 lhs, double scalar) => (lhs as IVec3<Vec3, int, double, FVec3>).IFMul(scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf)"/>
        public static Vec3 operator /(in Vec3 lhs, in Vec3 rhs) => (lhs as IVec3<Vec3, int, double, FVec3>).IDiv(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(TBase)"/>
        public static Vec3 operator /(in Vec3 lhs, int scalar) => (lhs as IVec3<Vec3, int, double, FVec3>).IDiv(scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(TBase)"/>
        public static FVec3 operator /(in Vec3 lhs, double scalar) => (lhs as IVec3<Vec3, int, double, FVec3>).IFDiv(scalar);

        /// <inheritdoc cref="Equals(IVec3{Vec3, int, double, FVec3}?)"/>
        public static bool operator ==(in Vec3 lhs, in Vec3 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(IVec3{Vec3, int, double, FVec3}?)"/>
        public static bool operator !=(in Vec3 lhs, in Vec3 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf)"/>
        public bool Equals(IVec3<Vec3, int, double, FVec3>? other) => (this as IVec3<Vec3, int, double, FVec3>).IEquals(other);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => (this as IVec3<Vec3, int, double, FVec3>).IEquals(obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => (this as IVec3<Vec3, int, double, FVec3>).IGetHashCode();

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => (this as IVec3<Vec3, int, double, FVec3>).IToString();
    }
}
