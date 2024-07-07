using Infokom.Numerics.Extensions;

using System.Numerics;
using System.Runtime.CompilerServices;



namespace Infokom.Numerics
{
	
	public static class ExponentialFunctions
	{
#pragma warning disable IDE1006 // Naming Styles

		#region scalars
		public static T exp<T>(T x) where T : IExponentialFunctions<T> => T.Exp(x);
		public static T exp2<T>(T x) where T : IExponentialFunctions<T> => T.Exp2(x);
		public static T exp10<T>(T x) where T : IExponentialFunctions<T> => T.Exp10(x);
		public static T expm1<T>(T x) where T : IExponentialFunctions<T> => T.ExpM1(x);
		public static T exp2m1<T>(T x) where T : IExponentialFunctions<T> => T.Exp2M1(x);
		public static T exp10m1<T>(T x) where T : IExponentialFunctions<T> => T.Exp10M1(x);
		#endregion

		#region 2-tuples
		public static (Tx X, Ty Y) exp<Tx, Ty>((Tx X, Ty Y) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> => (exp(a.X), exp(a.Y));
		public static (Tx X, Ty Y) exp2<Tx, Ty>((Tx X, Ty Y) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> => (exp2(a.X), exp2(a.Y));
		public static (Tx X, Ty Y) exp10<Tx, Ty>((Tx X, Ty Y) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> => (exp10(a.X), exp10(a.Y));
		public static (Tx X, Ty Y) expm1<Tx, Ty>((Tx X, Ty Y) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> => (expm1(a.X), expm1(a.Y));
		public static (Tx X, Ty Y) exp2m1<Tx, Ty>((Tx X, Ty Y) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> => (exp2m1(a.X), exp2m1(a.Y));
		public static (Tx X, Ty Y) exp10m1<Tx, Ty>((Tx X, Ty Y) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> => (exp10m1(a.X), exp10m1(a.Y));
		#endregion

		#region 3-tuples
		public static (Tx X, Ty Y, Tz Z) exp<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> where Tz : IExponentialFunctions<Tz> => (exp(a.X), exp(a.Y), exp(a.Z));
		public static (Tx X, Ty Y, Tz Z) exp2<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> where Tz : IExponentialFunctions<Tz> => (exp2(a.X), exp2(a.Y), exp2(a.Z));
		public static (Tx X, Ty Y, Tz Z) exp10<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> where Tz : IExponentialFunctions<Tz> => (exp10(a.X), exp10(a.Y), exp10(a.Z));
		public static (Tx X, Ty Y, Tz Z) expm1<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> where Tz : IExponentialFunctions<Tz> => (expm1(a.X), expm1(a.Y), expm1(a.Z));
		public static (Tx X, Ty Y, Tz Z) exp2m1<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> where Tz : IExponentialFunctions<Tz> => (exp2m1(a.X), exp2m1(a.Y), exp2m1(a.Z));
		public static (Tx X, Ty Y, Tz Z) exp10m1<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) a) where Tx : IExponentialFunctions<Tx> where Ty : IExponentialFunctions<Ty> where Tz : IExponentialFunctions<Tz> => (exp10m1(a.X), exp10m1(a.Y), exp10m1(a.Z));
		#endregion

		#region arrays
		public static T[] exp<T>(T[] source) where T : IExponentialFunctions<T> => Array.ConvertAll(source, exp);
		public static T[] exp2<T>(T[] source) where T : IExponentialFunctions<T> => Array.ConvertAll(source, exp2);
		public static T[] exp10<T>(T[] source) where T : IExponentialFunctions<T> => Array.ConvertAll(source, exp10);
		public static T[] expm1<T>(T[] source) where T : IExponentialFunctions<T> => Array.ConvertAll(source, expm1);
		public static T[] exp2m1<T>(T[] source) where T : IExponentialFunctions<T> => Array.ConvertAll(source, exp2m1);
		public static T[] exp10m1<T>(T[] source) where T : IExponentialFunctions<T> => Array.ConvertAll(source, exp10m1);
		#endregion

#pragma warning restore IDE1006 // Naming Styles
	}
}
