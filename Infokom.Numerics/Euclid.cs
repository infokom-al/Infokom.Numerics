using System.Numerics;


namespace Infokom.Numerics
{
#pragma warning disable IDE1006 // Naming Styles
	public static class Euclid<T> where T : IFloatingPointIeee754<T>
	{
		public static T sqrt(T x) => T.Sqrt(x);
		public static T add(T a, T b) => a + b;
		public static T sub(T a, T b) => a - b;
		public static T mul(T a, T b) => a * b;
		public static T div(T a, T b) => a / b;


		public static T cross((T X, T Y) u, (T X, T Y) v) => u.X * v.Y - u.Y * v.X;

		public static T dot((T X, T Y) u, (T X, T Y) v) => u.X * v.X + u.Y * v.Y;
		public static T dot((T X, T Y, T Z) u, (T X, T Y, T Z) v) => u.X * v.X + u.Y * v.Y + u.Z * v.Z;
		public static T dot(IEnumerable<T> u, IEnumerable<T> v) => u.Zip(v, mul).Aggregate(add);

		public static T norm((T X, T Y) u) => sqrt(dot(u, u));
		public static T norm((T X, T Y, T Z) u) => sqrt(dot(u, u));


		public static (T X, T Y) lerp((T X, T Y) source, (T X, T Y) target) => (T.Lerp(source.X, target.X.), T.Lerp(source.Y, target.Y));
	}
}
