namespace Infokom.Numerics
{
	public interface ICurve<TPoint>
	{
		TPoint this[double t] { get; }
	}


}