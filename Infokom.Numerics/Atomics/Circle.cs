using System.Numerics;


using static Infokom.Numerics.Math<double>;

namespace Infokom.Numerics.Atomics
{


	public struct Circle
	{
		public readonly double r;

		private Circle(double r) => this.r = r;

		public (double X, double Y) this[double t] => (X(t), Y(t));

		/// <summary>
		/// Radius
		/// </summary>
		public double R => this.r;

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

		public double X(double t) => r * double.Cos(t);

		public double Y(double t) => r * double.Sin(t);


		public static Circle Zero => new Circle(0);

		public static Circle Unit => new Circle(0);
	}

	public struct Ellipse
	{

	}


}
