using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Group4_Version2
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

        private void _NavFrame_Navigated(object sender, NavigationEventArgs e)

        {
            
        }

        private void GameHistory_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Navigate(new GameHistoryPage());
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {


            NavFrame.Navigate(new GamePage());
            
        }
    }
}
