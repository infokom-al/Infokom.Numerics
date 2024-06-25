using System.Numerics;

namespace Infokom.Numerics.Atomics
{
	public static class Line
	{

	}

	public readonly struct Line<Tx, Ty> where Tx : ISignedNumber<Tx> where Ty : ISignedNumber<Ty>
	{
		/// <summary>
		/// Create a line in the Euclidean plane described by the equation <paramref name="a"/>x + <paramref name="b"/>y + <paramref name="c"/> = 0
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		public Line(double a, double b, double c)
		{

		}

		public Point<Tx, Ty> this[double t] => throw new NotImplementedException();




		/// <summary>
		/// Instance of the <see cref="Line{Tx, Ty}">line</see> of the line passing through to distinct points.
		/// </summary>
		/// <param name="p"></param>
		/// <param name="q"></param>
		/// <returns></returns>
		public static Line<Tx, Ty> From(Point<Tx, Ty> p, Point<Tx, Ty> q)
		{
			if (p == q)
				throw new ArgumentException("Required two ditinct points!");

			var u = p.ToVector();
			var v = q.ToVector();

			var n = (q - p).Ortoghonal.Direction;

			var a = n.X;
			var b = n.Y;
			var c = v.X * u.Y - v.Y * u.X;

		}
	}

	public readonly struct Line<Tx, Ty, Tz> where Tx : ISignedNumber<Tx>, IConvertible where Ty : ISignedNumber<Ty>, IConvertible where Tz : ISignedNumber<Tz>, IConvertible
	{
		public Point<Tx, Ty, Tz> this[double t] => throw new NotImplementedException();
	}
}
