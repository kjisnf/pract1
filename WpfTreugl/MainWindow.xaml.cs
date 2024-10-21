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

namespace WpfTreugl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ex(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(StoronaA.Text, out int la) && int.TryParse(StoronaB.Text, out int lb) && 
                int.TryParse(StoronaC.Text, out int lc))
            {

                int krs = 0;
                if (la == lb) krs += 1;
                if (lb == lc) krs += 1;
                if (lc == la) krs += 1;
                if (la > lb + lc) krs = -1;

                switch (krs)
                {
                    case 0: 
                        TypeTreugl.Text = "Разностроронний";
                        break;
                    case 1: 
                        TypeTreugl.Text = "Равнобедренный";
                        break;
                    case 2:
                    case 3:
                        TypeTreugl.Text = "Равносторонний";
                        break;
                }

            }
            else TypeTreugl.Text = "Ошибка! Проверьте данные!";
        }
    }
}
