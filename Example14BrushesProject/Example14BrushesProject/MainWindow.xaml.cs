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

namespace Example14BrushesProject
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //FormConfig.FrmSolid.Show();
            FormConfig.FrmSolid.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmLinearGradient.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmRadialGradient.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmImage.Show();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmVisual.Show();

           

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmStack.Show();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmWrap.Show();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmCanvas.Show();

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmGrid.Show();

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmDock.Show();

        }
    }
}
