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
using System.Windows.Shapes;

namespace Tarea2Aplicada.Ejercicios_Del_Capitulo_2
{
    /// <summary>
    /// Interaction logic for Cap5Ejercicio5.xaml
    /// </summary>
    public partial class Cap5Ejercicio5 : Window
    {
        ConversionLetras c = new ConversionLetras();
        public Cap5Ejercicio5()
        {
            InitializeComponent();
        }

        private void ConversionButton_Click(object sender, RoutedEventArgs e)
        {

            ResultadoTextBox.Text = c.enletras(ConversionTextBox.Text);

        }
    }
}
