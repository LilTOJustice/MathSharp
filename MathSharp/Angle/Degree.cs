using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace MathSharp
{
    /// <summary>
    /// Degree representation of an angle.
    /// </summary>
    public struct Degree : IFloatingPoint<Degree>
    {
        /// <summary>
        /// Radian representation of the value.
        /// </summary>
        public double Radians { get; private set; }

        /// <summary>
        /// Degree representation of the value.
        /// </summary>
        public double Degrees { get; private set; }

        /// <summary>
        /// Creates a new <see cref="Degree"/> with the given degrees.
        /// </summary>
        public Degree(double degrees)
        {
            Degrees = degrees;
            Radians = Math.PI * degrees / 180;
        }

        /// <summary>
        /// Converts degrees to a radian representation.
        /// </summary>
        /// <param name="degrees"></param>
        public static implicit operator Radian(Degree degrees) => new Radian(degrees.Radians);

        /// <inheritdoc/>
        public static Degree E => new Degree(double.E);

        /// <inheritdoc/>
        public static Degree Pi => new Degree(double.Pi);

        /// <inheritdoc/>
        public static Degree Tau => new Degree(double.Tau);

        /// <inheritdoc/>
        public static Degree NegativeOne => new Degree(-1d);

        /// <inheritdoc/>
        public static Degree One => new Degree(1d);

        /// <inheritdoc/>
        public static int Radix => 10;

        /// <inheritdoc/>
        public static Degree Zero => new Degree(0d);

        /// <inheritdoc/>
        public static Degree AdditiveIdentity => new Degree(0d);

        /// <inheritdoc/>
        public static Degree MultiplicativeIdentity => new Degree(1d);

        /// <inheritdoc/>
        public int GetExponentByteCount() => (Degrees as IFloatingPoint<double>).GetExponentByteCount();

        /// <inheritdoc/>
        public int GetExponentShortestBitLength() => (Degrees as IFloatingPoint<double>).GetExponentShortestBitLength();

        /// <inheritdoc/>
        public int GetSignificandBitLength() => (Degrees as IFloatingPoint<double>).GetSignificandBitLength();

        /// <inheritdoc/>
        public int GetSignificandByteCount() => (Degrees as IFloatingPoint<double>).GetSignificandByteCount();

        /// <inheritdoc/>
        public static Degree Round(Degree x, int digits, MidpointRounding mode) => new Degree(Math.Round(x.Degrees, digits, mode));

        /// <inheritdoc/>
        public bool TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten) => (Degrees as IFloatingPoint<double>).TryWriteExponentBigEndian(destination, out bytesWritten);

        /// <inheritdoc/>
        public bool TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten) => (Degrees as IFloatingPoint<double>).TryWriteExponentLittleEndian(destination, out bytesWritten);

        /// <inheritdoc/>
        public bool TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten) => (Degrees as IFloatingPoint<double>).TryWriteSignificandBigEndian(destination, out bytesWritten);

        /// <inheritdoc/>
        public bool TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten) => (Degrees as IFloatingPoint<double>).TryWriteSignificandLittleEndian(destination, out bytesWritten);

        /// <inheritdoc/>
        public int CompareTo(object? obj) => Degrees.CompareTo(obj);

        /// <inheritdoc/>
        public int CompareTo(Degree other) => Degrees.CompareTo(other.Degrees);

        /// <inheritdoc/>
        public static Degree Abs(Degree value) => new Degree(Math.Abs(value.Degrees));

        /// <inheritdoc/>
        public static bool IsCanonical(Degree value) => true;

        /// <inheritdoc/>
        public static bool IsComplexNumber(Degree value) => false;

        /// <inheritdoc/>
        public static bool IsEvenInteger(Degree value) => false;

        /// <inheritdoc/>
        public static bool IsFinite(Degree value) => false;

        /// <inheritdoc/>
        public static bool IsImaginaryNumber(Degree value) => false;

        /// <inheritdoc/>
        public static bool IsInfinity(Degree value) => value.Degrees == double.PositiveInfinity || value.Degrees == double.NegativeInfinity;

        /// <inheritdoc/>
        public static bool IsInteger(Degree value) => false;

        /// <inheritdoc/>
        public static bool IsNaN(Degree value) => double.IsNaN(value.Degrees);

        /// <inheritdoc/>
        public static bool IsNegative(Degree value) => value.Degrees < 0;

        /// <inheritdoc/>
        public static bool IsNegativeInfinity(Degree value) => value.Degrees == double.NegativeInfinity;

        /// <inheritdoc/>
        public static bool IsNormal(Degree value) => true;

        /// <inheritdoc/>
        public static bool IsOddInteger(Degree value) => false;

        /// <inheritdoc/>
        public static bool IsPositive(Degree value) => value.Degrees > 0;

        /// <inheritdoc/>
        public static bool IsPositiveInfinity(Degree value) => value.Degrees == double.PositiveInfinity;

        /// <inheritdoc/>
        public static bool IsRealNumber(Degree value) => !IsNaN(value);

        /// <inheritdoc/>
        public static bool IsSubnormal(Degree value) => false;

        /// <inheritdoc/>
        public static bool IsZero(Degree value) => value.Degrees == 0;

        /// <inheritdoc/>
        public static Degree MaxMagnitude(Degree x, Degree y) => new Degree(Math.Max(x.Degrees, y.Degrees));

        /// <inheritdoc/>
        public static Degree MaxMagnitudeNumber(Degree x, Degree y) => new Degree(Math.Max(x.Degrees, y.Degrees));

        /// <inheritdoc/>
        public static Degree MinMagnitude(Degree x, Degree y) => new Degree(Math.Min(x.Degrees, y.Degrees));

        /// <inheritdoc/>
        public static Degree MinMagnitudeNumber(Degree x, Degree y) => new Degree(Math.Min(x.Degrees, y.Degrees));

        /// <inheritdoc/>
        public static Degree Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider) => new Degree(double.Parse(s, style, provider));

        /// <inheritdoc/>
        public static Degree Parse(string s, NumberStyles style, IFormatProvider? provider) => new Degree(double.Parse(s, style, provider));

        /// <inheritdoc/>
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Degree result)
        {
            double o;
            if (!double.TryParse(s, style, provider, out o))
            {
                result = default;
                return false;
            }

            result = new Degree(o);
            return true;
        }

        /// <inheritdoc/>
        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Degree result)
        {
            double o;
            if (!double.TryParse(s, style, provider, out o))
            {
                result = default;
                return false;
            }

            result = new Degree(o);
            return true;
        }

        /// <inheritdoc/>
        public bool Equals(Degree other) => Degrees.Equals(other.Degrees);

        /// <inheritdoc/>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => Degrees.TryFormat(destination, out charsWritten, format, provider);

        /// <inheritdoc/>
        public string ToString(string? format, IFormatProvider? formatProvider) => Degrees.ToString(format, formatProvider);

        /// <inheritdoc/>
        public static Degree Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => new Degree(double.Parse(s, provider));

        /// <inheritdoc/>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Degree result)
        {
            double o;
            if (!double.TryParse(s, provider, out o))
            {
                result = default;
                return false;
            }

            result = new Degree(o);
            return true;
        }

        /// <inheritdoc/>
        public static Degree Parse(string s, IFormatProvider? provider) => new Degree(double.Parse(s, provider));

        /// <inheritdoc/>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Degree result)
        {
            double o;
            if (!double.TryParse(s, provider, out o))
            {
                result = default;
                return false;
            }

            result = new Degree(o);
            return true;
        }

        static bool INumberBase<Degree>.TryConvertFromChecked<TOther>(TOther value, out Degree result) => throw new NotImplementedException();

        static bool INumberBase<Degree>.TryConvertFromSaturating<TOther>(TOther value, out Degree result) => throw new NotImplementedException();

        static bool INumberBase<Degree>.TryConvertFromTruncating<TOther>(TOther value, out Degree result) => throw new NotImplementedException();

        static bool INumberBase<Degree>.TryConvertToChecked<TOther>(Degree value, out TOther result) => throw new NotImplementedException();

        static bool INumberBase<Degree>.TryConvertToSaturating<TOther>(Degree value, out TOther result) => throw new NotImplementedException();

        static bool INumberBase<Degree>.TryConvertToTruncating<TOther>(Degree value, out TOther result) => throw new NotImplementedException();

        /// <inheritdoc/>
        public static bool operator >(Degree left, Degree right) => left.Degrees > right.Degrees;

        /// <inheritdoc/>
        public static bool operator >=(Degree left, Degree right) => left.Degrees >= right.Degrees;

        /// <inheritdoc/>
        public static bool operator <(Degree left, Degree right) => left.Degrees < right.Degrees;

        /// <inheritdoc/>
        public static bool operator <=(Degree left, Degree right) => left.Degrees <= right.Degrees;

        /// <inheritdoc/>
        public static Degree operator %(Degree left, Degree right) => new Degree(left.Degrees % right.Degrees);

        /// <inheritdoc/>
        public static Degree operator +(Degree left, Degree right) => new Degree(left.Degrees + right.Degrees);

        /// <inheritdoc/>
        public static Degree operator --(Degree value) => new Degree(value.Degrees - 1);

        /// <inheritdoc/>
        public static Degree operator /(Degree left, Degree right) => new Degree(left.Degrees / right.Degrees);

        /// <inheritdoc/>
        public static bool operator ==(Degree left, Degree right) => left.Degrees == right.Degrees;

        /// <inheritdoc/>
        public static bool operator !=(Degree left, Degree right) => left.Degrees != right.Degrees;

        /// <inheritdoc/>
        public static Degree operator ++(Degree value) => new Degree(value.Degrees + 1);

        /// <inheritdoc/>
        public static Degree operator *(Degree left, Degree right) => new Degree(left.Degrees * right.Degrees);

        /// <inheritdoc/>
        public static Degree operator -(Degree left, Degree right) => new Degree(left.Degrees - right.Degrees);

        /// <inheritdoc/>
        public static Degree operator -(Degree value) => new Degree(-value.Degrees);

        /// <inheritdoc/>
        public static Degree operator +(Degree value) => new Degree(+value.Degrees);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => obj is Radian radian && Equals(radian);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => Radians.GetHashCode();
    }
}
