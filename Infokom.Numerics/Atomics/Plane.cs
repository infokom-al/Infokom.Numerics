using System.Numerics;


namespace Infokom.Numerics.Atomics
{
	public record struct Plane<Tx, Ty, Tz> : ISurface<Point<Tx, Ty, Tz>> where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty> where Tz : ISignedNumber<Tz>
	{
		/// <summary>
		/// Create a plane of equation <paramref name="a"/>x + <paramref name="b"/>y + <paramref name="c"/>z + <paramref name="d"/> = 0
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		public Plane(double a, double b, double c, double d) => throw new NotImplementedException();

		public ICurve<Point<Tx, Ty, Tz>> this[double t] => throw new NotImplementedException();

		public Point<Tx, Ty, Tz> this[double t, double x] => throw new NotImplementedException();

		public static Plane<Tx, Ty, Tz> From(Point<Tx, Ty, Tz> a, Point<Tx, Ty, Tz> b, Point<Tx, Ty, Tz> c) => throw new NotImplementedException();
	}
}
