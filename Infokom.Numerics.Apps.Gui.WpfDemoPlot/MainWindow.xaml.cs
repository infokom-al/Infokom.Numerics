using Infokom.Numerics.Atomics;

using ScottPlot.WPF;

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

using static Infokom.Numerics.Atomics.Euclid<double, double>;

namespace Infokom.Numerics.Apps.Gui.WpfDemoPlot
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			




			var plot = WpfPlot.Plot;
			
			plot.Axes.SetLimits(-5, +5, -5, +5);
			plot.Add.VerticalLine(0);
			plot.Add.HorizontalLine(0);


			var u = 3 * ux;
			var v = 2 * uy;


			var curve = Curve.Ellipse(2, 1);
			curve = Curve.Rotate(curve, double.Pi/2);

			var t = ScottPlot.Generate.Consecutive(2001, double.Pi/1000, -double.Pi);
			var xt = t.Select(curve.X).ToArray();
			var yt = t.Select(curve.Y).ToArray();

			var plotXY = plot.Add.Scatter(xt, yt);
			plotXY.Color =  ScottPlot.Color.FromARGB(0xFF0000FF);
			plotXY.LineWidth = 0.1f;




			plot.Add.VerticalLine()

			WpfPlot.Refresh();
		}
	}
}