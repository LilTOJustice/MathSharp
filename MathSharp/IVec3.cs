using System.Numerics;

namespace MathSharp
{
    /// <typeparam name="TSelf">Type implementing the interface.</typeparam>
    /// <typeparam name="TBase">Base type of the vector. Must be of type <see cref="INumber{TSelf}"/>.</typeparam>
    /// <typeparam name="TFloat">Type used for forced float situations (such as <see cref="Mag"/>). Must be of type <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
    /// <typeparam name="TVec2">Type used for forced 2d situations (such as <see cref="XY"/>). Must be of type <see cref="IVec2{TSelf, TBase, TFloat, TVec3}"/></typeparam>
    public interface IVec3<TSelf, TBase, TFloat, TVFloat>
    { }
}
