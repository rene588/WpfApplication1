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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
            double screen = SystemParameters.FullPrimaryScreenHeight;
            double screenw = SystemParameters.FullPrimaryScreenWidth;
            this.Top = (screen - this.Height) / 2;
            this .Top =(screenw - this .Width )/2;
            

            double workh = SystemParameters.WorkArea.Height;
            double workw = SystemParameters.WorkArea.Width;
            this.Top =(workh -this.Height )/2;
            this.Left   =(workw - this.Width)/2;
             */
            /*--nuesta solo la barrita*/
            try
            {
                Rect bounds = Properties.Settings.Default.posicion;
                this.Top = bounds.Top;
                this.Left = bounds.Left;

                if (this.SizeToContent == SizeToContent.Manual)
                {
                    this.Width = bounds.Width;
                    this.Height = bounds.Height;
                }
            }
            catch
            {
                MessageBox.Show("nnnnnnnnnnn.");
            }
             
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.posicion = this .RestoreBounds ;
            Properties.Settings.Default.Save();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ventana2 v2 = new ventana2();
            v2.Owner  = this;
            v2.Show ();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            dialogo dialog = new dialogo();
            dialog.Owner  = this;
            //dialog.showdialog();
            if (dialog.ShowDialog()== true )
            {

           
            }



      
    }
}
