using System.Numerics;

namespace Infokom.Numerics
{
	public interface IMatrix<T> : IReadOnlyCollection<T>
	{
		T this[int i, int j] { get; }
	}

	public interface IScalarMatrix<T> : IMatrix<T> where T : INumber<T>
	{
	}
}
