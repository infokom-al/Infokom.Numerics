using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
			double[] dataX = { 1, 2, 3, 4, 5 };
			double[] dataY = { 1, 4, 9, 16, 25 };
			WpfPlot.Plot.Add.Scatter(dataX, dataY);
			WpfPlot.Refresh();
		}
	}
}