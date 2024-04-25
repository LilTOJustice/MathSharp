namespace MathSharp
{
    /// <summary>
    /// Used for quaternion operations, <see href="https://en.wikipedia.org/wiki/Quaternion"/>.
    /// </summary>
    public struct Quaternion
    {
        private double w;
        private FVec3 quat;

        /// <summary>
        /// Creates a quaternion from each component.
        /// </summary>
        public Quaternion(double w, double i, double j, double k)
        {
            this.w = w;
            quat = new FVec3(i, j, k).Norm();
        }

        /// <summary>
        /// Creates a quaternion from a scalar and a vector.
        /// </summary>
        public Quaternion(double w, in FVec3 quat)
        {
            this.w = w;
            this.quat = quat.Norm();
        }

        /// <summary>
        /// Creates a quaternion from an axis-angle representation.
        /// </summary>
        /// <param name="angle">Euler angle of the quaternion</param>
        /// <param name="direction">Vector component of the quaternion. Must be normalized!</param>
        public Quaternion(Radian angle, in FVec3 direction)
        {
            double rads_2 = angle.Radians / 2;
            quat = direction * Math.Sin(rads_2);
            w = Math.Cos(rads_2);
        }


        /// <summary>
        /// Rotates the given point around the quaternion.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public FVec3 RotatePoint(FVec3 point)
        {
            return new FVec3(
                w * w * point.X + 2 * quat.Y * w * point.Z - 2 * quat.Z * w * point.Y + quat.X * quat.X * point.X + 2 * quat.X * quat.Y * point.Z + 2 * quat.X * quat.Z * point.Y - quat.Z * quat.Z * point.X - quat.Y * quat.Y * point.X,
                w * w * point.Y - 2 * quat.X * w * point.Z - quat.X * quat.X * point.Y + 2 * quat.X * quat.Y * point.X + quat.Y * quat.Y * point.Y + 2 * quat.Z * quat.Y * point.Z + 2 * w * quat.Z * point.X - quat.Z * quat.Z * point.Y,
                w * w * point.Z + 2 * quat.X * quat.Z * point.X + 2 * quat.Z * quat.Y * point.Y + quat.Z * quat.Z * point.Z - 2 * quat.Y * w * point.X - quat.X * quat.Y * point.Z + 2 * w * quat.Y * point.Y + quat.X * quat.X * point.Z);
            
        }
    }
}
