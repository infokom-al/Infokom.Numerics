using System;
using System.Numerics;


namespace Infokom.Numerics.Atomics
{
	public static class Point
	{	
		



		#region 2D

		public static Point<Tx, Ty> ToPoint<Tx, Ty>(this ValueTuple<Tx, Ty> source) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> => new(source.Item1, source.Item2);
		public static Vector<Tx, Ty> ToVector<Tx, Ty>(this Point<Tx, Ty> source) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> => new(double.CreateChecked(source.X), double.CreateChecked(source.Y));



		public static double Distance<Tx, Ty>(Point<Tx, Ty> p, Point<Tx, Ty> q) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> => (p - q).Norm;

		public static Point<Tx, Ty> Lerp<Tx, Ty>(Point<Tx, Ty> p, Point<Tx, Ty> q, double t) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> => p + (q - p) * t;




		public static Point<Tx, Ty> Centroid<Tx, Ty>(this IEnumerable<Point<Tx, Ty>> source) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty>
		{
			var nx = Tx.Zero; var ny = Ty.Zero;
			var sx = Tx.Zero; var sy = Ty.Zero;

			foreach(var (x, y) in source)
			{
				sx += x; sy += y;
				nx++; ny++;
			}

			return new(sx/nx, sy/ny);
		}





		#endregion










		#region 3D

		public static Point<Tx, Ty, Tz> ToPoint<Tx, Ty, Tz>(this ValueTuple<Tx, Ty, Tz> source) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz> => new(source.Item1, source.Item2, source.Item3);


		public static Vector<Tx, Ty, Tz> ToVector<Tx, Ty, Tz>(this Point<Tx, Ty, Tz> source) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz> => new(double.CreateChecked(source.X), double.CreateChecked(source.Y), double.CreateChecked(source.Z));
		
		public static double Distance<Tx, Ty, Tz>(Point<Tx, Ty, Tz> p, Point<Tx, Ty, Tz> q) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz> => (p - q).Norm;

		public static Vector<Tx, Ty, Tz> Centroid<Tx, Ty, Tz>(this IEnumerable<Point<Tx, Ty, Tz>> source) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz>
		{
			var n = 0;
			var sv = Vector<Tx, Ty, Tz>.zero;
			foreach (var v in source.Select(ToVector))
			{
				sv += v;
				n++;
			}

			return sv;
		}


		public static Point<Tx, Ty, Tz> LowerBound<Tx, Ty, Tz>(this IEnumerable<Point<Tx, Ty, Tz>> source) where Tx : INumber<Tx>, ISignedNumber<Tx> where Ty : INumber<Ty>, ISignedNumber<Ty> where Tz : INumber<Tz>, ISignedNumber<Tz> => source.Aggregate((p1, p2) => new(Tx.Min(p1.X, p2.X), Ty.Min(p1.Y, p2.Y), Tz.Min(p1.Z, p2.Z)));
		public static Point<Tx, Ty, Tz> UpperBound<Tx, Ty, Tz>(this IEnumerable<Point<Tx, Ty, Tz>> source) where Tx : INumber<Tx>, ISignedNumber<Tx> where Ty : INumber<Ty>, ISignedNumber<Ty> where Tz : INumber<Tz>, ISignedNumber<Tz> => source.Aggregate((p1, p2) => new(Tx.Max(p1.X, p2.X), Ty.Max(p1.Y, p2.Y), Tz.Max(p1.Z, p2.Z)));
		public static Point<Tx, Ty, Tz> UpperBound<Tx, Ty, Tz>(this IEnumerable<Point<Tx, Ty, Tz>> source) where Tx : INumber<Tx>, ISignedNumber<Tx> where Ty : INumber<Ty>, ISignedNumber<Ty> where Tz : INumber<Tz>, ISignedNumber<Tz> => source.Aggregate((p1, p2) => new(Tx.Max(p1.X, p2.X), Ty.Max(p1.Y, p2.Y), Tz.Max(p1.Z, p2.Z)));




		public static Point<Tx, Ty, Tz> Lerp<Tx, Ty, Tz>(Point<Tx, Ty, Tz> p, Point<Tx, Ty, Tz> q, double t) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz> => p + (q - p) * t;


		





		#endregion
	}


	public readonly record struct Point<Tx, Ty>(Tx X, Ty Y) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty>
	{
		

		public static implicit operator Point<Tx, Ty>(ValueTuple<Tx, Ty> source) => new	(source.Item1, source.Item2);

		public static Vector<Tx, Ty> operator-(Point<Tx, Ty> p, Point<Tx, Ty> q) => p.ToVector() - q.ToVector();
		public static Point<Tx, Ty> operator+(Point<Tx, Ty> p, Vector<Tx, Ty> v) => (p.ToVector() + v).ToPoint();
		public static Point<Tx, Ty> operator-(Point<Tx, Ty> p, Vector<Tx, Ty> v) => (p.ToVector() - v).ToPoint();

		public static Point<Tx, Ty> Zero => (Tx.Zero, Ty.Zero);


	}

	public readonly record struct Point<Tx, Ty, Tz>(Tx X, Ty Y, Tz Z) where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz>
	{





		public static Vector<Tx, Ty, Tz> operator -(Point<Tx, Ty, Tz> p, Point<Tx, Ty, Tz> q) => p.ToVector() - q.ToVector();
		public static Point<Tx, Ty, Tz> operator +(Point<Tx, Ty, Tz> p, Vector<Tx, Ty, Tz> v) => (p.ToVector() + v).ToPoint();
		public static Point<Tx, Ty, Tz> operator -(Point<Tx, Ty, Tz> p, Vector<Tx, Ty, Tz> v) => (p.ToVector() - v).ToPoint();


		public static Point<Tx, Ty, Tz> Zero => new(Tx.Zero, Ty.Zero, Tz.Zero);
	}
}
