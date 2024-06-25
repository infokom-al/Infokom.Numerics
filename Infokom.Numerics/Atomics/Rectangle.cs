using static Infokom.Numerics.Math<double>;

namespace Infokom.Numerics.Atomics
{
	public readonly struct Rectangle : ICurve<(double X, double Y)>
	{
		private readonly double dx, dy;

		public Rectangle(double a, double b) => (this.dx, this.dy) = (a/2, b/2);

		public (double X, double Y) this[int index] => index switch
		{
			0 => (dx, dy),
			1 => (-dx, dy),
			2 => (-dx, -dy),
			3 => (dx, -dy),
			_ => throw new IndexOutOfRangeException()
		};

		public (double X, double Y) this[double t]
		{
			get
			{		


				if(t > -dy && t <= dy)
				{
					return (this.dx, t);
				}
				else 
				{
					return (this.dx * cos(t), dy);
				}

			}
		}
	}
}
