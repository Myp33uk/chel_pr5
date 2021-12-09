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

namespace chel_pr5
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
        Liquid liquid = new Liquid();
        private void Create(object sender, RoutedEventArgs e)
        {
            liquid.SetParams(Name.Text, Convert.ToInt32(OBbem.Text), Convert.ToInt32(Plotnost.Text));
            Name1.Text = liquid.Title;
            OBbem1.Text = liquid.Volume.ToString();
            Plotnost1.Text = liquid.Density.ToString();
        }
        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Челяев Никита Вариант 14\nПрактическая работа №5\nСоздать класс Liquid (жидкость), имеющий поля названия, плотности и объема. Создать необходимые методы и свойства.Создать перегруженные методы SetParams, для установки параметров жидкости.", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void PreviewTextBoxInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int addvalue))
            {
                e.Handled = true;
            }
        }
    }
}
