using System.Linq;
using System.Numerics;

using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Infokom.Numerics
{


	public static class EuclideanFunctions
	{
#pragma warning disable IDE1006 // Naming Styles
		#region Scalars	
		public static T lerp<T>(T a, T b, T t) where T : IFloatingPointIeee754<T> => T.Lerp(a, b, t);

		/// <summary>
		/// Calculate polar cordinates from cartesian x and y coordinates
		/// </summary>
		/// <typeparam name="T">Scalar type use for coordinates</typeparam>
		/// <param name="x">coordinate along the x-axis</param>
		/// <param name="y">coordinate along the y-axis</param>
		/// <returns>polar coordinates of the point (<paramref name="x"/>, <paramref name="y"/>)</returns>
		public static (T ρ, T φ) car2pol<T>(T x, T y) where T : IFloatingPointIeee754<T> => (hypot(x, y), atan2(y, x));
		public static (T ρ, T φ, T z) car2pol<T>(T x, T y, T z) where T : IFloatingPointIeee754<T> => (hypot(x, y), atan2(y, x), z);
		#endregion

		#region 2-tuples
		public static (T X, T Y) lerp<T>((T X, T Y) a, (T X, T Y) b, T t) where T : IFloatingPointIeee754<T> => (lerp(a.X, b.X, t), lerp(a.Y, b.Y, t));
		public static T dot<T>((T X, T Y) a, (T X, T Y) b) where T : IAdditionOperators<T, T, T>, IMultiplyOperators<T, T, T> => a.X * b.X + a.Y * b.Y;
		public static T cross<T>((T X, T Y) a, (T X, T Y) b) where T : ISubtractionOperators<T, T, T>, IMultiplyOperators<T, T, T> => a.X * b.Y - a.Y * b.X;
		public static T norm<T>((T X, T Y) a) where T : IAdditionOperators<T, T, T>, IMultiplyOperators<T, T, T>, IRootFunctions<T> => sqrt(dot(a, a));
		public static T phase<T>((T X, T Y) a) where T : IFloatingPointIeee754<T> => atan2(a.Y, a.X);

		public static (T R, T Θ) car2pol<T>((T X, T Y) a) where T : IFloatingPointIeee754<T> => (norm(a), phase(a));
		public static (T X, T Y) pol2car<T>((T R, T Θ) a) where T : IFloatingPointIeee754<T> => (a.R * cos(a.Θ), a.R * sin(a.Θ));
		#endregion

		#region 3-tuples
		public static (T X, T Y, T Z) lerp<T>((T X, T Y, T Z) a, (T X, T Y, T Z) b, T t) where T : IFloatingPointIeee754<T> => (lerp(a.X, b.X, t), lerp(a.Y, b.Y, t), lerp(a.Z, b.Z, t));
		public static T dot<T>((T X, T Y, T Z) u, (T X, T Y, T Z) v) where T : IAdditionOperators<T, T, T>, IMultiplyOperators<T, T, T> => u.X*v.X + u.Y*v.Y + u.Z*v.Z;
		public static (T X, T Y, T Z) cross<T>((T X, T Y, T Z) u, (T X, T Y, T Z) v) where T : ISubtractionOperators<T, T, T>, IMultiplyOperators<T, T, T> => (u.Y*v.Z - u.Z*v.Y, u.Z*v.X - u.X*v.Z, u.X*v.Y - u.Y*v.X);
		public static T norm<T>((T X, T Y, T Z) a) where T : IAdditionOperators<T, T, T>, IMultiplyOperators<T, T, T>, IRootFunctions<T> => sqrt(dot(a, a));

		public static (T R, T Θ, T Z) car2pol<T>((T X, T Y, T Z) a) where T : IFloatingPointIeee754<T> => (hypot(a.X, a.Y), atan2(a.Y, a.X), a.Z);
		public static (T X, T Y, T Z) pol2car<T>((T R, T Θ, T Z) a) where T : IFloatingPointIeee754<T> => (a.R * cos(a.Θ), a.R * sin(a.Θ), a.Z);
		#endregion

		#region arrays
		public static T dot<T>(T[] a, T[] b) where T : IAdditionOperators<T, T, T>, IMultiplyOperators<T, T, T> => Enumerable.Zip(a, b, mul).Sum();
		public static T norm<T>(T[] a) where T : IRootFunctions<T> => sqrt(dot(a, a));
		#endregion
#pragma warning restore IDE1006 // Naming Styles
	}



	public static class StatisticFunctions
	{
#pragma warning disable IDE1006 // Naming Styles
		#region Scalars	
		#endregion

		#region 2-tuples

		#endregion

		#region 3-tuples

		#endregion

		#region arrays

		#endregion

		#region enumerables
		public static T MinAbs<T>(this IEnumerable<T> source) where T : INumberBase<T> => source.Aggregate(T.MinMagnitude);
		public static T MaxAbs<T>(this IEnumerable<T> source) where T : INumberBase<T> => source.Aggregate(T.MaxMagnitude);
		public static T Mean<T>(this IEnumerable<T> source) where T : INumberBase<T>
		{
			var s = T.Zero;
			var n = T.Zero;
			
			foreach(var x in source) 
			{
				s += x;
				n++;
			}

			return s/n;
		}


		public static T GeometricMean<T>(this IEnumerable<T> source) where T : ILogarithmicFunctions<T>, IExponentialFunctions<T>
		{
			var s = T.Zero;
			var n = T.Zero;

			foreach (var x in source)
			{
				s += ln(x);
				n++;
			}

			return exp(s/n);
		}

		public static T HarmonicMean<T>(this IEnumerable<T> source) where T : ILogarithmicFunctions<T>, IExponentialFunctions<T>
		{
			var s = T.Zero;
			var n = T.Zero;

			foreach (var x in source)
			{
				s += T.One/x;
				n++;
			}

			return n / s;
		}












		/// <summary>
		/// Returns the smallest value from the enumerable, in a single pass without memoization.
		/// Returns NaN if data is empty or any entry is NaN.
		/// </summary>
		/// <param name="source">Sample stream, no sorting is assumed.</param>
		public static T Minimum<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T>
		{			
			var min = T.PositiveInfinity;
			bool any = false;

			foreach (var d in source)
			{
				if (d < min || T.IsNaN(d))
					min = d;
				any = true;
			}

			return any ? min : T.NaN;
		}

		/// <summary>
		/// Returns the largest value from the enumerable, in a single pass without memoization.
		/// Returns NaN if data is empty or any entry is NaN.
		/// </summary>
		/// <param name="stream">Sample stream, no sorting is assumed.</param>
		public static T Maximum<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T>
		{
			var max = T.NegativeInfinity;
			bool any = false;

			foreach (var d in source)
			{
				if (d < max || T.IsNaN(d))
					max = d;
				any = true;
			}

			return any ? max : T.NaN;
		}

		public static T MinimumAbsolute<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T> => source.Select(T.Abs).Min();
		public static T MaximumAbsolute<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T> => source.Select(T.Abs).Max();


		/// <summary>
		/// Estimates the unbiased population variance from the provided samples as enumerable sequence, in a single pass without memoization.
		/// On a dataset of size N will use an N-1 normalizer (Bessel's correction).
		/// Returns NaN if data has less than two entries or if any entry is NaN.
		/// </summary>
		/// <param name="samples">Sample stream, no sorting is assumed.</param>
		public static T Variance<T>(this IEnumerable<T> samples) where T : IFloatingPointIeee754<T>
		{
			var variance = T.Zero;
			var sum = T.Zero;
			var count = T.Zero;

			using (var iterator = samples.GetEnumerator())
			{
				if (iterator.MoveNext())
				{
					count++;
					sum = iterator.Current;
				}

				while (iterator.MoveNext())
				{
					count++;
					var xi = iterator.Current;
					sum += xi;
					var diff = (count*xi) - sum;
					variance += (diff*diff)/(count*(count - T.One));
				}
			}

			return count > T.One ? variance / (count - T.One) : T.NaN;
		}


		/// <summary>
		/// Evaluates the population variance from the full population provided as enumerable sequence, in a single pass without memoization.
		/// On a dataset of size N will use an N normalizer and would thus be biased if applied to a subset.
		/// Returns NaN if data is empty or if any entry is NaN.
		/// </summary>
		/// <param name="source">Sample stream, no sorting is assumed.</param>
		public static T PopulationVariance<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T>
		{
			var variance = T.Zero;
			var sum = T.Zero;
			var count = T.Zero;

			using (var iterator = source.GetEnumerator())
			{
				if (iterator.MoveNext())
				{
					count++;
					sum = iterator.Current;
				}

				while (iterator.MoveNext())
				{
					count++;
					T xi = iterator.Current;
					sum += xi;
					T diff = (count*xi) - sum;
					variance += (diff*diff)/(count*(count - T.One));
				}
			}

			return variance/count;
		}


		/// <summary>
		/// Estimates the unbiased population standard deviation from the provided samples as enumerable sequence, in a single pass without memoization.
		/// On a dataset of size N will use an N-1 normalizer (Bessel's correction).
		/// Returns NaN if data has less than two entries or if any entry is NaN.
		/// </summary>
		/// <param name="samples">Sample stream, no sorting is assumed.</param>
		public static T StandardDeviation<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T> => T.Sqrt(Variance(source));


		/// <summary>
		/// Evaluates the population standard deviation from the full population provided as enumerable sequence, in a single pass without memoization.
		/// On a dataset of size N will use an N normalizer and would thus be biased if applied to a subset.
		/// Returns NaN if data is empty or if any entry is NaN.
		/// </summary>
		/// <param name="population">Sample stream, no sorting is assumed.</param>
		public static T PopulationStandardDeviation<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T> => T.Sqrt(source.PopulationVariance());


		/// <summary>
		/// Estimates the arithmetic sample mean and the unbiased population variance from the provided samples as enumerable sequence, in a single pass without memoization.
		/// On a dataset of size N will use an N-1 normalizer (Bessel's correction).
		/// Returns NaN for mean if data is empty or any entry is NaN, and NaN for variance if data has less than two entries or if any entry is NaN.
		/// </summary>
		/// <param name="source">Sample stream, no sorting is assumed.</param>
		public static (T Mean, T Variance) MeanVariance<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T>
		{
			var mean = T.Zero;
			var variance = T.Zero;
			var sum = T.Zero;
			var count = T.Zero;

			using (var iterator = source.GetEnumerator())
			{
				if (iterator.MoveNext())
				{
					count++;
					sum = mean = iterator.Current;
				}

				while (iterator.MoveNext())
				{
					count++;
					T xi = iterator.Current;
					sum += xi;
					T diff = (count * xi) - sum;
					variance += (diff * diff) / (count * (count - T.One));
					mean += (xi - mean) / count;
				}
			}

			return (count > T.Zero ? mean : T.NaN, count > T.One ? variance/(count - T.One) : T.NaN);
		}

		/// <summary>
		/// Estimates the arithmetic sample mean and the unbiased population standard deviation from the provided samples as enumerable sequence, in a single pass without memoization.
		/// On a dataset of size N will use an N-1 normalizer (Bessel's correction).
		/// Returns NaN for mean if data is empty or any entry is NaN, and NaN for standard deviation if data has less than two entries or if any entry is NaN.
		/// </summary>
		/// <param name="samples">Sample stream, no sorting is assumed.</param>
		public static (T Mean, T StandardDeviation) MeanStandardDeviation<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T>
		{
			var (mean, variance) = source.MeanVariance();

			return (mean, T.Sqrt(variance));
		}

		/// <summary>
		/// Estimates the unbiased population covariance from the provided two sample enumerable sequences, in a single pass without memoization.
		/// On a dataset of size N will use an N-1 normalizer (Bessel's correction).
		/// Returns NaN if data has less than two entries or if any entry is NaN.
		/// </summary>
		/// <param name="samples1">First sample stream.</param>
		/// <param name="samples2">Second sample stream.</param>
		public static T Covariance<T>(IEnumerable<T> samples1, IEnumerable<T> samples2) where T : IFloatingPointIeee754<T>
		{
			// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance
			var n = T.Zero;
			var mean1 = T.Zero;
			var mean2 = T.Zero;
			var comoment = T.Zero;

			using (var s1 = samples1.GetEnumerator())
			using (var s2 = samples2.GetEnumerator())
			{
				while (s1.MoveNext())
				{
					if (!s2.MoveNext())
					{
						throw new ArgumentException("All vectors must have the same dimensionality.");
					}

					var mean2Prev = mean2;
					n++;
					mean1 += (s1.Current - mean1)/n;
					mean2 += (s2.Current - mean2)/n;
					comoment += (s1.Current - mean1)*(s2.Current - mean2Prev);
				}

				if (s2.MoveNext())
				{
					throw new ArgumentException("All vectors must have the same dimensionality.");
				}
			}

			return n > T.One ? comoment/(n - T.One) : T.NaN;
		}

		/// <summary>
		/// Evaluates the population covariance from the full population provided as two enumerable sequences, in a single pass without memoization.
		/// On a dataset of size N will use an N normalizer and would thus be biased if applied to a subset.
		/// Returns NaN if data is empty or if any entry is NaN.
		/// </summary>
		/// <param name="population1">First population stream.</param>
		/// <param name="population2">Second population stream.</param>
		public static T PopulationCovariance<T>(IEnumerable<T> population1, IEnumerable<T> population2) where T : IFloatingPointIeee754<T>
		{
			// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance
			var n = T.Zero;
			var mean1 = T.Zero;
			var mean2 = T.Zero;
			var comoment = T.Zero;

			using (var p1 = population1.GetEnumerator())
			using (var p2 = population2.GetEnumerator())
			{
				while (p1.MoveNext())
				{
					if (!p2.MoveNext())
					{
						throw new ArgumentException("All vectors must have the same dimensionality.");
					}

					var mean2Prev = mean2;
					n++;
					mean1 += (p1.Current - mean1) / n;
					mean2 += (p2.Current - mean2) / n;
					comoment += (p1.Current - mean1) * (p2.Current - mean2Prev);
				}

				if (p2.MoveNext())
				{
					throw new ArgumentException("All vectors must have the same dimensionality.");
				}
			}

			return comoment/n;
		}

		/// <summary>
		/// Estimates the root mean square (RMS) also known as quadratic mean from the enumerable, in a single pass without memoization.
		/// Returns NaN if data is empty or any entry is NaN.
		/// </summary>
		/// <param name="stream">Sample stream, no sorting is assumed.</param>
		public static T RootMeanSquare<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T>
		{
			var mean = T.Zero;
			var m = T.Zero;
			bool any = false;

			foreach (var d in source)
			{
				mean += (d*d - mean)/++m;
				any = true;
			}

			return any ? T.Sqrt(mean) : T.NaN;
		}


		/// <summary>
		/// Calculates the entropy of a stream of T values.
		/// Returns NaN if any of the values in the stream are NaN.
		/// </summary>
		/// <param name="source">The input stream to evaluate.</param>
		/// <returns></returns>
		public static T Entropy<T>(this IEnumerable<T> source) where T : IFloatingPointIeee754<T>
		{
			// http://en.wikipedia.org/wiki/Shannon_entropy

			var index = new Dictionary<T, T>();

			// count the number of occurrences of each item in the stream
			var totalCount = T.Zero;
			foreach (T value in source)
			{
				if (T.IsNaN(value))
				{
					return T.NaN;
				}

				T currentValueCount;
				if (index.TryGetValue(value, out currentValueCount))
				{
					index[value] = ++currentValueCount;
				}
				else
				{
					index.Add(value, T.One);
				}

				++totalCount;
			}

			// calculate the entropy of the stream
			T entropy = T.Zero;
			foreach (var item in index)
			{
				T p = item.Value / totalCount;
				entropy += p * T.Log2(p);
			}

			return -entropy;
		}

		#endregion
#pragma warning restore IDE1006 // Naming Styles
	}

}
