using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace MathSharp
{
    /// <summary>
    /// Radiant representation of an angle.
    /// </summary>
    public struct Radian : IFloatingPoint<Radian>
    {
        /// <summary>
        /// Radian representation of the angle.
        /// </summary>
        public double Radians { get; private set; }

        /// <summary>
        /// Degree representation of the angle.
        /// </summary>
        public double Degrees { get; private set; }

        /// <summary>
        /// Creates a new <see cref="Radian"/> with the given radians.
        /// </summary>
        public Radian(double radians)
        {
            Radians = radians;
            Degrees = radians * 180 / Math.PI;
        }

        /// <inheritdoc/>
        public static Radian E => new Radian(double.E);

        /// <inheritdoc/>
        public static Radian Pi => new Radian(double.Pi);

        /// <inheritdoc/>
        public static Radian Tau => new Radian(double.Tau);

        /// <inheritdoc/>
        public static Radian NegativeOne => new Radian(-1d);

        /// <inheritdoc/>
        public static Radian One => new Radian(1d);

        /// <inheritdoc/>
        public static int Radix => 10;

        /// <inheritdoc/>
        public static Radian Zero => new Radian(0d);

        /// <inheritdoc/>
        public static Radian AdditiveIdentity => new Radian(0d);

        /// <inheritdoc/>
        public static Radian MultiplicativeIdentity => new Radian(1d);

        /// <inheritdoc/>
        public int GetExponentByteCount() => (Radians as IFloatingPoint<double>).GetExponentByteCount();

        /// <inheritdoc/>
        public int GetExponentShortestBitLength() => (Radians as IFloatingPoint<double>).GetExponentShortestBitLength();

        /// <inheritdoc/>
        public int GetSignificandBitLength() => (Radians as IFloatingPoint<double>).GetSignificandBitLength();

        /// <inheritdoc/>
        public int GetSignificandByteCount() => (Radians as IFloatingPoint<double>).GetSignificandByteCount();

        /// <inheritdoc/>
        public static Radian Round(Radian x, int digits, MidpointRounding mode) => new Radian(Math.Round(x.Radians, digits, mode));

        /// <inheritdoc/>
        public bool TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten) => (Radians as IFloatingPoint<double>).TryWriteExponentBigEndian(destination, out bytesWritten);

        /// <inheritdoc/>
        public bool TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten) => (Radians as IFloatingPoint<double>).TryWriteExponentLittleEndian(destination, out bytesWritten);

        /// <inheritdoc/>
        public bool TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten) => (Radians as IFloatingPoint<double>).TryWriteSignificandBigEndian(destination, out bytesWritten);

        /// <inheritdoc/>
        public bool TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten) => (Radians as IFloatingPoint<double>).TryWriteSignificandLittleEndian(destination, out bytesWritten);

        /// <inheritdoc/>
        public int CompareTo(object? obj) => Radians.CompareTo(obj);

        /// <inheritdoc/>
        public int CompareTo(Radian other) => Radians.CompareTo(other.Radians);

        /// <inheritdoc/>
        public static Radian Abs(Radian value) => new Radian(Math.Abs(value.Radians));

        /// <inheritdoc/>
        public static bool IsCanonical(Radian value) => true;

        /// <inheritdoc/>
        public static bool IsComplexNumber(Radian value) => false;

        /// <inheritdoc/>
        public static bool IsEvenInteger(Radian value) => false;

        /// <inheritdoc/>
        public static bool IsFinite(Radian value) => false;

        /// <inheritdoc/>
        public static bool IsImaginaryNumber(Radian value) => false;

        /// <inheritdoc/>
        public static bool IsInfinity(Radian value) => value.Radians == double.PositiveInfinity || value.Radians == double.NegativeInfinity;

        /// <inheritdoc/>
        public static bool IsInteger(Radian value) => false;

        /// <inheritdoc/>
        public static bool IsNaN(Radian value) => double.IsNaN(value.Radians);

        /// <inheritdoc/>
        public static bool IsNegative(Radian value) => value.Radians < 0;

        /// <inheritdoc/>
        public static bool IsNegativeInfinity(Radian value) => value.Radians == double.NegativeInfinity;

        /// <inheritdoc/>
        public static bool IsNormal(Radian value) => true;

        /// <inheritdoc/>
        public static bool IsOddInteger(Radian value) => false;

        /// <inheritdoc/>
        public static bool IsPositive(Radian value) => value.Radians > 0;

        /// <inheritdoc/>
        public static bool IsPositiveInfinity(Radian value) => value.Radians == double.PositiveInfinity;

        /// <inheritdoc/>
        public static bool IsRealNumber(Radian value) => !IsNaN(value);

        /// <inheritdoc/>
        public static bool IsSubnormal(Radian value) => false;

        /// <inheritdoc/>
        public static bool IsZero(Radian value) => value.Radians == 0;

        /// <inheritdoc/>
        public static Radian MaxMagnitude(Radian x, Radian y) => new Radian(Math.Max(x.Radians, y.Radians));

        /// <inheritdoc/>
        public static Radian MaxMagnitudeNumber(Radian x, Radian y) => new Radian(Math.Max(x.Radians, y.Radians));

        /// <inheritdoc/>
        public static Radian MinMagnitude(Radian x, Radian y) => new Radian(Math.Min(x.Radians, y.Radians));

        /// <inheritdoc/>
        public static Radian MinMagnitudeNumber(Radian x, Radian y) => new Radian(Math.Min(x.Radians, y.Radians));

        /// <inheritdoc/>
        public static Radian Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider) => new Radian(double.Parse(s, style, provider));

        /// <inheritdoc/>
        public static Radian Parse(string s, NumberStyles style, IFormatProvider? provider) => new Radian(double.Parse(s, style, provider));

        /// <inheritdoc/>
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Radian result)
        {
            double o;
            if (!double.TryParse(s, style, provider, out o))
            {
                result = default;
                return false;
            }

            result = new Radian(o);
            return true;
        }

        /// <inheritdoc/>
        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Radian result)
        {
            double o;
            if (!double.TryParse(s, style, provider, out o))
            {
                result = default;
                return false;
            }

            result = new Radian(o);
            return true;
        }

        /// <inheritdoc/>
        public bool Equals(Radian other) => Radians.Equals(other.Radians);

        /// <inheritdoc/>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => Radians.TryFormat(destination, out charsWritten, format, provider);

        /// <inheritdoc/>
        public string ToString(string? format, IFormatProvider? formatProvider) => Radians.ToString(format, formatProvider);

        /// <inheritdoc/>
        public static Radian Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => new Radian(double.Parse(s, provider));

        /// <inheritdoc/>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Radian result)
        {
            double o;
            if (!double.TryParse(s, provider, out o))
            {
                result = default;
                return false;
            }

            result = new Radian(o);
            return true;
        }

        /// <inheritdoc/>
        public static Radian Parse(string s, IFormatProvider? provider) => new Radian(double.Parse(s, provider));

        /// <inheritdoc/>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Radian result)
        {
            double o;
            if (!double.TryParse(s, provider, out o))
            {
                result = default;
                return false;
            }

            result = new Radian(o);
            return true;
        }

        static bool INumberBase<Radian>.TryConvertFromChecked<TOther>(TOther value, out Radian result) => throw new NotImplementedException();

        static bool INumberBase<Radian>.TryConvertFromSaturating<TOther>(TOther value, out Radian result) => throw new NotImplementedException();

        static bool INumberBase<Radian>.TryConvertFromTruncating<TOther>(TOther value, out Radian result) => throw new NotImplementedException();

        static bool INumberBase<Radian>.TryConvertToChecked<TOther>(Radian value, out TOther result) => throw new NotImplementedException();

        static bool INumberBase<Radian>.TryConvertToSaturating<TOther>(Radian value, out TOther result) => throw new NotImplementedException();

        static bool INumberBase<Radian>.TryConvertToTruncating<TOther>(Radian value, out TOther result) => throw new NotImplementedException();

        /// <inheritdoc/>
        public static bool operator >(Radian left, Radian right) => left.Radians > right.Radians;

        /// <inheritdoc/>
        public static bool operator >=(Radian left, Radian right) => left.Radians >= right.Radians;

        /// <inheritdoc/>
        public static bool operator <(Radian left, Radian right) => left.Radians < right.Radians;

        /// <inheritdoc/>
        public static bool operator <=(Radian left, Radian right) => left.Radians <= right.Radians;

        /// <inheritdoc/>
        public static Radian operator %(Radian left, Radian right) => new Radian(left.Radians % right.Radians);

        /// <inheritdoc/>
        public static Radian operator +(Radian left, Radian right) => new Radian(left.Radians + right.Radians);

        /// <inheritdoc/>
        public static Radian operator --(Radian value) => new Radian(value.Radians - 1);

        /// <inheritdoc/>
        public static Radian operator /(Radian left, Radian right) => new Radian(left.Radians / right.Radians);

        /// <inheritdoc/>
        public static bool operator ==(Radian left, Radian right) => left.Radians == right.Radians;

        /// <inheritdoc/>
        public static bool operator !=(Radian left, Radian right) => left.Radians != right.Radians;

        /// <inheritdoc/>
        public static Radian operator ++(Radian value) => new Radian(value.Radians + 1);

        /// <inheritdoc/>
        public static Radian operator *(Radian left, Radian right) => new Radian(left.Radians * right.Radians);

        /// <inheritdoc/>
        public static Radian operator -(Radian left, Radian right) => new Radian(left.Radians - right.Radians);

        /// <inheritdoc/>
        public static Radian operator -(Radian value) => new Radian(-value.Radians);

        /// <inheritdoc/>
        public static Radian operator +(Radian value) => new Radian(+value.Radians);

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object? obj) => obj is Radian radian && Equals(radian);

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => Radians.GetHashCode();
    }
}
