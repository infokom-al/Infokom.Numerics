using Microsoft.VisualBasic;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infokom.Numerics.Atomics
{
	public static class Symbols
	{
		private const string
			SUP_K = "0i23456789+-=()n",
			SUP_V = "⁰¹ⁱ²³⁴⁵⁶⁷⁸⁹⁺⁻⁼⁽⁾ⁿᵃᵇᶜᵈᵉᶠᵍʰⁱʲᵏˡᵐⁿᵒᵖʳˢᵗᵘᵛʷˣʸᶻ";
		public static IReadOnlyDictionary<char, char> Sup { get; } = Enumerable.Zip(SUP_K, SUP_V).ToImmutableDictionary(x => x.First, x => x.Second);

		private const string
			SUB_K = "023456789+-=()n",
			SUB_V = "₀₁₂₃₄₅₆₇₈₉₊₋₌₍₎ₐₑₒₓₔₕₖₗₘₙₚₛₜₐₑₕᵢⱼₖₗₘₙₒₚᵣₛₜᵤᵥₓ";
		public static IReadOnlyDictionary<char, char> Sub { get; } = Enumerable.Zip(SUB_K, SUB_V).ToImmutableDictionary(x => x.First, x => x.Second);
	}

	/*
	Symbol	Unicode   HTML Number    HTML Name		Name
	Α		U+0391	&#913;		&Alpha;		Greek capital letter Alpha
	α		U+03B1	&#945;		&alpha;		Greek small letter alpha
	Β		U+0392	&#914;		&Beta;		Greek capital letter Beta
	β		U+03B2	&#946;		&beta;		Greek small letter beta
	γ		U+03B3	&#947;		&gamma;		Greek small letter gamma
	Γ		U+0393	&#915;		&Gamma;		Greek capital letter Gamma
	Δ		U+0394	&#916;		&Delta;		Greek capital letter Delta
	δ		U+03B4	&#948;		&delta;		Greek Small Letter Delta
	Ε		U+0395	&#917;		&Epsilon;		Greek capital letter Epsilon
	ε		U+03B5	&#949;		&epsi;		Greek small letter epsilon
	Ζ		U+0396	&#918;		&Zeta;		Greek capital letter Zeta
	ζ		U+03B6	&#950;		&zeta;		Greek small letter zeta
	η		U+03B7	&#951;		&eta;		Greek small letter eta
	Η		U+0397	&#919;		&Eta;		Greek capital letter Eta
	Θ		U+0398	&#920;		&Theta;		Greek capital letter Theta
	θ		U+03B8	&#952;		&theta;		Greek small letter theta
	ι		U+03B9	&#953;		&iota;		Greek small letter iota
	Ι		U+0399	&#921;		&Iota;		Greek capital letter Iota
	Κ		U+039A	&#922;		&Kappa;		Greek capital letter Kappa
	κ		U+03BA	&#954;		&kappa;		Greek small letter kappa
	λ		U+03BB	&#955;		&lambda;		Greek small letter lamda
	Λ		U+039B	&#923;		&Lambda;		Greek capital letter Lamda
	Μ		U+039C	&#924;		&Mu;			Greek capital letter Mu
	μ		U+03BC	&#956;		&mu;			Greek small letter mu
	ν		U+03BD	&#957;		&nu;			Greek small letter nu
	Ν		U+039D	&#925;		&Nu;			Greek capital letter Nu
	Ξ		U+039E	&#926;		&Xi;			Greek capital letter Xi
	ξ		U+03BE	&#958;		&xi;			Greek small letter xi
	ο		U+03BF	&#959;		&omicron;		Greek small letter omicron
	Ο		U+039F	&#927;		&Omicron;		Greek capital letter Omicron
	π		U+03C0	&#960;		&pi;			Greek small letter pi
	Π		U+03A0	&#928;		&Pi;			Greek capital letter Pi
	Ρ		U+03A1	&#929;		&Rho;		Greek capital letter Rho
	ρ		U+03C1	&#961;		&rho;		Greek small letter rho
	σ		U+03C3	&#963;		&sigma;		Greek small letter sigma
	Σ		U+03A3	&#931;		&Sigma;		Greek capital letter Sigma
	τ		U+03C4	&#964;		&tau;		Greek small letter tau
	Τ		U+03A4	&#932;		&Tau;		Greek capital letter Tau
	υ		U+03C5	&#965;		&upsi;		Greek small letter upsilon
	Υ		U+03A5	&#933;		&Upsilon;		Greek capital letter Upsilon
	φ		U+03C6	&#966;		&phi;		Greek small letter phi
	Φ		U+03A6	&#934;		&Phi;		Greek capital letter Phi
	Χ		U+03A7	&#935;		&Chi;		Greek capital letter Chi
	χ		U+03C7	&#967;		&chi;		Greek small letter chi
	Ψ		U+03A8	&#936;		&Psi;		Greek capital letter Psi
	ψ		U+03C8	&#968;		&psi;		Greek small letter psi
	ω		U+03C9	&#969;		&omega;		Greek small letter omega
	Ω		U+03A9	&#937;		&Omega;		Greek capital letter Omega
	*/
}
