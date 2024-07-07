using System.Numerics;

namespace Infokom.Numerics
{
	public static class HyperbolicFunctions
	{
#pragma warning disable IDE1006 // Naming Styles
		#region scalars
		public static T sinh<T>(T x) where T : IHyperbolicFunctions<T> => T.Sinh(x);
		public static T cosh<T>(T x) where T : IHyperbolicFunctions<T> => T.Cosh(x);

		public static T tanh<T>(T x) where T : IHyperbolicFunctions<T> => T.Tanh(x);
		public static T coth<T>(T x) where T : IHyperbolicFunctions<T> => T.One / T.Tanh(x);

		public static T sech<T>(T x) where T : IHyperbolicFunctions<T> => T.One / T.Cosh(x);
		public static T csch<T>(T x) where T : IHyperbolicFunctions<T> => T.One / T.Sinh(x);

		public static T asinh<T>(T x) where T : IHyperbolicFunctions<T> => T.Asinh(x);
		public static T acosh<T>(T x) where T : IHyperbolicFunctions<T> => T.Cosh(x);

		public static T atanh<T>(T x) where T : IHyperbolicFunctions<T> => T.Atanh(x);
		public static T acoth<T>(T x) where T : IHyperbolicFunctions<T> => T.Atanh(T.One / x);

		public static T asech<T>(T x) where T : IHyperbolicFunctions<T> => T.Acosh(T.One / x);
		public static T acsch<T>(T x) where T : IHyperbolicFunctions<T> => T.Asinh(T.One / x);
		#endregion

		#region 2-tuples
		public static (Tx X, Ty Y) sinh<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (sinh(source.X), sinh(source.Y));
		public static (Tx X, Ty Y) cosh<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (cosh(source.X), cosh(source.Y));
		
		public static (Tx X, Ty Y) tanh<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (tanh(source.X), tanh(source.Y));
		public static (Tx X, Ty Y) coth<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (coth(source.X), coth(source.Y));
		
		public static (Tx X, Ty Y) sech<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (sech(source.X), sech(source.Y));
		public static (Tx X, Ty Y) csch<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (csch(source.X), csch(source.Y));
		
		public static (Tx X, Ty Y) asinh<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (asinh(source.X), asinh(source.Y));
		public static (Tx X, Ty Y) acosh<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (acosh(source.X), acosh(source.Y));
		
		public static (Tx X, Ty Y) atanh<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (atanh(source.X), atanh(source.Y));
		public static (Tx X, Ty Y) asech<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (asech(source.X), asech(source.Y));
		
		public static (Tx X, Ty Y) acsch<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (acsch(source.X), acsch(source.Y));
		public static (Tx X, Ty Y) acoth<Tx, Ty>((Tx X, Ty Y) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> => (acoth(source.X), acoth(source.Y));
		#endregion

		#region 3-tuples
		public static (Tx X, Ty Y, Tz Z) sinh<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (sinh(source.X), sinh(source.Y), sinh(source.Z));
		public static (Tx X, Ty Y, Tz Z) cosh<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (cosh(source.X), cosh(source.Y), cosh(source.Z));
		
		public static (Tx X, Ty Y, Tz Z) tanh<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (tanh(source.X), tanh(source.Y), tanh(source.Z));
		public static (Tx X, Ty Y, Tz Z) coth<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (coth(source.X), coth(source.Y), coth(source.Z));
		
		public static (Tx X, Ty Y, Tz Z) sech<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (sech(source.X), sech(source.Y), sech(source.Z));
		public static (Tx X, Ty Y, Tz Z) csch<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (csch(source.X), csch(source.Y), csch(source.Z));
		
		public static (Tx X, Ty Y, Tz Z) asinh<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (asinh(source.X), asinh(source.Y), asinh(source.Z));
		public static (Tx X, Ty Y, Tz Z) acosh<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (acosh(source.X), acosh(source.Y), acosh(source.Z));
		
		public static (Tx X, Ty Y, Tz Z) atanh<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (atanh(source.X), atanh(source.Y), atanh(source.Z));
		public static (Tx X, Ty Y, Tz Z) asech<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (asech(source.X), asech(source.Y), asech(source.Z));
		
		public static (Tx X, Ty Y, Tz Z) acsch<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (acsch(source.X), acsch(source.Y), acsch(source.Z));
		public static (Tx X, Ty Y, Tz Z) acoth<Tx, Ty, Tz>((Tx X, Ty Y, Tz Z) source) where Tx : IHyperbolicFunctions<Tx> where Ty : IHyperbolicFunctions<Ty> where Tz : IHyperbolicFunctions<Tz> => (acoth(source.X), acoth(source.Y), acoth(source.Z));
		#endregion

		#region arrays
		public static T[] sinh<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, sinh);
		public static T[] cosh<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, cosh);
		
		public static T[] tanh<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, tanh);
		public static T[] coth<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, coth);
		
		public static T[] sech<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, sech);
		public static T[] csch<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, csch);
		
		public static T[] asinh<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, asinh);
		public static T[] acosh<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, acosh);
		
		public static T[] atanh<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, atanh);
		public static T[] asech<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, asech);
		
		public static T[] acsch<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, acsch);
		public static T[] acoth<T>(T[] source) where T : IHyperbolicFunctions<T> => Array.ConvertAll(source, acoth);
		#endregion
#pragma warning restore IDE1006 // Naming Styles
	}
}
