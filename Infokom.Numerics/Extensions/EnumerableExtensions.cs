using System.Numerics;

namespace Infokom.Numerics.Extensions
{
	public static class EnumerableExtensions
	{
		public static T Average<T>(this IEnumerable<T> source) where T : INumber<T>
		{
			var (s, n) = (T.Zero, T.Zero);

			foreach (var x in source)
			{
				s += x; n++;
			}

			return s / n;
		}

		public static T Sum<T>(this IEnumerable<T> source) where T : IAdditionOperators<T, T, T> => source.Aggregate((a, b) => a + b);
	}
}
