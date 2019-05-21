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

namespace EMS_DesktopClient.Views
{
    /// <summary>
    /// Interaction logic for ViewMainWindow2.xaml
    /// </summary>
    public partial class ViewMainWindow2 : Window
    {
        public ViewMainWindow2()
        {
            InitializeComponent();

            Consumption consumption= new Consumption();
            DataContext = new ConsumptionViewModel(consumption);
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }

    internal class ConsumptionViewModel
    {
        public List<Consumption> Consumptions { get; private set; }

        public ConsumptionViewModel(Consumption consumption)
        {
            Consumptions = new List<Consumption>();
            Consumptions.Add(consumption);
        }
    }

    internal class Consumption
    {
        public string Title { get; private set; }
        public int Percentage { get; private set; }

        public Consumption()
        {
            Title = "Current Consumption";
            Percentage = CalculatePercentage();
        }

        private int CalculatePercentage()
        {
            return 47; //Calculation of percentage for consumption
        }
    }
}
