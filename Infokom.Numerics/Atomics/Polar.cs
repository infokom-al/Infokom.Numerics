using System.Numerics;

using static Infokom.Numerics.Math<double>;

namespace Infokom.Numerics.Atomics
{
#pragma warning disable IDE1006
	public readonly record struct Polar(double ρ, double θ) :
#pragma warning restore IDE1006
		IAdditiveIdentity<Polar, Polar>, 
		IAdditionOperators<Polar, Polar, Polar>, 
		ISubtractionOperators<Polar, Polar, Polar>, 
		IUnaryNegationOperators<Polar, Polar>, 
		IMultiplicativeIdentity<Polar, double>,
		IMultiplyOperators<Polar, double, Polar>, 
		IDivisionOperators<Polar, double, Polar>

	{
		public static readonly Polar Zero = new Polar(0, 0);
		public static readonly Polar UnitX = new Polar(1, 0);
		public static readonly Polar UnitY = new Polar(1, π/2);

		public static Polar AdditiveIdentity => Zero;

		public static double MultiplicativeIdentity => 1;

		public static Polar operator +(Polar p1, Polar q1)
		{
			var (ρ1, θ1) = p1;
			var (ρ2, θ2) = q1;

			var ρ = sqrt(ρ1*ρ1 + ρ2*ρ2 + 2*ρ1*ρ2*cos(θ2 - θ1));
			var θ = θ1 + atan2(ρ2*sin(θ2 - θ1), ρ1 + ρ2*cos(θ2 - θ1));

			return new(ρ, θ);

		}

		public static Polar operator -(Polar p) => throw new NotImplementedException();
		public static Polar operator -(Polar p, Polar q) => throw new NotImplementedException();
		public static Polar operator *(Polar p, double k) => throw new NotImplementedException();
		public static Polar operator /(Polar p, double k) => throw new NotImplementedException();
	}
}
