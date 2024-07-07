using System.Collections;
using System.Numerics;

namespace Infokom.Numerics
{



	public interface IGeometric<TEntity> : IEqualityOperators<TEntity, TEntity, bool> where TEntity : IGeometric<TEntity>
	{
		double Length(int direction);

		static abstract int Dimension {  get; }
		static abstract double Dist(TEntity source, TEntity target);
		static abstract TEntity Scale(TEntity source, double factor);
		static abstract TEntity Lerp(TEntity source, TEntity target, double offset);
	}

	public interface IGeometric<TEntity, TPoint> : IGeometric<TEntity> where TEntity : IGeometric<TEntity, TPoint>
	{
		TPoint Centroid { get; }
		TPoint LowerBound { get; }
		TPoint UpperBound { get; }

		static abstract double Dist(TEntity entity, TPoint point);

		/// <summary>
		/// Move a geometric entity, by a certain amount, along the line passing from the centroid of that entity and some other point.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="target"></param>
		/// <param name="amount">A scalar value indicating the ammount of motion. 0 means no motion, 1 means moving the centroid to <paramref name="target"/></param>
		/// <returns></returns>
		static abstract TEntity Shift(TEntity source, TPoint target, double amount);
		static TEntity Lerp(TEntity source, TPoint target, double amount) => TEntity.Scale(TEntity.Shift(source, target, amount), amount);
	}


	public interface IPoint<TPoint> : IReadOnlyList<double> where TPoint : IPoint<TPoint>
	{



		static abstract TPoint Create(Func<int, double> coordinateSelector);
		static abstract TPoint Create(IEnumerable<double> coordinates);
	}



	public interface ICurve<TPoint>
	{
		public TPoint this[double t] { get; }
		public double Length { get; }
	}

}