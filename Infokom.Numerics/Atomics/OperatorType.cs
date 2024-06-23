using System.ComponentModel;
using System.Globalization;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;

using static System.Net.Mime.MediaTypeNames;
using System.Numerics;


namespace Infokom.Numerics.Atomics
{

	/// <summary>
	/// 
	/// </summary>
	internal enum OperatorType
    {
        /// <summary>
        /// <see cref="IOwnership{TSelf, TOther}.ForAll(TSelf, Predicate{TOther})">
        /// </summary>
        [Description("For all")]
        forall = '∀',



        [Description("Subset of")]
        sub = '⊂',

        [Description("Superset of")]
        sup = '⊃',

        [Description("Not a subset of")]
        nsub = '⊄',

        [Description("Subset of or equal to")]
        sube = '⊆',

        [Description("Superset of or equal to")]
        supe = '⊇',

        /// <summary>
        /// <see cref="IOwnership{TSelf, TOther}.Exists(TSelf, Predicate{TOther})"/>
        /// </summary>
        [Description("There exists")]
        exist = '∃',

        [Description("Empty set = null set = diameter")]
        empty = '∅',

        [Description("Nabla = backward difference")]
        nabla = '∇',

        /// <summary>
        /// <see cref="IMembership{TSelf, TOther}.IsIn(TSelf, TOther)"/>
        /// </summary>
        [Description("Element of")]
        isin = '∈',

        /// <summary>
        /// <see cref="IMembership{TSelf, TOther}.NotIn(TSelf, TOther)"/>
        /// </summary>
        [Description("Not an element of")]
        notin = '∉',

        /// <summary>
        /// <see cref="IOwnership{TSelf, TOther}.Ni(TSelf, TOther)"/>
        /// </summary>
        [Description("CONTAINS AS MEMBER")]
        ni = '∋',

        /// <summary>
        /// <see cref="IOwnership{TSelf, TOther}.NotNi(TSelf, TOther)"/>
        /// </summary>
        [Description("DOES NOT CONTAIN AS MEMBER")]
        notni = '∌',





        [Description("Partial differential")]
        part = '∂',




        [Description("N-array product = product sign")]
        prod = '∏',

        [Description("N-array summation")]
        sum = '∑',

        [Description("Minus sign")]
        minus = '−',

        [Description("Asterisk operator")]
        lowast = '∗',

        [Description("Square root")]
        radic = '√',

        [Description("Proportional to")]
        prop = '∝',

        [Description("Infinity")]
        infin = '∞',

        [Description("Angle")]
        ang = '∠',

        [Description("Logical and = wedge")]
        and = '∧',

        [Description("Logical or = vee")]
        or = '∨',

        /// <summary>
        /// <inheritdoc cref="IIntersectable{TSelf}.OperatorCup(TSelf, TSelf)"/>
        /// </summary>
        [Description("Intersection = cap")]
        cap = '∩',

        /// <summary>
        /// <inheritdoc cref="IUnionable{TSelf}.OperatorCup(TSelf, TSelf)"/>
        /// </summary>
        [Description("Union = cup")]
        cup = '∪',

        [Description("Integral")]
        @int = '∫',

        [Description("Therefore")]
        there4 = '∴',

        [Description("Tilde operator = varies with = similar to")]
        sim = '∼',

        [Description("Approximately equal to")]
        cong = '≅',

        [Description("Almost equal to = asymptotic to")]
        asymp = '≈',

        [Description("Not equal to")]
        ne = '≠',

        [Description("Identical to")]
        equiv = '≡',

        [Description("Less-than or equal to")]
        le = '≤',

        [Description("Greater-than or equal to")]
        ge = '≥',




        [Description("Circled plus = direct sum")]
        oplus = '⊕',

        [Description("Circled times = vector product")]
        otimes = '⊗',

        [Description("Up tack = orthogonal to = perpendicular")]
        perp = '⊥',

        [Description("Dot operator")]
        sdot = '⋅',

       
	}

     public enum ArithmeticOperator
     {
		plus = '+',

		minus = '-',

		times = '×',

		divide = '÷',

          sum = '∑',

          prod = '∏',
	}

     public enum LogicalOperator
     {
          not = '¬',
          and = '∧',
          or = '∨',


	}

     public enum ComparisonOperator 
     {
          equals = '=',
          ne = '≠',
          lt = '<',
          gt = '>',
          lte = '≤',
          gte = '≥'
	}
}
