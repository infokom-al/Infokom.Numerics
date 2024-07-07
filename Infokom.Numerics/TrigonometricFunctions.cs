using System.Numerics;

namespace Infokom.Numerics
{
	public static class TrigonometricFunctions
	{
#pragma warning disable IDE1006 // Naming Styles

		#region scalars
		public static T deg2rad<T>(T degrees) where T : ITrigonometricFunctions<T> => T.DegreesToRadians(degrees);
		public static T rad2deg<T>(T radians) where T : ITrigonometricFunctions<T> => T.RadiansToDegrees(radians);
		public static T sin<T>(T x) where T : ITrigonometricFunctions<T> => T.Sin(x);
		public static T cos<T>(T x) where T : ITrigonometricFunctions<T> => T.Cos(x);
		public static T tan<T>(T x) where T : ITrigonometricFunctions<T> => T.Tan(x);
		public static T cot<T>(T x) where T : ITrigonometricFunctions<T> => T.One / T.Tan(x);
		public static T sec<T>(T x) where T : ITrigonometricFunctions<T> => T.One / T.Cos(x);
		public static T csc<T>(T x) where T : ITrigonometricFunctions<T> => T.One / T.Sin(x);
		public static T asin<T>(T x) where T : ITrigonometricFunctions<T> => T.Asin(x);
		public static T acos<T>(T x) where T : ITrigonometricFunctions<T> => T.Acos(x);
		public static T atan<T>(T x) where T : ITrigonometricFunctions<T> => T.Atan(x);
		public static T asec<T>(T x) where T : ITrigonometricFunctions<T> => T.Acos(T.One / x);
		public static T acsc<T>(T x) where T : ITrigonometricFunctions<T> => T.Asin(T.One / x);
		public static T acot<T>(T x) where T : ITrigonometricFunctions<T> => T.Atan(T.One / x);
		public static T sinπ<T>(T x) where T : ITrigonometricFunctions<T> => T.SinPi(x);
		public static T cosπ<T>(T x) where T : ITrigonometricFunctions<T> => T.CosPi(x);
		public static T tanπ<T>(T x) where T : ITrigonometricFunctions<T> => T.TanPi(x);
		public static T cotπ<T>(T x) where T : ITrigonometricFunctions<T> => T.One / T.TanPi(x);
		public static T secπ<T>(T x) where T : ITrigonometricFunctions<T> => T.One / T.CosPi(x);
		public static T cscπ<T>(T x) where T : ITrigonometricFunctions<T> => T.One / T.SinPi(x);
		public static T asinπ<T>(T x) where T : ITrigonometricFunctions<T> => T.AsinPi(x);
		public static T acosπ<T>(T x) where T : ITrigonometricFunctions<T> => T.AcosPi(x);
		public static T atanπ<T>(T x) where T : ITrigonometricFunctions<T> => T.AtanPi(x);
		public static T asecπ<T>(T x) where T : ITrigonometricFunctions<T> => T.AcosPi(T.One / x);
		public static T acscπ<T>(T x) where T : ITrigonometricFunctions<T> => T.AsinPi(T.One / x);
		public static T acotπ<T>(T x) where T : ITrigonometricFunctions<T> => T.AtanPi(T.One / x);
		public static T atan2<T>(T y, T x) where T : IFloatingPointIeee754<T> => T.Atan2(y, x);
		public static T atan2π<T>(T y, T x) where T : IFloatingPointIeee754<T> => T.Atan2Pi(y, x);
		#endregion

		#region 2-tuples
		public static (Tx X, Ty Y) deg2rad<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (deg2rad(source.X), deg2rad(source.Y));
		public static (Tx X, Ty Y) rad2deg<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (rad2deg(source.X), rad2deg(source.Y));
		public static (Tx X, Ty Y) sin<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (sin(source.X), sin(source.Y));
		public static (Tx X, Ty Y) cos<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (cos(source.X), cos(source.Y));
		public static (Tx X, Ty Y) tan<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (tan(source.X), tan(source.Y));
		public static (Tx X, Ty Y) cot<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (cot(source.X), cot(source.Y));
		public static (Tx X, Ty Y) sec<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (sec(source.X), sec(source.Y));
		public static (Tx X, Ty Y) csc<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (csc(source.X), csc(source.Y));
		public static (Tx X, Ty Y) asin<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (asin(source.X), asin(source.Y));
		public static (Tx X, Ty Y) acos<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (acos(source.X), acos(source.Y));
		public static (Tx X, Ty Y) atan<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (atan(source.X), atan(source.Y));
		public static (Tx X, Ty Y) asec<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (asec(source.X), asec(source.Y));
		public static (Tx X, Ty Y) acsc<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (acsc(source.X), acsc(source.Y));
		public static (Tx X, Ty Y) acot<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (acot(source.X), acot(source.Y));
		public static (Tx X, Ty Y) sinπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (sinπ(source.X), sinπ(source.Y));
		public static (Tx X, Ty Y) cosπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (cosπ(source.X), cosπ(source.Y));
		public static (Tx X, Ty Y) tanπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (tanπ(source.X), tanπ(source.Y));
		public static (Tx X, Ty Y) cotπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (cotπ(source.X), cotπ(source.Y));
		public static (Tx X, Ty Y) secπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (secπ(source.X), secπ(source.Y));
		public static (Tx X, Ty Y) cscπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (cscπ(source.X), cscπ(source.Y));
		public static (Tx X, Ty Y) asinπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (asinπ(source.X), asinπ(source.Y));
		public static (Tx X, Ty Y) acosπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (acosπ(source.X), acosπ(source.Y));
		public static (Tx X, Ty Y) atanπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (atanπ(source.X), atanπ(source.Y));
		public static (Tx X, Ty Y) asecπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (asecπ(source.X), asecπ(source.Y));
		public static (Tx X, Ty Y) acscπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (acscπ(source.X), acscπ(source.Y));
		public static (Tx X, Ty Y) acotπ<Tx, Ty>((Tx X, Ty Y) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> => (acotπ(source.X), acotπ(source.Y));
		#endregion

		#region 3-tuples
		public static (Tx X, Ty Y, Tz Z) deg2rad<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (deg2rad(source.X), deg2rad(source.Y), deg2rad(source.Z));
		public static (Tx X, Ty Y, Tz Z) rad2deg<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (rad2deg(source.X), rad2deg(source.Y), rad2deg(source.Z));
		public static (Tx X, Ty Y, Tz Z) sin<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (sin(source.X), sin(source.Y), sin(source.Z));
		public static (Tx X, Ty Y, Tz Z) cos<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (cos(source.X), cos(source.Y), cos(source.Z));
		public static (Tx X, Ty Y, Tz Z) tan<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (tan(source.X), tan(source.Y), tan(source.Z));
		public static (Tx X, Ty Y, Tz Z) cot<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (cot(source.X), cot(source.Y), cot(source.Z));
		public static (Tx X, Ty Y, Tz Z) sec<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (sec(source.X), sec(source.Y), sec(source.Z));
		public static (Tx X, Ty Y, Tz Z) csc<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (csc(source.X), csc(source.Y), csc(source.Z));
		public static (Tx X, Ty Y, Tz Z) asin<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (asin(source.X), asin(source.Y), asin(source.Z));
		public static (Tx X, Ty Y, Tz Z) acos<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (acos(source.X), acos(source.Y), acos(source.Z));
		public static (Tx X, Ty Y, Tz Z) atan<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (atan(source.X), atan(source.Y), atan(source.Z));
		public static (Tx X, Ty Y, Tz Z) asec<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (asec(source.X), asec(source.Y), asec(source.Z));
		public static (Tx X, Ty Y, Tz Z) acsc<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (acsc(source.X), acsc(source.Y), acsc(source.Z));
		public static (Tx X, Ty Y, Tz Z) acot<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (acot(source.X), acot(source.Y), acot(source.Z));
		public static (Tx X, Ty Y, Tz Z) sinπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (sinπ(source.X), sinπ(source.Y), sinπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) cosπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (cosπ(source.X), cosπ(source.Y), cosπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) tanπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (tanπ(source.X), tanπ(source.Y), tanπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) cotπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (cotπ(source.X), cotπ(source.Y), cotπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) secπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (secπ(source.X), secπ(source.Y), secπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) cscπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (cscπ(source.X), cscπ(source.Y), cscπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) asinπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (asinπ(source.X), asinπ(source.Y), asinπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) acosπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (acosπ(source.X), acosπ(source.Y), acosπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) atanπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (atanπ(source.X), atanπ(source.Y), atanπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) asecπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (asecπ(source.X), asecπ(source.Y), asecπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) acscπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (acscπ(source.X), acscπ(source.Y), acscπ(source.Z));
		public static (Tx X, Ty Y, Tz Z) acotπ<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : ITrigonometricFunctions<Tx> where Ty : ITrigonometricFunctions<Ty> where Tz : ITrigonometricFunctions<Tz> => (acotπ(source.X), acotπ(source.Y), acotπ(source.Z));
		#endregion

		#region arrays
		public static T[] deg2rad<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, deg2rad);
		public static T[] rad2deg<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, rad2deg);
		public static T[] sin<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, sin);
		public static T[] cos<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, cos);
		public static T[] tan<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, tan);
		public static T[] cot<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, cot);
		public static T[] sec<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, sec);
		public static T[] csc<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, csc);
		public static T[] asin<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, asin);
		public static T[] acos<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, acos);
		public static T[] atan<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, atan);
		public static T[] asec<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, asec);
		public static T[] acsc<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, acsc);
		public static T[] acot<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, acot);
		public static T[] sinπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, sinπ);
		public static T[] cosπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, cosπ);
		public static T[] tanπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, tanπ);
		public static T[] cotπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, cotπ);
		public static T[] secπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, secπ);
		public static T[] cscπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, cscπ);
		public static T[] asinπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, asinπ);
		public static T[] acosπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, acosπ);
		public static T[] atanπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, atanπ);
		public static T[] asecπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, asecπ);
		public static T[] acscπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, acscπ);
		public static T[] acotπ<T>(T[] source) where T : ITrigonometricFunctions<T> => Array.ConvertAll(source, acotπ);
		#endregion

#pragma warning restore IDE1006 // Naming Styles
	}
}
