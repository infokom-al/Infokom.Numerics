using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Numerics.Extensions
{

	internal static class TupleExtensions
	{

		public static T Norm<T>(this (T X, T Y) source) where T : IFloatingPointIeee754<T>
		{
			var (x, y) = source;

			return T.Sqrt(x * x + y * y);
		}

		public static T Norm<T>(this (T X, T Y, T Z) source) where T : IFloatingPointIeee754<T>
		{
			var (x, y, z) = source;

			return T.Sqrt(x * x + y * y + z * z);
		}

		public static double Norm<Tx, Ty, Tz>(this (Tx X, Ty Y, Tz Z) source) 
			where Tx : IMultiplyOperators<Tx, Tx, double>
			where Ty : IMultiplyOperators<Ty, Ty, double>
			where Tz : IMultiplyOperators<Tz, Tz, double>
		{
			var (x, y, z) = source;

			return Math.Sqrt(x * x + y * y + z * z);
		}




		public static (Tx X, Ty Y) To<Tx, Ty>(this (double X, double Y) source)
			where Tx : IConvertible, IBinaryFloatingPointIeee754<Tx>
			where Ty : IConvertible, IBinaryFloatingPointIeee754<Ty> 
			=> (Tx.CreateChecked(source.X), Ty.CreateChecked(source.Y));


		public static (Tx X, Ty Y) To<T, Tx, Ty>(this (T X, T Y) source)
			where T : IBinaryNumber<T>, ISignedNumber<T>
			where Tx : IConvertible, IBinaryFloatingPointIeee754<Tx>
			where Ty : IConvertible, IBinaryFloatingPointIeee754<Ty>
			=> (Tx.CreateChecked(source.X), Ty.CreateChecked(source.Y));

		public static (Tx X, Ty Y) Sqrt<Tx, Ty>(this (Tx X, Ty Y) source) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> => (Tx.Sqrt(source.X), Ty.Sqrt(source.Y));
		public static (Tx X, Ty Y) Cbrt<Tx, Ty>(this (Tx X, Ty Y) source) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> => (Tx.Cbrt(source.X), Ty.Cbrt(source.Y));

		public static (Tx X, Ty Y) Root<Tx, Ty>(this (Tx X, Ty Y) source, int n) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> => (Tx.RootN(source.X, n), Ty.RootN(source.Y, n));

		public static (Tx X, Ty Y) Hypot<Tx, Ty>(this (Tx X, Ty Y) source, (Tx X, Ty Y) target) where Tx : IRootFunctions<Tx> where Ty : IRootFunctions<Ty> => (Tx.Hypot(source.X, target.X), Ty.Hypot(source.Y, target.Y));


		public static ValueTuple<TResult1, TResult2> Add<TSource1, TSource2, TOther1, TOther2, TResult1, TResult2>(this ValueTuple<TSource1, TSource2> source, ValueTuple<TOther1, TOther2> other)
				where TSource1 : IAdditionOperators<TSource1, TOther1, TResult1>
				where TSource2 : IAdditionOperators<TSource2, TOther2, TResult2>
		{
			var (x1, x2) = source;
			var (y1, y2) = other;

			return (x1 + y1, x2 + y2);
		}

		public static ValueTuple<TResult1, TResult2, TResult3> Add<TSource1, TSource2, TSource3, TOther1, TOther2, TOther3, TResult1, TResult2, TResult3>(this ValueTuple<TSource1, TSource2, TSource3> source, ValueTuple<TOther1, TOther2, TOther3> other)
			where TSource1 : IAdditionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IAdditionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IAdditionOperators<TSource3, TOther3, TResult3>
		{
			var (x1, x2, x3) = source;
			var (y1, y2, y3) = other;

			return (x1 + y1, x2 + y2, x3 + y3);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4> Add<TSource1, TSource2, TSource3, TSource4, TOther1, TOther2, TOther3, TOther4, TResult1, TResult2, TResult3, TResult4>(this ValueTuple<TSource1, TSource2, TSource3, TSource4> source, ValueTuple<TOther1, TOther2, TOther3, TOther4> other)
			where TSource1 : IAdditionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IAdditionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IAdditionOperators<TSource3, TOther3, TResult3>
			where TSource4 : IAdditionOperators<TSource4, TOther4, TResult4>
		{
			var (x1, x2, x3, x4) = source;
			var (y1, y2, y3, y4) = other;

			return (x1 + y1, x2 + y2, x3 + y3, x4 + y4);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5> Add<TSource1, TSource2, TSource3, TSource4, TSource5, TOther1, TOther2, TOther3, TOther4, TOther5, TResult1, TResult2, TResult3, TResult4, TResult5>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5> other)
			where TSource1 : IAdditionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IAdditionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IAdditionOperators<TSource3, TOther3, TResult3>
			where TSource4 : IAdditionOperators<TSource4, TOther4, TResult4>
			where TSource5 : IAdditionOperators<TSource5, TOther5, TResult5>
		{
			var (x1, x2, x3, x4, x5) = source;
			var (y1, y2, y3, y4, y5) = other;

			return (x1 + y1, x2 + y2, x3 + y3, x4 + y4, x5 + y5);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> Add<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6> other)
			where TSource1 : IAdditionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IAdditionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IAdditionOperators<TSource3, TOther3, TResult3>
			where TSource4 : IAdditionOperators<TSource4, TOther4, TResult4>
			where TSource5 : IAdditionOperators<TSource5, TOther5, TResult5>
			where TSource6 : IAdditionOperators<TSource6, TOther6, TResult6>
		{
			var (x1, x2, x3, x4, x5, x6) = source;
			var (y1, y2, y3, y4, y5, y6) = other;

			return (x1 + y1, x2 + y2, x3 + y3, x4 + y4, x5 + y5, x6 + y6);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> Add<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7> other)
			where TSource1 : IAdditionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IAdditionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IAdditionOperators<TSource3, TOther3, TResult3>
			where TSource4 : IAdditionOperators<TSource4, TOther4, TResult4>
			where TSource5 : IAdditionOperators<TSource5, TOther5, TResult5>
			where TSource6 : IAdditionOperators<TSource6, TOther6, TResult6>
			where TSource7 : IAdditionOperators<TSource7, TOther7, TResult7>
		{
			var (x1, x2, x3, x4, x5, x6, x7) = source;
			var (y1, y2, y3, y4, y5, y6, y7) = other;

			return (x1 + y1, x2 + y2, x3 + y3, x4 + y4, x5 + y5, x6 + y6, x7 + y7);
		}



		public static ValueTuple<TResult1, TResult2> Sub<TSource1, TSource2, TOther1, TOther2, TResult1, TResult2>(this ValueTuple<TSource1, TSource2> source, ValueTuple<TOther1, TOther2> other)
				where TSource1 : ISubtractionOperators<TSource1, TOther1, TResult1>
				where TSource2 : ISubtractionOperators<TSource2, TOther2, TResult2>
		{
			var (x1, x2) = source;
			var (y1, y2) = other;

			return (x1 - y1, x2 - y2);
		}

		public static ValueTuple<TResult1, TResult2, TResult3> Sub<TSource1, TSource2, TSource3, TOther1, TOther2, TOther3, TResult1, TResult2, TResult3>(this ValueTuple<TSource1, TSource2, TSource3> source, ValueTuple<TOther1, TOther2, TOther3> other)
			where TSource1 : ISubtractionOperators<TSource1, TOther1, TResult1>
			where TSource2 : ISubtractionOperators<TSource2, TOther2, TResult2>
			where TSource3 : ISubtractionOperators<TSource3, TOther3, TResult3>
		{
			var (x1, x2, x3) = source;
			var (y1, y2, y3) = other;

			return (x1 - y1, x2 - y2, x3 - y3);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4> Sub<TSource1, TSource2, TSource3, TSource4, TOther1, TOther2, TOther3, TOther4, TResult1, TResult2, TResult3, TResult4>(this ValueTuple<TSource1, TSource2, TSource3, TSource4> source, ValueTuple<TOther1, TOther2, TOther3, TOther4> other)
			where TSource1 : ISubtractionOperators<TSource1, TOther1, TResult1>
			where TSource2 : ISubtractionOperators<TSource2, TOther2, TResult2>
			where TSource3 : ISubtractionOperators<TSource3, TOther3, TResult3>
			where TSource4 : ISubtractionOperators<TSource4, TOther4, TResult4>
		{
			var (x1, x2, x3, x4) = source;
			var (y1, y2, y3, y4) = other;

			return (x1 - y1, x2 - y2, x3 - y3, x4 - y4);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5> Sub<TSource1, TSource2, TSource3, TSource4, TSource5, TOther1, TOther2, TOther3, TOther4, TOther5, TResult1, TResult2, TResult3, TResult4, TResult5>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5> other)
			where TSource1 : ISubtractionOperators<TSource1, TOther1, TResult1>
			where TSource2 : ISubtractionOperators<TSource2, TOther2, TResult2>
			where TSource3 : ISubtractionOperators<TSource3, TOther3, TResult3>
			where TSource4 : ISubtractionOperators<TSource4, TOther4, TResult4>
			where TSource5 : ISubtractionOperators<TSource5, TOther5, TResult5>
		{
			var (x1, x2, x3, x4, x5) = source;
			var (y1, y2, y3, y4, y5) = other;

			return (x1 - y1, x2 - y2, x3 - y3, x4 - y4, x5 - y5);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> Sub<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6> other)
			where TSource1 : ISubtractionOperators<TSource1, TOther1, TResult1>
			where TSource2 : ISubtractionOperators<TSource2, TOther2, TResult2>
			where TSource3 : ISubtractionOperators<TSource3, TOther3, TResult3>
			where TSource4 : ISubtractionOperators<TSource4, TOther4, TResult4>
			where TSource5 : ISubtractionOperators<TSource5, TOther5, TResult5>
			where TSource6 : ISubtractionOperators<TSource6, TOther6, TResult6>
		{
			var (x1, x2, x3, x4, x5, x6) = source;
			var (y1, y2, y3, y4, y5, y6) = other;

			return (x1 - y1, x2 - y2, x3 - y3, x4 - y4, x5 - y5, x6 - y6);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> Sub<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7> other)
			where TSource1 : ISubtractionOperators<TSource1, TOther1, TResult1>
			where TSource2 : ISubtractionOperators<TSource2, TOther2, TResult2>
			where TSource3 : ISubtractionOperators<TSource3, TOther3, TResult3>
			where TSource4 : ISubtractionOperators<TSource4, TOther4, TResult4>
			where TSource5 : ISubtractionOperators<TSource5, TOther5, TResult5>
			where TSource6 : ISubtractionOperators<TSource6, TOther6, TResult6>
			where TSource7 : ISubtractionOperators<TSource7, TOther7, TResult7>
		{
			var (x1, x2, x3, x4, x5, x6, x7) = source;
			var (y1, y2, y3, y4, y5, y6, y7) = other;

			return (x1 - y1, x2 - y2, x3 - y3, x4 - y4, x5 - y5, x6 - y6, x7 - y7);
		}









		public static ValueTuple<TResult1, TResult2> Mul<TSource1, TSource2, K1, K2, TResult1, TResult2>(this ValueTuple<TSource1, TSource2> source, ValueTuple<K1, K2> other)
				where TSource1 : IMultiplyOperators<TSource1, K1, TResult1>
				where TSource2 : IMultiplyOperators<TSource2, K2, TResult2>
		{
			var (x1, x2) = source;
			var (k1, k2) = other;

			return (x1 * k1, x2 * k2);
		}

		public static ValueTuple<TResult1, TResult2, TResult3> Mul<TSource1, TSource2, TSource3, K1, K2, K3, TResult1, TResult2, TResult3>(this ValueTuple<TSource1, TSource2, TSource3> source, ValueTuple<K1, K2, K3> other)
			where TSource1 : IMultiplyOperators<TSource1, K1, TResult1>
			where TSource2 : IMultiplyOperators<TSource2, K2, TResult2>
			where TSource3 : IMultiplyOperators<TSource3, K3, TResult3>
		{
			var (x1, x2, x3) = source;
			var (k1, k2, k3) = other;

			return (x1 * k1, x2 * k2, x3 * k3);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4> Mul<TSource1, TSource2, TSource3, TSource4, K1, K2, K3, K4, TResult1, TResult2, TResult3, TResult4>(this ValueTuple<TSource1, TSource2, TSource3, TSource4> source, ValueTuple<K1, K2, K3, K4> other)
			where TSource1 : IMultiplyOperators<TSource1, K1, TResult1>
			where TSource2 : IMultiplyOperators<TSource2, K2, TResult2>
			where TSource3 : IMultiplyOperators<TSource3, K3, TResult3>
			where TSource4 : IMultiplyOperators<TSource4, K4, TResult4>
		{
			var (x1, x2, x3, x4) = source;
			var (k1, k2, k3, k4) = other;

			return (x1 * k1, x2 * k2, x3 * k3, x4 * k4);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5> Mul<TSource1, TSource2, TSource3, TSource4, TSource5, K1, K2, K3, K4, K5, TResult1, TResult2, TResult3, TResult4, TResult5>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5> source, ValueTuple<K1, K2, K3, K4, K5> other)
			where TSource1 : IMultiplyOperators<TSource1, K1, TResult1>
			where TSource2 : IMultiplyOperators<TSource2, K2, TResult2>
			where TSource3 : IMultiplyOperators<TSource3, K3, TResult3>
			where TSource4 : IMultiplyOperators<TSource4, K4, TResult4>
			where TSource5 : IMultiplyOperators<TSource5, K5, TResult5>
		{
			var (x1, x2, x3, x4, x5) = source;
			var (k1, k2, k3, k4, k5) = other;

			return (x1 * k1, x2 * k2, x3 * k3, x4 * k4, x5 * k5);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> Mul<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, K1, K2, K3, K4, K5, K6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6> source, ValueTuple<K1, K2, K3, K4, K5, K6> other)
			where TSource1 : IMultiplyOperators<TSource1, K1, TResult1>
			where TSource2 : IMultiplyOperators<TSource2, K2, TResult2>
			where TSource3 : IMultiplyOperators<TSource3, K3, TResult3>
			where TSource4 : IMultiplyOperators<TSource4, K4, TResult4>
			where TSource5 : IMultiplyOperators<TSource5, K5, TResult5>
			where TSource6 : IMultiplyOperators<TSource6, K6, TResult6>
		{
			var (x1, x2, x3, x4, x5, x6) = source;
			var (k1, k2, k3, k4, k5, k6) = other;

			return (x1 * k1, x2 * k2, x3 * k3, x4 * k4, x5 * k5, x6 * k6);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> Mul<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, K1, K2, K3, K4, K5, K6, K7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7> source, ValueTuple<K1, K2, K3, K4, K5, K6, K7> other)
			where TSource1 : IMultiplyOperators<TSource1, K1, TResult1>
			where TSource2 : IMultiplyOperators<TSource2, K2, TResult2>
			where TSource3 : IMultiplyOperators<TSource3, K3, TResult3>
			where TSource4 : IMultiplyOperators<TSource4, K4, TResult4>
			where TSource5 : IMultiplyOperators<TSource5, K5, TResult5>
			where TSource6 : IMultiplyOperators<TSource6, K6, TResult6>
			where TSource7 : IMultiplyOperators<TSource7, K7, TResult7>
		{
			var (x1, x2, x3, x4, x5, x6, x7) = source;
			var (k1, k2, k3, k4, k5, k6, k7) = other;

			return (x1 * k1, x2 * k2, x3 * k3, x4 * k4, x5 * k5, x6 * k6, x7 * k7);
		}












		public static ValueTuple<TResult1, TResult2> Div<TSource1, TSource2, TOther1, TOther2, TResult1, TResult2>(this ValueTuple<TSource1, TSource2> source, ValueTuple<TOther1, TOther2> other)
				where TSource1 : IDivisionOperators<TSource1, TOther1, TResult1>
				where TSource2 : IDivisionOperators<TSource2, TOther2, TResult2>
		{
			var (x1, x2) = source;
			var (k1, k2) = other;

			return (x1 / k1, x2 / k2);
		}

		public static ValueTuple<TResult1, TResult2, TResult3> Div<TSource1, TSource2, TSource3, TOther1, TOther2, TOther3, TResult1, TResult2, TResult3>(this ValueTuple<TSource1, TSource2, TSource3> source, ValueTuple<TOther1, TOther2, TOther3> other)
			where TSource1 : IDivisionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IDivisionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IDivisionOperators<TSource3, TOther3, TResult3>
		{
			var (x1, x2, x3) = source;
			var (k1, k2, k3) = other;

			return (x1 / k1, x2 / k2, x3 / k3);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4> Div<TSource1, TSource2, TSource3, TSource4, TOther1, TOther2, TOther3, TOther4, TResult1, TResult2, TResult3, TResult4>(this ValueTuple<TSource1, TSource2, TSource3, TSource4> source, ValueTuple<TOther1, TOther2, TOther3, TOther4> other)
			where TSource1 : IDivisionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IDivisionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IDivisionOperators<TSource3, TOther3, TResult3>
			where TSource4 : IDivisionOperators<TSource4, TOther4, TResult4>
		{
			var (x1, x2, x3, x4) = source;
			var (k1, k2, k3, k4) = other;

			return (x1 / k1, x2 / k2, x3 / k3, x4 / k4);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5> Div<TSource1, TSource2, TSource3, TSource4, TSource5, TOther1, TOther2, TOther3, TOther4, TOther5, TResult1, TResult2, TResult3, TResult4, TResult5>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5> other)
			where TSource1 : IDivisionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IDivisionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IDivisionOperators<TSource3, TOther3, TResult3>
			where TSource4 : IDivisionOperators<TSource4, TOther4, TResult4>
			where TSource5 : IDivisionOperators<TSource5, TOther5, TResult5>
		{
			var (x1, x2, x3, x4, x5) = source;
			var (k1, k2, k3, k4, k5) = other;

			return (x1 / k1, x2 / k2, x3 / k3, x4 / k4, x5 / k5);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> Div<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6> other)
			where TSource1 : IDivisionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IDivisionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IDivisionOperators<TSource3, TOther3, TResult3>
			where TSource4 : IDivisionOperators<TSource4, TOther4, TResult4>
			where TSource5 : IDivisionOperators<TSource5, TOther5, TResult5>
			where TSource6 : IDivisionOperators<TSource6, TOther6, TResult6>
		{
			var (x1, x2, x3, x4, x5, x6) = source;
			var (k1, k2, k3, k4, k5, k6) = other;

			return (x1 / k1, x2 / k2, x3 / k3, x4 / k4, x5 / k5, x6 / k6);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> Div<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7> other)
			where TSource1 : IDivisionOperators<TSource1, TOther1, TResult1>
			where TSource2 : IDivisionOperators<TSource2, TOther2, TResult2>
			where TSource3 : IDivisionOperators<TSource3, TOther3, TResult3>
			where TSource4 : IDivisionOperators<TSource4, TOther4, TResult4>
			where TSource5 : IDivisionOperators<TSource5, TOther5, TResult5>
			where TSource6 : IDivisionOperators<TSource6, TOther6, TResult6>
			where TSource7 : IDivisionOperators<TSource7, TOther7, TResult7>
		{
			var (x1, x2, x3, x4, x5, x6, x7) = source;
			var (k1, k2, k3, k4, k5, k6, k7) = other;

			return (x1 / k1, x2 / k2, x3 / k3, x4 / k4, x5 / k5, x6 / k6, x7 / k7);
		}










		public static ValueTuple<TResult1, TResult2> Mod<TSource1, TSource2, TOther1, TOther2, TResult1, TResult2>(this ValueTuple<TSource1, TSource2> source, ValueTuple<TOther1, TOther2> other)
				where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
				where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
		{
			var (x1, x2) = source;
			var (k1, k2) = other;

			return (x1 % k1, x2 % k2);
		}

		public static ValueTuple<TResult1, TResult2, TResult3> Mod<TSource1, TSource2, TSource3, TOther1, TOther2, TOther3, TResult1, TResult2, TResult3>(this ValueTuple<TSource1, TSource2, TSource3> source, ValueTuple<TOther1, TOther2, TOther3> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
		{
			var (x1, x2, x3) = source;
			var (k1, k2, k3) = other;

			return (x1 % k1, x2 % k2, x3 % k3);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4> Mod<TSource1, TSource2, TSource3, TSource4, TOther1, TOther2, TOther3, TOther4, TResult1, TResult2, TResult3, TResult4>(this ValueTuple<TSource1, TSource2, TSource3, TSource4> source, ValueTuple<TOther1, TOther2, TOther3, TOther4> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
			where TSource4 : IModulusOperators<TSource4, TOther4, TResult4>
		{
			var (x1, x2, x3, x4) = source;
			var (k1, k2, k3, k4) = other;

			return (x1 % k1, x2 % k2, x3 % k3, x4 % k4);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5> Mod<TSource1, TSource2, TSource3, TSource4, TSource5, TOther1, TOther2, TOther3, TOther4, TOther5, TResult1, TResult2, TResult3, TResult4, TResult5>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
			where TSource4 : IModulusOperators<TSource4, TOther4, TResult4>
			where TSource5 : IModulusOperators<TSource5, TOther5, TResult5>
		{
			var (x1, x2, x3, x4, x5) = source;
			var (k1, k2, k3, k4, k5) = other;

			return (x1 % k1, x2 % k2, x3 % k3, x4 % k4, x5 % k5);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> Mod<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
			where TSource4 : IModulusOperators<TSource4, TOther4, TResult4>
			where TSource5 : IModulusOperators<TSource5, TOther5, TResult5>
			where TSource6 : IModulusOperators<TSource6, TOther6, TResult6>
		{
			var (x1, x2, x3, x4, x5, x6) = source;
			var (k1, k2, k3, k4, k5, k6) = other;

			return (x1 % k1, x2 % k2, x3 % k3, x4 % k4, x5 % k5, x6 % k6);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> Mod<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
			where TSource4 : IModulusOperators<TSource4, TOther4, TResult4>
			where TSource5 : IModulusOperators<TSource5, TOther5, TResult5>
			where TSource6 : IModulusOperators<TSource6, TOther6, TResult6>
			where TSource7 : IModulusOperators<TSource7, TOther7, TResult7>
		{
			var (x1, x2, x3, x4, x5, x6, x7) = source;
			var (k1, k2, k3, k4, k5, k6, k7) = other;

			return (x1 % k1, x2 % k2, x3 % k3, x4 % k4, x5 % k5, x6 % k6, x7 % k7);
		}
	}

	internal static class ModulusOperatorsExtensions
	{
		public static ValueTuple<TResult1, TResult2> Mod<TSource1, TSource2, TOther1, TOther2, TResult1, TResult2>(this ValueTuple<TSource1, TSource2> source, ValueTuple<TOther1, TOther2> other)
				where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
				where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
		{
			var (x1, x2) = source;
			var (k1, k2) = other;

			return (x1 % k1, x2 % k2);
		}

		public static ValueTuple<TResult1, TResult2, TResult3> Mod<TSource1, TSource2, TSource3, TOther1, TOther2, TOther3, TResult1, TResult2, TResult3>(this ValueTuple<TSource1, TSource2, TSource3> source, ValueTuple<TOther1, TOther2, TOther3> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
		{
			var (x1, x2, x3) = source;
			var (k1, k2, k3) = other;

			return (x1 % k1, x2 % k2, x3 % k3);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4> Mod<TSource1, TSource2, TSource3, TSource4, TOther1, TOther2, TOther3, TOther4, TResult1, TResult2, TResult3, TResult4>(this ValueTuple<TSource1, TSource2, TSource3, TSource4> source, ValueTuple<TOther1, TOther2, TOther3, TOther4> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
			where TSource4 : IModulusOperators<TSource4, TOther4, TResult4>
		{
			var (x1, x2, x3, x4) = source;
			var (k1, k2, k3, k4) = other;

			return (x1 % k1, x2 % k2, x3 % k3, x4 % k4);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5> Mod<TSource1, TSource2, TSource3, TSource4, TSource5, TOther1, TOther2, TOther3, TOther4, TOther5, TResult1, TResult2, TResult3, TResult4, TResult5>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
			where TSource4 : IModulusOperators<TSource4, TOther4, TResult4>
			where TSource5 : IModulusOperators<TSource5, TOther5, TResult5>
		{
			var (x1, x2, x3, x4, x5) = source;
			var (k1, k2, k3, k4, k5) = other;

			return (x1 % k1, x2 % k2, x3 % k3, x4 % k4, x5 % k5);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> Mod<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1>
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2>
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
			where TSource4 : IModulusOperators<TSource4, TOther4, TResult4>
			where TSource5 : IModulusOperators<TSource5, TOther5, TResult5>
			where TSource6 : IModulusOperators<TSource6, TOther6, TResult6>
		{
			var (x1, x2, x3, x4, x5, x6) = source;
			var (k1, k2, k3, k4, k5, k6) = other;

			return (x1 % k1, x2 % k2, x3 % k3, x4 % k4, x5 % k5, x6 % k6);
		}

		public static ValueTuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> Mod<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this ValueTuple<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7> source, ValueTuple<TOther1, TOther2, TOther3, TOther4, TOther5, TOther6, TOther7> other)
			where TSource1 : IModulusOperators<TSource1, TOther1, TResult1> 
			where TSource2 : IModulusOperators<TSource2, TOther2, TResult2> 
			where TSource3 : IModulusOperators<TSource3, TOther3, TResult3>
			where TSource4 : IModulusOperators<TSource4, TOther4, TResult4>
			where TSource5 : IModulusOperators<TSource5, TOther5, TResult5>
			where TSource6 : IModulusOperators<TSource6, TOther6, TResult6>
			where TSource7 : IModulusOperators<TSource7, TOther7, TResult7>
		{
			var (x1, x2, x3, x4, x5, x6, x7) = source;
			var (k1, k2, k3, k4, k5, k6, k7) = other;

			return (x1 % k1, x2 % k2, x3 % k3, x4 % k4, x5 % k5, x6 % k6, x7 % k7);
		}
	}
}
