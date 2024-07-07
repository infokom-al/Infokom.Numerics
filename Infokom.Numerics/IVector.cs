using Infokom.Numerics.Extensions;

using System.Collections;
using System.Collections.Immutable;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Infokom.Numerics
{

	public interface IVector<V> : 
		IEqualityOperators<V, V, bool>,
		IUnaryNegationOperators<V, V>,
		IAdditionOperators<V, V, V>,
		ISubtractionOperators<V, V, V>
		where V : IVector<V>
	{
		static abstract TScalar Dot<TScalar>(V a, V b) where TScalar : INumberBase<TScalar>;
		static virtual TNorm Norm<TNorm>(V a) where TNorm : IRootFunctions<TNorm> => TNorm.Sqrt(V.Dot<TNorm>(a, a));
		static virtual TAngle Angle<TAngle>(V a, V b) where TAngle : ITrigonometricFunctions<TAngle> => TAngle.Acos(V.Dot<TAngle>(a, b) / (V.Dot<TAngle>(a, a) * V.Dot<TAngle>(b, b)));
	}


}
