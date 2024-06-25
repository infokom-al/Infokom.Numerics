using System.Collections;
using System.Numerics;
using System.Runtime.CompilerServices;

using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Infokom.Numerics
{


#pragma warning disable IDE1006 // Naming Styles
	public static class Math<T> where T : IFloatingPointIeee754<T>
	{
		public static readonly T π = T.Pi;
		public static readonly T e = T.E;
		public static readonly T τ = T.Tau;


		public static readonly Func<T, T> cos = T.Cos;

		public static Func<T, T> sin = T.Sin;
		public static Func<T, T> tan = T.Tan;
		public static Func<T, T> acos = T.Acos;
		public static Func<T, T> asin = T.Asin;
		public static Func<T, T> atan = T.Atan;
		public static Func<T, T, T> atan2 => T.Atan2Pi;

		public static Func<T, T> cosπ = T.CosPi;
		public static Func<T, T> sinπ = T.SinPi;
		public static Func<T, T> tanπ = T.TanPi;
		public static Func<T, T> acosπ = T.AcosPi;
		public static Func<T, T> asinπ = T.AsinPi;
		public static Func<T, T> atanπ = T.AtanPi;
		public static Func<T, T, T> atan2π => T.Atan2Pi;

		public static Func<T, T> cosh = T.Cosh;
		public static Func<T, T> sinh = T.Sinh;
		public static Func<T, T> tanh = T.Tanh;
		public static Func<T, T> acosh = T.Acosh;
		public static Func<T, T> asinh = T.Asinh;
		public static Func<T, T> atanh = T.Atanh;

		public static Func<T, T> sqrt = T.Sqrt;
		public static Func<T, T> cbrt = T.Cbrt;
		public static Func<T, int, T> root = T.RootN;
		public static Func<T, T, T> hypot = T.Hypot;
		public static Func<T, T, T, T> lerp = T.Lerp;
	}
#pragma warning restore IDE1006 // Naming Styles
}
