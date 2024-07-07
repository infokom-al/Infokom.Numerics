namespace Infokom.Numerics.Extensions
{
	public static class ArrayExtensions
	{
		public static IEnumerable<int> Range(this Array source, int dimension) => Enumerable.Range(source.GetLowerBound(dimension), source.GetLength(dimension));



		#region 1D-Arrays
		public static int Start<T>(this T[] source) => source.GetLowerBound(0);
		public static int Size<T>(this T[] source) => source.GetLength(0);



		public static T[] Create<T>(int n, Func<int, T> f)
		{
			var x = new T[n];

			Parallel.For(0, n, i => x[i] = f(i));

			return x;
		}

		public static TResult[] Map<TSource, TResult>(this TSource[] x, Func<TSource, TResult> f) => x.Select(f).ToArray();

		#endregion


		#region 2D Arrays
		public static (int, int) Start<T>(this T[,] source) => (source.GetLowerBound(0), source.GetLowerBound(1));
		public static (int, int) Size<T>(this T[,] source) => (source.GetLength(0), source.GetLength(1));

		public static TResult[,] Map<TSource, TResult>(this TSource[,] x, Func<TSource, TResult> f)
		{
			var (m, n) = x.Size();
			var result = new TResult[m, n];

			Parallel.For(0, m, i =>
			{
				for (int j = 0; j < n; j++)
					result[i, j] = f(x[i, j]);
			});

			return result;
		}



		public static IEnumerable<(int, int)> Range<T>(this T[,] source) => 
			from i in source.Range(0)
			from j in source.Range(1)
			select (i, j);

		public static IEnumerable<(int, int, int)> Range<T>(this T[,,] source) =>
			from i in source.Range(0)
			from j in source.Range(1)
			from k in source.Range(2)
			select (i, j, k);


		public static IEnumerable<(int, int, T)> Elements<T>(this T[,] source)
		{
			foreach (var (i, j) in source.Range())
				yield return (i, j, source[i, j]);
		}

		#endregion



	}
}
