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

namespace Desafio1
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

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            //Registrar datos
            string nombre = txtnombre.Text;

            string pass = pwdpassword.Password;

            if (nombre == "Jonathan" && pass == "1234")
                MessageBox.Show("Usuario correcto");
            else
                MessageBox.Show("Usuario o password incorrecto");

        }
    }
}
