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

namespace College4a
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

        private void BerekenBMI_Click(object sender, RoutedEventArgs e)
        {
            double gewicht = 0;
            double lengte = 0;

            string gewichtTekst = GewichtTB.Text;
            try
            {
                gewicht = double.Parse(gewichtTekst);
            }
            catch (FormatException)
            {
                MessageBox.Show("Je moet een getal invoeren bij het gewicht!");
                GewichtTB.Text = "";
            }

            string lengtetTekst = LengteTB.Text;
            try
            {
                lengte = double.Parse(lengtetTekst);
            }
            catch (FormatException)
            {
                MessageBox.Show("Je moet een getal invoeren bij de lengte!");
                LengteTB.Text = "";
            }

            uitkomst.Content = "Uitkomst: " + gewicht / (lengte * lengte);
        }

        private void MaakSter_Click(object sender, MouseButtonEventArgs e)
        {
            Ellipse cirkel = new Ellipse();
            cirkel.Fill = Brushes.Yellow;
            cirkel.Width = 20;
            cirkel.Height = 20;
            Canvas.SetLeft(cirkel, e.GetPosition(SterrenCanvas).X - 10);
            Canvas.SetTop(cirkel, e.GetPosition(SterrenCanvas).Y - 10);
            SterrenCanvas.Children.Add(cirkel);
        }
    }
}