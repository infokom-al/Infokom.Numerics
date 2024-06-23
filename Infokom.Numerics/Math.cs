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

		public static T cos(T x) => T.Cos(x);
		public static T sin(T x) => T.Sin(x);
		public static T tan(T x) => T.Tan(x);
		public static T acos(T x) => T.Acos(x);
		public static T asin(T x) => T.Asin(x);
		public static T atan(T x) => T.Atan(x);
		public static T atan2(T y, T x) => T.Atan2(y, x);

		public static T cosπ(T x) => T.CosPi(x);
		public static T sinπ(T x) => T.SinPi(x);
		public static T tanπ(T x) => T.TanPi(x);
		public static T acosπ(T x) => T.AcosPi(x);
		public static T asinπ(T x) => T.AsinPi(x);
		public static T atanπ(T x) => T.AtanPi(x);
		public static T atan2π(T y, T x) => T.Atan2Pi(y, x);

		public static T cosh(T x) => T.Cosh(x);
		public static T sinh(T x) => T.Sinh(x);
		public static T tanh(T x) => T.Tanh(x);
		public static T acosh(T x) => T.Acosh(x);
		public static T asinh(T x) => T.Asinh(x);
		public static T atanh(T x) => T.Atanh(x);

		public static T sqrt(T x) => T.Sqrt(x);
		public static T cbrt(T x) => T.Cbrt(x);
		public static T root(T x, int n) => T.RootN(x, n);
		public static T hypot(T x, T y) => T.Hypot(x, y);


		public static T norm(T x, T y, T z) => T.Hypot(T.Hypot(x, y), z);







	}

#pragma warning restore IDE1006 // Naming Styles
}
