using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Infokom.Numerics.Extensions
{


	public static class EnumerableExtensions
	{
		private static T Average<T>(this IEnumerable<T> source)  where T : struct, INumber<T>
		{
			
			if (source.TryGetSpan(out ReadOnlySpan<T> span))
			{
				if (span.IsEmpty)
				{
					throw new ArgumentException("Empty");
				}
				Enumerable.Range(0, span.Length).Sum<int>(x => 0);
				return T.CreateChecked(span) / T.CreateChecked(span.Length);
			}

			using (IEnumerator<T> e = source.GetEnumerator())
			{
				if (!e.MoveNext())
				{
					throw new ArgumentException("Empty");
				}

				T sum = T.CreateChecked(e.Current);
				long count = 1;
				while (e.MoveNext())
				{
					checked { sum += T.CreateChecked(e.Current); }
					count++;
				}

				return T.CreateChecked(sum) / T.CreateChecked(count);
			}
		}

		public static T Sum<T>(this IEnumerable<T> source) where T : IAdditionOperators<T, T, T> => source.Aggregate((a, b) => a + b);
		public static T Prod<T>(this IEnumerable<T> source) where T : IMultiplyOperators<T, T, T> => source.Aggregate((a, b) => a * b);







		public static (Tx X, Ty Y) Average<Tx, Ty>(this IEnumerable<(Tx X, Ty Y)> source) where Tx : INumberBase<Tx> where Ty : INumberBase<Ty>
		{
			return (source.Select(p => p.X).Average(), source.Select(p => p.Y).Average());
		}


		public static (Tx X, Ty Y, Tz Z) Centroid<Tx, Ty, Tz>(this IEnumerable<(Tx X, Ty Y, Tz Z)> source) where Tx : INumber<Tx>, ISignedNumber<Tx> where Ty : INumber<Ty>, ISignedNumber<Ty> where Tz : INumber<Tz>, ISignedNumber<Tz>
		{
			return (source.Select(p => p.X).Average(), source.Select(p => p.Y).Average());
		}
	}
}
