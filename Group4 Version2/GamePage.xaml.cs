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

namespace Group4_Version2
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
        }
        int playerCount = 0;
        string player1Name;
        string player2Name;
        private void NameButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewName.Text.Length > 0 && playerCount <2) {
                // start a new game with 2 players
            playerCount++;
                if (playerCount == 1) {
                  player1Name = NewName.Text;
                    NewName.Text = null;
                }
                if (playerCount == 2) {
                     player2Name = NewName.Text;

                    NewName.Text = null;
                    Game game = new Game(player1Name,player2Name);
                    
                }

            }
            
            
        }
       
    }
}
