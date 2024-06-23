namespace Infokom.Numerics
{

	public interface IPoint<TPoint> where TPoint : IPoint<TPoint>
	{
		static abstract double Dist(TPoint a, TPoint b);
		static abstract TPoint Lerp(TPoint a, TPoint b, double t);
	}
}