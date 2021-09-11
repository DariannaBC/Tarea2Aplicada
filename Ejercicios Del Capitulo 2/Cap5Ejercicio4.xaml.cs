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
    /// Interaction logic for Cap5Ejercicio4.xaml
    /// </summary>
    public partial class Cap5Ejercicio4 : Window
    {
        public Cap5Ejercicio4()
        {
            InitializeComponent();
        }

        private void CalcularFactButton_Click(object sender, RoutedEventArgs e)
        {
            int numero;
            int factorial = 1;
            numero = int.Parse(CalcularFactTextBox.Text);
            

            int j= 1;
            for (j = 1; j <= numero; j++)
            {
                factorial *= j;
            }
            ResultadoTextBox.Text = factorial.ToString();
        }
    }
}
