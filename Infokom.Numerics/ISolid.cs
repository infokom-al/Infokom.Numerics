namespace Infokom.Numerics
{
	public interface ISolid<TPoint>
	{
		ISurface<TPoint> this[double t] { get; }
		ICurve<TPoint> this[double t, double x] { get; }
		TPoint this[double t, double x, double y] { get; }
	}


}