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
    /// Interaction logic for Cap4Ejercicio5.xaml
    /// </summary>
    public partial class Cap4Ejercicio5 : Window
    {
        static int edades;
        static int personas;
        static int mayores = 0;
        static int menores = 0;
        static int total = 0;
        static int cantidad = 0;

        public Cap4Ejercicio5()
        {
            InitializeComponent();
        }



     

        private void EvaluarPButton_Click(object sender, RoutedEventArgs e)
        {
            personas = int.Parse(EvaluarpTextBox.Text);

        }

        private void EvaluarEButton_Click(object sender, RoutedEventArgs e)
        {
            edades = int.Parse(EdadeTextBox.Text);
            EdadeTextBox.Clear();

            for (int j = 0; j < personas; j++)
            {
                total += edades;
                cantidad++;
            }



                if (edades > mayores)
                {
                    mayores = edades;
                }
                if (edades < menores)
                {
                    menores = edades;
                }


        }

        private void EvaluarButton_Click(object sender, RoutedEventArgs e)
        {
            int promedio;



            promedio = Convert.ToInt32(total / cantidad);
            PromedioTextBox.Text = promedio.ToString();

            MayorTextBox.Text = mayores.ToString();
            MenorTextBox.Text = menores.ToString();

        }
    }
}