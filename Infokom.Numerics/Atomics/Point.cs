using Infokom.Numerics.Extensions;

using System.Numerics;

using static Infokom.Numerics.Math<double>;

namespace Infokom.Numerics.Atomics
{
	public interface IVector<V> where V : IVector<V>
	{
		static abstract IReadOnlyList<V> Basis { get; }
		static int Dimension => V.Basis.Count;

		static abstract double Dot(V v, V w);
	}





	public static class Euclidean<T, Θ>
	   where T : ISignedNumber<T>
	   where Θ : ITrigonometricFunctions<Θ>
	{




		public readonly record struct Point(double X, double Y)
		{
			public static Vector operator -(Point p, Point q) => new(p.X - q.X, p.Y - q.Y);
			public static Point operator +(Point p, Vector v) => new(p.X + v.X, p.Y + v.Y);
			public static Point operator -(Point p, Vector v) => new(p.X - v.X, p.Y - v.Y);
		}



		public readonly record struct Vector(double X, double Y)
		{
			public double Norm => double.Hypot(X, Y);

			public (double, double) Direction => (X / Norm, Y / Norm);


			public static readonly Vector Zero = new(0, 0);
			public static readonly Vector UnitX = new(1, 0);
			public static readonly Vector UnitY = new(0, 1);



			public static Vector operator +(Vector v, Vector w) => new(v.X + w.X, v.Y + w.Y);

			public static Vector operator -(Vector v) => new(-v.X, -v.Y);

			public static Vector operator -(Vector v, Vector w) => v + -w;

			public static Vector operator *(double k, Vector v) => new(k * v.X, k * v.Y);

			public static Vector operator *(Vector v, double k) => new(v.X * k, v.Y * k);

			public static Vector operator /(Vector v, double k) => new(v.X / k, v.Y / k);

			public static double Dot(Vector v, Vector w) => v.X * w.X + v.Y * w.Y;
		}




		public readonly record struct Segment(Point A, Point B)
		{
			public Point this[double t]
			{
				get
				{
					ArgumentOutOfRangeException.ThrowIfNegative(t, nameof(t));
					ArgumentOutOfRangeException.ThrowIfGreaterThan(t, 1, nameof(t));

					if (t == 0) return A;

					if (t == 1) return B;

					return A + t * (B - A);
				}
			}
		}




		public readonly record struct Curve(Func<double, double> X, Func<double, double> Y)
		{
			public Curve(double x0, Func<double, double> y) : this(t => x0, y)
			{

			}

			public Curve(Func<double, double> x, double y0) : this(x, t => y0)
			{

			}

			public Point this[double t] => new Point(X(t), Y(t));



			public static Curve Rotate(Curve curve, double θ)
			{
				var (x, y) = curve;
				var (rx, ry) = (cos(θ), sin(θ));

				x = t => rx * x(t) - ry * y(t);
				y = t => ry * x(t) + rx * y(t);

				return new Curve(x, y);
			}

			public static Curve AxisX { get; } = Line(1, 0, 0);
			public static Curve AxisY { get; } = Line(0, 1, 0);

			/// <summary>
			/// ax + by + c = 0
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <param name="c"></param>
			/// <returns></returns>
			public static Curve Line(double a, double b, double c) => new Curve(t => t, t => -a/b + c);

			/// <summary>
			/// y = mx + c
			/// </summary>
			/// <param name="m"></param>
			/// <param name="y0"></param>
			/// <returns></returns>
			public static Curve Line(double m, double y0) => Line(1, m, y0);

			/// <summary>
			/// y = mx + c
			/// </summary>
			/// <param name="m"></param>
			/// <param name="c"></param>
			/// <returns></returns>
			public static Curve Line(double m) => Line(m, 0);



			public static Curve Circle(double r) => new Curve(t => r * cos(t), t => r * sin(t));
			public static Curve Ellipse(double rx, double ry) => new Curve(t => rx * cos(t), t => ry * sin(t));



			public static Curve operator+(Curve curve, Vector offset)
			{
				var (x, y) = curve;
				var (dx, dy) = offset;

				x = t => x(t) + dx;
				y = t => y(t) + dy;

				return new Curve(x, y);
			}
		}



		public readonly record struct Circle(Point P, double R)
		{
			private readonly double x;
			private readonly double y;
			private readonly double r;

			public Circle(double r) : this(0, 0, 2)
			{
				x = 0;
				y = 0;
				this.r = r;
			}

			public Circle(double x, double y, double r) : this(new Point(x, y), r)
			{
				this.x = x;
				this.y = y;
				this.r = r;
			}

			/// <summary>
			/// Arc length/Perimeter
			/// </summary>
			public double L => 2 * π * R;

			/// <summary>
			/// Diameter
			/// </summary>
			public double D => 2 * R;

			/// <summary>
			/// Area
			/// </summary>
			public double A => π * R * R;




			public Point this[double t] => new(X(t), Y(t));

			public double X(double t) => P.X + R * cos(t);
			public double Y(double t) => P.Y + R * sin(t);


			public static Circle Zero => new() { R = 0 };
			public static Circle Unit => new() { R = 1 };

			public static Circle operator +(Circle c, Vector v) => new() { P = c.P + v, R = c.R };

			public static Circle operator -(Circle c, Vector v) => c + -v;

			public static Circle operator *(Circle c, double k) => throw new NotImplementedException();

			public static Circle operator *(double k, Circle c) => throw new NotImplementedException();

			public static Circle operator /(Circle c, double k) => throw new NotImplementedException();
		}




		public class Path : List<Point>
		{
			
			public double Length => Enumerable.Range(0, this.Count - 1).Select(i => (this[i] - this[i + 1]).Norm).Sum();

			public IEnumerable<Segment> Segments => Enumerable.Range(0, this.Count - 1).Select(i => new Segment(this[i], this[i + 1]));
		}

	}




}
