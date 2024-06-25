using System.Numerics;


namespace Infokom.Numerics.Atomics
{

	public static class Vector
	{
		public static Point<Tx, Ty> ToPoint<Tx, Ty>(this Vector<Tx, Ty> v) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> => new(Tx.CreateChecked(v.X), Ty.CreateChecked(v.Y));

		public static Point<Tx, Ty, Tz> ToPoint<Tx, Ty, Tz>(this Vector<Tx, Ty, Tz> v) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz> => new(Tx.CreateChecked(v.X), Ty.CreateChecked(v.Y),Tz.CreateChecked(v.Z));


		public static Vector<Tx, Ty, Tz> Lerp<Tx, Ty, Tz>(Vector<Tx, Ty, Tz> u, Vector<Tx, Ty, Tz> v, double t) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz> => u + (v - u) * t;
	}



	public readonly record struct Vector<Tx, Ty>(double X, double Y) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty>
	{
		public double Norm => double.Hypot(X, Y);
		public Vector<Tx, Ty> Direction => this / Norm;
		public Vector<Tx, Ty> Ortoghonal => new(-Y, X);

		public static Vector<Tx, Ty> operator+(Vector<Tx, Ty> v, Vector<Tx, Ty> w) => new(v.X + w.X, v.Y + w.Y);
		public static Vector<Tx, Ty> operator-(Vector<Tx, Ty> v, Vector<Tx, Ty> w) => new(v.X - w.X, v.Y - w.Y);
		public static Vector<Tx, Ty> operator*(Vector<Tx, Ty> v, double k) => new(v.X * k, v.Y * k);
		public static Vector<Tx, Ty> operator/(Vector<Tx, Ty> v, double k) => new(v.X / k, v.Y / k);



		public static readonly Vector<Tx, Ty> zero = new(0, 0);
		public static readonly Vector<Tx, Ty> ux = new(1, 0), uy = new(0, 1);
	}

	public readonly record struct Vector<Tx, Ty, Tz>(double X, double Y, double Z) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz>
	{
		public double Norm => double.Hypot(double.Hypot(X, Y), Z);
		public Vector<Tx, Ty, Tz> Direction => this / Norm;

		public static readonly Vector<Tx, Ty, Tz> zero = new(0, 0, 0);
		public static readonly Vector<Tx, Ty, Tz> ux = new(1, 0, 0), uy = new(0, 1, 0), uz = new(0, 0, 1);

		public static Vector<Tx, Ty, Tz> operator +(Vector<Tx, Ty, Tz> v, Vector<Tx, Ty, Tz> w) => new(v.X + w.X, v.Y + w.Y, v.Z + w.Z);
		public static Vector<Tx, Ty, Tz> operator -(Vector<Tx, Ty, Tz> v, Vector<Tx, Ty, Tz> w) => new(v.X - w.X, v.Y - w.Y, v.Z - w.Z);
		public static Vector<Tx, Ty, Tz> operator *(Vector<Tx, Ty, Tz> v, double k) => new(v.X * k, v.Y * k,v.Z * k);
		public static Vector<Tx, Ty, Tz> operator /(Vector<Tx, Ty, Tz> v, double k) => new(v.X / k, v.Y / k, v.Z / k);
	}
}
