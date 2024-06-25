using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace Infokom.Numerics.Atomics
{
	public struct Circle : ICurve<(double X, double Y)>
	{
		public readonly double r;

		public Circle(double r) => this.r = r;

		public double X(double t) => r * double.Cos(t);

		public double Y(double t) => r * double.Sin(t);

		public (double X, double Y) this[double t] => (X(t), Y(t));


		public static Circle Zero => new Circle(0);

		public static Circle Unit => new Circle(0);
		
		public static Circle operator*(Circle c, double k) => new(c.r * k);
		public static Circle operator/(Circle c, double k) => new(c.r / k);
	}
}
