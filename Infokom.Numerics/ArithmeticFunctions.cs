using System.Numerics;

namespace Infokom.Numerics
{
	public static class ArithmeticFunctions
	{
#pragma warning disable IDE1006 // Naming Styles

		#region scalars
		public static T add<T>(T a, T b) where T : IAdditionOperators<T, T, T> => a + b;
		public static T sub<T>(T a, T b) where T : ISubtractionOperators<T, T, T> => a - b;
		public static T mul<T>(T a, T b) where T : IMultiplyOperators<T, T, T> => a * b;
		public static T div<T>(T a, T b) where T : IDivisionOperators<T, T, T> => a / b;
		#endregion

		#region 2-tuples

		#endregion

		#region 3-tuples

		#endregion

		#region arrays
		public static T[] add<T>(T[] a, T[] b) where T : IAdditionOperators<T, T, T>, IMultiplyOperators<T, T, T> => a.ZipAdd(b).ToArray();
		public static T[] sub<T>(T[] a, T[] b) where T : ISubtractionOperators<T,T,T> => a.ZipSub(b).ToArray();
		public static T[] mul<T>(T[] a, T b) where T : IMultiplyOperators<T, T, T> => Array.ConvertAll(a, ai => mul(ai, b));
		public static T[] div<T>(T[] a, T b) where T : IDivisionOperators<T,T,T> => Array.ConvertAll(a, ai => div(ai, b));
		public static T sum<T>(T[] source) where T : IAdditionOperators<T, T, T> => source.Sum();
		public static T prod<T>(T[] source) where T : IMultiplyOperators<T, T, T> => source.Prod();
		#endregion

		#region enumerables
		public static IEnumerable<T> ZipAdd<T>(this IEnumerable<T> x, IEnumerable<T> y) where T : IAdditionOperators<T, T, T> => x.Zip(y, add);
		public static IEnumerable<T> ZipSub<T>(this IEnumerable<T> x, IEnumerable<T> y) where T : ISubtractionOperators<T, T, T> => x.Zip(y, sub);
		public static T Sum<T>(this IEnumerable<T> source) where T : IAdditionOperators<T, T, T> => source.Aggregate(add);
		public static T Prod<T>(this IEnumerable<T> source) where T : IMultiplyOperators<T, T, T> => source.Aggregate(mul);
		#endregion

#pragma warning restore IDE1006 // Naming Styles
	}
}
