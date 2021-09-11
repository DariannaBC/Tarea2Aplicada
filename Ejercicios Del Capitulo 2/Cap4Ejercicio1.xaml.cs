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
    /// Interaction logic for Cap4Ejercicio1.xaml
    /// </summary>
    public partial class Cap4Ejercicio1 : Window
    {
        public Cap4Ejercicio1()
        {
            InitializeComponent();
        }

        private void CalcularTablaButton_Click(object sender, RoutedEventArgs e)
        {
            int tabla;
            ListView resultadoTabla = new ListView();
            tabla = int.Parse(CalcularTablaTextBox.Text);
            
            int j = 1;
            while (j <= 10)
            {
                int calculo;
                calculo = tabla * j;
                 resultadoTabla.Items.Add(calculo);
                j++;
            }

            Resultado.Children.Add(resultadoTabla);



        }
    }
}
