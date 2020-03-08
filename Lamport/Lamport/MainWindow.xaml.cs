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
		public MainWindow()
		{
			InitializeComponent();
		}

		Proceso procesoUno = new Proceso(1, 0);
		Proceso procesoDos = new Proceso(2, 0);
		Proceso procesoTres = new Proceso(3, 0);

		private void ButtonProceso1_Click(object sender, RoutedEventArgs e)
		{
			if (ComboBoxProceso1.SelectedIndex != -1)
			{
				switch (ComboBoxProceso1.SelectedIndex)
				{
					case 0:
						EnviarMensaje(procesoUno, procesoDos);
						break;
					case 1:
						EnviarMensaje(procesoUno, procesoTres);
						break;
				}
			}
			else
			{
				MessageBox.Show("Seleccione un proceso para enviar el mensaje");
			}
		}

		private void ButtonProceso2_Click(object sender, RoutedEventArgs e)
		{
			if (ComboBoxProceso2.SelectedIndex != -1)
			{
				switch (ComboBoxProceso2.SelectedIndex)
				{
					case 0:
						EnviarMensaje(procesoDos, procesoUno);
						break;
					case 1:
						EnviarMensaje(procesoDos, procesoTres);
						break;
				}
			}
			else
			{
				MessageBox.Show("Seleccione un proceso para enviar el mensaje");
			}
		}

		private void ButtonProceso3_Click(object sender, RoutedEventArgs e)
		{
			if (ComboBoxProceso3.SelectedIndex != -1)
			{
				switch (ComboBoxProceso3.SelectedIndex)
				{
					case 0:
						EnviarMensaje(procesoTres, procesoUno);
						break;
					case 1:
						EnviarMensaje(procesoTres, procesoDos);
						break;
				}
			}
			else
			{
				MessageBox.Show("Seleccione un proceso para enviar el mensaje");
			}
		}

		private void EnviarMensaje(Proceso proceso, Proceso procesoDestinatario)
		{
			Mensaje mensaje = new Mensaje();
			string historialEnvios = proceso.EnviarMensaje(procesoDestinatario, mensaje);
			TextBoxHistorial.Text = TextBoxHistorial.Text + Environment.NewLine + historialEnvios;
			TextBoxHistorial.ScrollToEnd();
		}
	}
}
