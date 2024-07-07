using System.Numerics;



namespace Infokom.Numerics
{
	public static class LogaritmicFunctions
	{
#pragma warning disable IDE1006 // Naming Styles

		#region scalars
		public static T ln<T>(T a) where T : ILogarithmicFunctions<T> => T.Log(a);
		public static T lb<T>(T a) where T : ILogarithmicFunctions<T> => T.Log2(a);
		public static T lg<T>(T a) where T : ILogarithmicFunctions<T> => T.Log10(a);
		public static T log<T>(T a, T b) where T : ILogarithmicFunctions<T> => T.Log(a, b);
		#endregion

		#region 2-tuples
		public static (Tx X, Ty Y) ln<Tx, Ty>((Tx X, Ty Y) a) where Tx : ILogarithmicFunctions<Tx> where Ty : ILogarithmicFunctions<Ty> => (ln(a.X), ln(a.Y));
		public static (Tx X, Ty Y) lb<Tx, Ty>((Tx X, Ty Y) a) where Tx : ILogarithmicFunctions<Tx> where Ty : ILogarithmicFunctions<Ty> => (lb(a.X), lb(a.Y));
		public static (Tx X, Ty Y) lg<Tx, Ty>((Tx X, Ty Y) a) where Tx : ILogarithmicFunctions<Tx> where Ty : ILogarithmicFunctions<Ty> => (lg(a.X), lg(a.Y));
		public static (T X, T Y) log<T>((T X, T Y) a, T b) where T : ILogarithmicFunctions<T> => (log(a.X, b), log(a.Y, b));
		#endregion

		#region 3-tuples
		public static (Tx X, Ty Y, Tz Z) ln<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : ILogarithmicFunctions<Tx> where Ty : ILogarithmicFunctions<Ty> where Tz : ILogarithmicFunctions<Tz> => (ln(a.X), ln(a.Y), ln(a.Z));
		public static (Tx X, Ty Y, Tz Z) lb<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : ILogarithmicFunctions<Tx> where Ty : ILogarithmicFunctions<Ty> where Tz : ILogarithmicFunctions<Tz> => (ln(a.X), ln(a.Y), ln(a.Z));
		public static (Tx X, Ty Y, Tz Z) lg<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : ILogarithmicFunctions<Tx> where Ty : ILogarithmicFunctions<Ty> where Tz : ILogarithmicFunctions<Tz> => (ln(a.X), ln(a.Y), ln(a.Z));
		public static (T X, T Y, T Z) log<T>((T X, T Y, T Z) a, T b) where T : ILogarithmicFunctions<T> => (log(a.X, b), log(a.Y, b), log(a.Z, b));
		#endregion

		#region arrays
		public static T[] ln<T>(T[] source) where T : ILogarithmicFunctions<T> => Array.ConvertAll(source, ln);
		public static T[] lb<T>(T[] source) where T : ILogarithmicFunctions<T> => Array.ConvertAll(source, lb);
		public static T[] lg<T>(T[] source) where T : ILogarithmicFunctions<T> => Array.ConvertAll(source, lg);
		public static T[] log<T>(T[] source, T b) where T : ILogarithmicFunctions<T> => Array.ConvertAll(source, x => log(x, b));
		#endregion


		#region enumerables
		public static IEnumerable<T> ln<T>(IEnumerable<T> a) where T : ILogarithmicFunctions<T> => a.Select(ln);
		public static IEnumerable<T> lb<T>(IEnumerable<T> a) where T : ILogarithmicFunctions<T> => a.Select(lb);
		public static IEnumerable<T> lg<T>(IEnumerable<T> a) where T : ILogarithmicFunctions<T> => a.Select(lg);
		public static IEnumerable<T> log<T>(IEnumerable<T> a, T b) where T : ILogarithmicFunctions<T> => a.Select(ai => log(ai, b));
		public static IEnumerable<T> log<T>(IEnumerable<T> a, IEnumerable<T> b) where T : ILogarithmicFunctions<T> => Enumerable.Zip(a, b, log);
		#endregion
#pragma warning restore IDE1006 // Naming Styles
	}
}
