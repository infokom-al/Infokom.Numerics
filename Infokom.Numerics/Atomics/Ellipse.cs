using static Infokom.Numerics.Math<double>;

namespace Infokom.Numerics.Atomics
{
	public readonly struct Ellipse : ICurve<(double X, double Y)>
	{
		private readonly double a;
		private readonly double b;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a">Semi-major axis</param>
		/// <param name="b">Semi-minor axis</param>
		public Ellipse(double a, double b)
		{
			this.a = a;
			this.b = b;
		}

		public (double X, double Y) this[double t] => (a * cos(t), b * sin(t));
	}
}
