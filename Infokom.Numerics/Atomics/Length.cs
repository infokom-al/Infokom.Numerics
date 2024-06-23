using System.Collections;
using System.Numerics;

namespace Infokom.Numerics.Atomics
{









	public readonly partial struct Length : 
		IEqualityOperators<Length, Length, bool>, 
		IComparisonOperators<Length, Length, bool>, 
		ISubtractionOperators<Length, Length, double>, 
		IDivisionOperators<Length, Length, double>
	{
		private readonly double value;

		private Length(double value) => this.value = value;

		public override int GetHashCode() => this.value.GetHashCode();

		public override bool Equals(object obj) => obj is Length other && Equals(other);
		public bool Equals(Length other) => this.value.Equals(other.value);

		public int CompareTo(object obj) => obj is Length other ? this.CompareTo(other) : throw new ArgumentException("Not comparable value!", nameof(obj));
		public int CompareTo(Length other) => this.value.CompareTo(other.value);



		

		public static implicit operator Length(double value) => value >= 0 ? new(value) : throw new ArgumentOutOfRangeException(nameof(value), value, "Must be non negative!");

		public static implicit operator double(Length length) => length.value;

		public static bool operator ==(Length a, Length b) => a.value == b.value;
		public static bool operator !=(Length a, Length b) => a.value != b.value;

		public static bool operator >(Length a, Length b) => a.value > b.value;
		public static bool operator >=(Length a, Length b) => a.value >= b.value;
		public static bool operator <(Length a, Length b) => a.value < b.value;
		public static bool operator <=(Length a, Length b) => a.value <= b.value;

		public static double operator -(Length a, Length b) => a.value - b.value;
		public static double operator /(Length a, Length b) => a.value / b.value;


		public static Length Zero => new(0.0d);
		public static Length Unit => new(1.0d);
		public static Length Maximum => new(double.MaxValue);
		public static Length Infinity => new(double.PositiveInfinity);
		public static Length NaN => new(double.NaN);
	}




}
