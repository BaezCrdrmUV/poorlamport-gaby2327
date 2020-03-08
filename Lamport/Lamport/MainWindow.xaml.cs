using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lamport
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		int[] procesoUno;
		int[] procesoDos;
		int[] procesoTres;
		int contadorProcesoUno = 0;
		int contadorProcesoDos = 0;
		int contadorProcesoTres = 0;

		public MainWindow()
		{
			InitializeComponent();


		}

		private void ButtonProceso1Envio2_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ButtonProceso1Envio3_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ButtonProceso2Envio1_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ButtonProceso2Envio3_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ButtonProceso3Envio1_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ButtonProceso3Envio2_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
