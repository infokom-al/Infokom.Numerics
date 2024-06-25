namespace Infokom.Numerics
{
	public interface ISurface<TPoint>
	{
		ICurve<TPoint> this[double t] { get; }
		TPoint this[double t, double x] { get; }
	}


}