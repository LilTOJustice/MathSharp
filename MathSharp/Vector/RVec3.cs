﻿namespace MathSharp
{
    /// <summary>
    /// A 3d vector of type Radian.
    /// </summary>
    public struct RVec3 : IVec3<RVec3, Radian, Radian, RVec3>, ISwizzlable<RVec3, Radian>, IEquatable<RVec3>
    {
        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.X"/>
        public Radian X { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Y"/>
        public Radian Y { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Z"/>
        public Radian Z { get; set; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Components"/>
        public Radian[] Components => IVec3<RVec3, Radian, Radian, RVec3>.IComponents(this);

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.SwizzleMap"/>
        public static Dictionary<char, int> SwizzleMap => new Dictionary<char, int>
            {
                { 'x', 0 },
                { 'y', 1 },
                { 'z', 2 }
            };

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.this[int]"/>
        public Radian this[int i] {
            get => IVec3<RVec3, Radian, Radian, RVec3>.IIndexerGet(this, i);
            set => IVec3<RVec3, Radian, Radian, RVec3>.IIndexerSet(ref this, i, value);
        }

        /// <inheritdoc cref="ISwizzlable{TSelf, TBase}.this[string]"/>
        public Radian[] this[string swizzle]
        {
            get => IVec3<RVec3, Radian, Radian, RVec3>.ISwizzleGet(this, swizzle);
            set => IVec3<RVec3, Radian, Radian, RVec3>.ISwizzleSet(ref this, swizzle, value);
        }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISwizzleToSelf"/>
        public static implicit operator RVec3(Radian[] swizzler) => IVec3<RVec3, Radian, Radian, RVec3>.ISwizzleToSelf(swizzler);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISelfToSwizzle"/>
        public static implicit operator Radian[](in RVec3 vec) => IVec3<RVec3, Radian, Radian, RVec3>.ISelfToSwizzle(vec);

        /// <summary>
        /// Constructs a new 3d vector.
        /// </summary>
        public RVec3(Radian x, Radian y, Radian z) { X = x; Y = y; Z = z; }

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Rotate"/>
        public RVec3 Rotate(in RVec3 angle) => IVec3<RVec3, Radian, Radian, RVec3>.IRotate(this, angle);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag2"/>
        public Radian Mag2() => IVec3<RVec3, Radian, Radian, RVec3>.IMag2(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Mag"/>
        public Radian Mag() => IVec3<RVec3, Radian, Radian, RVec3>.IMag(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Dot"/>
        public Radian Dot(in RVec3 other) => IVec3<RVec3, Radian, Radian, RVec3>.IDot(this, other);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Cross"/>
        public RVec3 Cross(in RVec3 rhs) => IVec3<RVec3, Radian, Radian, RVec3>.ICross(this, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.Norm"/>
        public RVec3 Norm() => IVec3<RVec3, Radian, Radian, RVec3>.INorm(this);

        /// <summary>
        /// Converts a radian vector to a degree vector.
        /// </summary>
        public static implicit operator DVec3(in RVec3 vec) => new DVec3(new Degree(vec.X.Degrees), new Degree(vec.Y.Degrees), new Degree(vec.Z.Degrees));

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IAdd"/>
        public static RVec3 operator +(in RVec3 lhs, in RVec3 rhs) => IVec3<RVec3, Radian, Radian, RVec3>.IAdd(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.ISub"/>
        public static RVec3 operator -(in RVec3 lhs, in RVec3 rhs) => IVec3<RVec3, Radian, Radian, RVec3>.ISub(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, in TSelf)"/>
        public static RVec3 operator *(in RVec3 lhs, in RVec3 rhs) => IVec3<RVec3, Radian, Radian, RVec3>.IMul(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IMul(in TSelf, TBase)"/>
        public static RVec3 operator *(in RVec3 lhs, Radian scalar) => IVec3<RVec3, Radian, Radian, RVec3>.IMul(lhs, scalar);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, in TSelf)"/>
        public static RVec3 operator /(in RVec3 lhs, in RVec3 rhs) => IVec3<RVec3, Radian, Radian, RVec3>.IDiv(lhs, rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IDiv(in TSelf, TBase)"/>
        public static RVec3 operator /(in RVec3 lhs, Radian scalar) => IVec3<RVec3, Radian, Radian, RVec3>.IDiv(lhs, scalar);

        /// <inheritdoc cref="Equals(RVec3)"/>
        public static bool operator ==(in RVec3 lhs, in RVec3 rhs) => lhs.Equals(rhs);

        /// <inheritdoc cref="Equals(RVec3)"/>
        public static bool operator !=(in RVec3 lhs, in RVec3 rhs) => !lhs.Equals(rhs);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IEquals(in TSelf, in TSelf)"/>
        public bool Equals(RVec3 other) => IVec3<RVec3, Radian, Radian, RVec3>.IEquals(this, other);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => IVec3<RVec3, Radian, Radian, RVec3>.IEquals(this, obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => IVec3<RVec3, Radian, Radian, RVec3>.IGetHashCode(this);

        /// <inheritdoc cref="IVec3{TSelf, TBase, TFloat, TVFloat}.IToString"/>
        public override string ToString() => IVec3<RVec3, Radian, Radian, RVec3>.IToString(this);
    }
}
