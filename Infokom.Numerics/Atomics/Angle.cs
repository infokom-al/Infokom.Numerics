using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using static Infokom.Numerics.Math<double>;

namespace Infokom.Numerics.Atomics
{


	public partial struct Angle : INumberBase<Angle>
	{
		public static Angle One => throw new NotImplementedException();

		public static int Radix => throw new NotImplementedException();

		public static Angle Zero => throw new NotImplementedException();

		public static Angle AdditiveIdentity => throw new NotImplementedException();

		public static Angle MultiplicativeIdentity => throw new NotImplementedException();

		public static bool IsCanonical(Angle value) => throw new NotImplementedException();
		public static bool IsComplexNumber(Angle value) => throw new NotImplementedException();
		public static bool IsEvenInteger(Angle value) => throw new NotImplementedException();
		public static bool IsFinite(Angle value) => throw new NotImplementedException();
		public static bool IsImaginaryNumber(Angle value) => throw new NotImplementedException();
		public static bool IsInfinity(Angle value) => throw new NotImplementedException();
		public static bool IsInteger(Angle value) => throw new NotImplementedException();
		public static bool IsNaN(Angle value) => throw new NotImplementedException();
		public static bool IsNegative(Angle value) => throw new NotImplementedException();
		public static bool IsNegativeInfinity(Angle value) => throw new NotImplementedException();
		public static bool IsNormal(Angle value) => throw new NotImplementedException();
		public static bool IsOddInteger(Angle value) => throw new NotImplementedException();
		public static bool IsPositive(Angle value) => throw new NotImplementedException();
		public static bool IsPositiveInfinity(Angle value) => throw new NotImplementedException();
		public static bool IsRealNumber(Angle value) => throw new NotImplementedException();
		public static bool IsSubnormal(Angle value) => throw new NotImplementedException();
		public static bool IsZero(Angle value) => throw new NotImplementedException();
		public static Angle MaxMagnitude(Angle x, Angle y) => throw new NotImplementedException();
		public static Angle MaxMagnitudeNumber(Angle x, Angle y) => throw new NotImplementedException();
		public static Angle MinMagnitude(Angle x, Angle y) => throw new NotImplementedException();
		public static Angle MinMagnitudeNumber(Angle x, Angle y) => throw new NotImplementedException();
		public static Angle Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider) => throw new NotImplementedException();
		public static Angle Parse(string s, NumberStyles style, IFormatProvider provider) => throw new NotImplementedException();
		public static Angle Parse(ReadOnlySpan<char> s, IFormatProvider provider) => throw new NotImplementedException();
		public static Angle Parse(string s, IFormatProvider provider) => throw new NotImplementedException();
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Angle result) => throw new NotImplementedException();
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Angle result) => throw new NotImplementedException();
		public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Angle result) => throw new NotImplementedException();
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Angle result) => throw new NotImplementedException();
		static bool INumberBase<Angle>.TryConvertFromChecked<TOther>(TOther value, out Angle result) => throw new NotImplementedException();
		static bool INumberBase<Angle>.TryConvertFromSaturating<TOther>(TOther value, out Angle result) => throw new NotImplementedException();
		static bool INumberBase<Angle>.TryConvertFromTruncating<TOther>(TOther value, out Angle result) => throw new NotImplementedException();
		static bool INumberBase<Angle>.TryConvertToChecked<TOther>(Angle value, out TOther result) => throw new NotImplementedException();
		static bool INumberBase<Angle>.TryConvertToSaturating<TOther>(Angle value, out TOther result) => throw new NotImplementedException();
		static bool INumberBase<Angle>.TryConvertToTruncating<TOther>(Angle value, out TOther result) => throw new NotImplementedException();
		public string ToString(string format, IFormatProvider formatProvider) => throw new NotImplementedException();
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) => throw new NotImplementedException();

		public static Angle operator +(Angle value) => throw new NotImplementedException();
		public static Angle operator ++(Angle value) => throw new NotImplementedException();
		public static Angle operator --(Angle value) => throw new NotImplementedException();
		public static Angle operator *(Angle left, Angle right) => throw new NotImplementedException();
		public static Angle operator /(Angle left, Angle right) => throw new NotImplementedException();
	}
	
	public partial struct Angle : IFloatingPoint<Angle>
	{
		public static Angle E => throw new NotImplementedException();

		public static Angle Pi => throw new NotImplementedException();

		public static Angle Tau => throw new NotImplementedException();

		public static Angle NegativeOne => throw new NotImplementedException();

		public static Angle Round(Angle x, int digits, MidpointRounding mode) => throw new NotImplementedException();
		public int CompareTo(object obj) => throw new NotImplementedException();
		public int GetExponentByteCount() => throw new NotImplementedException();
		public int GetExponentShortestBitLength() => throw new NotImplementedException();
		public int GetSignificandBitLength() => throw new NotImplementedException();
		public int GetSignificandByteCount() => throw new NotImplementedException();
		public bool TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten) => throw new NotImplementedException();
		public bool TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten) => throw new NotImplementedException();
		public bool TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten) => throw new NotImplementedException();
		public bool TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten) => throw new NotImplementedException();

		public static Angle operator %(Angle left, Angle right) => throw new NotImplementedException();
	}

	public partial struct Angle : IMinMaxValue<Angle>
	{
		public static Angle MinValue => -Pi;

		public static Angle MaxValue => +Pi;
	}

	public partial struct Angle : IComparable<Angle>, IEquatable<Angle>, INumberBase<Angle>
	{
		private readonly double value;

		private Angle(double value) => this.value = value;

		public bool Equals(Angle other) => this.value.Equals(other.value);
		public int CompareTo(Angle other) => this.value.CompareTo(other.value);
		public override int GetHashCode() => this.value.GetHashCode();
		public override bool Equals(object obj) => obj is Angle && Equals((Angle)obj);




		public double Rad => this.value;

		public static implicit operator Angle(double rad) => new Angle(double.Atan2(sin(rad), cos(rad)));

		public static Angle Abs(Angle θ) => new Angle(Math.Abs(θ.value));

		public static double Cos(Angle θ) => Math.Cos(θ.value);



		public static double Sin(Angle θ) => Math.Sin(θ.value);
		public static double Tan(Angle θ) => Math.Tan(θ.value);

		public static Angle Acos(double d) => new(Math.Acos(d));
		public static Angle Asin(double d) => new Angle(Math.Asin(d));
		public static Angle Atan(double x) => new Angle(Math.Atan(x));
		public static Angle Atan2(double y, double x) => new Angle(Math.Atan2(y, x));

		public static bool operator ==(Angle θ, Angle φ) => θ.value == φ.value;

		public static bool operator !=(Angle θ, Angle φ) => θ.value != φ.value;

		public static bool operator <(Angle θ, Angle φ) => θ.value < φ.value;
		public static bool operator >(Angle θ, Angle φ) => θ.value > φ.value;
		public static bool operator <=(Angle θ, Angle φ) => θ.value <= φ.value;
		public static bool operator >=(Angle θ, Angle φ) => θ.value >= φ.value;

		public static Angle operator *(double k, Angle θ) => (Angle)(k * θ.value);
		public static Angle operator *(Angle θ, double k) => k * θ;
		public static Angle operator /(Angle θ, double k) => (1 / k) * θ;

		public static Angle operator +(Angle θ, Angle φ) => (Angle)(θ.value + φ.value);
		public static Angle operator -(Angle θ) => (Angle)(-θ.value);
		public static Angle operator -(Angle θ, Angle φ) => (Angle)(θ.value - φ.value);		
	}
}
