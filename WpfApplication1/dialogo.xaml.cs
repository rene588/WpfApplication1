using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para dialogo.xaml
    /// </summary>
    public partial class dialogo : Window
    {
        public String respuesta = "";
        public dialogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this .respuesta = "hola";
            //DialogResult = true; 
            this.Close();

        }


        internal bool showdialog()
        {
            throw new NotImplementedException();
        }
    }
}
