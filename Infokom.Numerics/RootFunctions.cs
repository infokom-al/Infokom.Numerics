using System.Numerics;

namespace Infokom.Numerics
{
	public static class RootFunctions
	{
#pragma warning disable IDE1006 // Naming Styles
		#region scalars
		public static T sqrt<T>(T x) where T : IRootFunctions<T> => T.Sqrt(x);
		public static T cbrt<T>(T x) where T : IRootFunctions<T> => T.Cbrt(x);
		public static T root<T>(T x, int n) where T : IRootFunctions<T> => T.RootN(x, n);
		public static T hypot<T>(T x, T y) where T : IRootFunctions<T> => T.Hypot(x, y);
		#endregion

		#region 2-tuples
		public static (Tx X, Ty Y) sqrt<Tx, Ty>((Tx X, Ty Y) a) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> => (sqrt(a.X), sqrt(a.Y));
		public static (Tx X, Ty Y) cbrt<Tx, Ty>((Tx X, Ty Y) a) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> => (cbrt(a.X), cbrt(a.Y));
		public static (Tx X, Ty Y) root<Tx, Ty>((Tx X, Ty Y) a, int n) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> => (root(a.X, n), root(a.Y, n));
		#endregion

		#region 3-tuples
		public static (Tx X, Ty Y, Tz Z) sqrt<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> where Tz : IRootFunctions<Tz> => (sqrt(a.X), sqrt(a.Y), sqrt(a.Z));
		public static (Tx X, Ty Y, Tz Z) cbrt<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> where Tz : IRootFunctions<Tz> => (cbrt(a.X), cbrt(a.Y), cbrt(a.Z));
		public static (Tx X, Ty Y, Tz Z) root<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a, int n) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> where Tz : IRootFunctions<Tz> => (root(a.X, n), root(a.Y, n), root(a.Z, n));
		#endregion

		#region arrays
		public static T[] sqrt<T>(T[] a) where T : IRootFunctions<T> => Array.ConvertAll(a, sqrt);
		public static T[] cbrt<T>(T[] a) where T : IRootFunctions<T> => Array.ConvertAll(a, cbrt);
		public static T[] root<T>(T[] a, int n) where T : IRootFunctions<T> => Array.ConvertAll(a, x => root(x, n));
		#endregion
#pragma warning restore IDE1006 // Naming Styles
	}
}
