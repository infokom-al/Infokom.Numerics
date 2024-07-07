using System.Numerics;

namespace Infokom.Numerics
{
	public static class PowerFunctions
	{
#pragma warning disable IDE1006 // Naming Styles
		#region scalars
		/// <returns><paramref name="a"/>²</returns>
		public static T sqpw<T>(T a) where T : IMultiplyOperators<T, T, T> => a*a;

		/// <returns><paramref name="a"/>³</returns>
		public static T cbpw<T>(T a) where T : IMultiplyOperators<T, T, T> => a*a*a;

		/// <returns><paramref name="a"/><paramref name="ᵗ"/></returns>
		public static T power<T>(T a, T b) where T : IPowerFunctions<T> => T.Pow(a, b);
		#endregion

		#region 2-tuples
		/// <returns>(<paramref name="a"/>.X², <paramref name="a"/>.Y²)</returns>
		public static (Tx X, Ty Y) sqpw<Tx, Ty>((Tx X, Ty Y) a) where Tx : IMultiplyOperators<Tx, Tx, Tx> where Ty : IMultiplyOperators<Ty, Ty, Ty> => (sqpw(a.X), sqpw(a.Y));

		/// <returns>(<paramref name="a"/>.X³, <paramref name="a"/>.Y³)</returns>
		public static (Tx X, Ty Y) cbpw<Tx, Ty>((Tx X, Ty Y) a) where Tx : IMultiplyOperators<Tx, Tx, Tx> where Ty : IMultiplyOperators<Ty, Ty, Ty> => (sqpw(a.X), sqpw(a.Y));

		/// <returns>(<paramref name="a"/>.Xᵇ, <paramref name="a"/>.Yᵇ)</returns>
		public static (T X, T Y) power<T>((T X, T Y) a, T b) where T : IPowerFunctions<T> => (power(a.X, b), power(a.Y, b));
		#endregion

		#region 3-tuples
		/// <returns>(<paramref name="a"/>.X², <paramref name="a"/>.Y², <paramref name="a"/>.Z²)</returns>
		public static (Tx X, Ty Y, Tz Z) sqpw<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IMultiplyOperators<Tx, Tx, Tx> where Ty : IMultiplyOperators<Ty, Ty, Ty> where Tz : IMultiplyOperators<Tz, Tz, Tz> => (sqpw(source.X), sqpw(source.Y), sqpw(source.Z));

		/// <returns>(<paramref name="a"/>.X³, <paramref name="a"/>.Y³, <paramref name="a"/>.Z³)</returns>
		public static (Tx X, Ty Y, Tz Z) cbpw<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IMultiplyOperators<Tx, Tx, Tx> where Ty : IMultiplyOperators<Ty, Ty, Ty> where Tz : IMultiplyOperators<Tz, Tz, Tz> => (sqpw(source.X), sqpw(source.Y), sqpw(source.Z));

		/// <returns>(<paramref name="a"/>.X<paramref name="ᵇ"/>, <paramref name="a"/>.Y<paramref name="ᵇ"/>, <paramref name="a"/>.Z<paramref name="ᵇ"/>)</returns>
		public static (T X, T Y, T Z) power<T>((T X, T Y, T Z) a, T b) where T : IPowerFunctions<T> => (power(a.X, b), power(a.Y, b), power(a.Z, b));
		#endregion

		#region arrays
		/// <returns>[... <paramref name="a"/>ₖ² ...]</returns>
		public static T[] sqpw<T>(T[] a) where T : IMultiplyOperators<T, T, T> => Array.ConvertAll(a, sqpw);

		/// <returns>[... <paramref name="a"/>ₖ³ ...]</returns>
		public static T[] cbpw<T>(T[] a) where T : IMultiplyOperators<T, T, T> => Array.ConvertAll(a, cbpw);

		/// <returns>[... <paramref name="a"/>(k)<paramref name="ᵇ"/> ...]</returns>
		public static T[] power<T>(T[] a, T b) where T : IPowerFunctions<T> => Array.ConvertAll(a, x => power(x, b));
		#endregion
#pragma warning restore IDE1006 // Naming Styles
	}
}
