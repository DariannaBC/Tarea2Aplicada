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
using Tarea2Aplicada.Ejercicios_Del_Capitulo_2;

namespace Tarea2Aplicada
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

        private void Cap4Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            Cap4Ejercicio1 cap41 = new Cap4Ejercicio1();
            cap41.Show();

        }

        private void Cap4Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            Cap4Ejercicio2 cap42 = new Cap4Ejercicio2();
            cap42.Show();

        }

        private void Cap4Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            Cap4Ejercicio5 cap45 = new Cap4Ejercicio5();
            cap45.Show();
              
        }

        private void Cap5Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            Cap5Ejercicio4 cap54 = new Cap5Ejercicio4();
            cap54.Show();
        }

        private void Cap5Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            Cap5Ejercicio5 cap55 = new Cap5Ejercicio5();
            cap55.Show();
        }
    }
}
