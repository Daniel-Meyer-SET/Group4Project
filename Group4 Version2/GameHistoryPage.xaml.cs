using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for GameHistoryPage.xaml
    /// </summary>
    public partial class GameHistoryPage : Page
    {
        public GameHistoryPage()
        {
            InitializeComponent();

        }

        public void LoadDBData() {
            string connectStr = ConfigurationManager.ConnectionStrings["dbConnectStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                try
                {
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM gameHist", con);

                    DataTable tableData = new DataTable();
                    adapter.Fill(tableData);
                    scoreTable.ItemsSource = tableData.AsDataView();
                }
                catch (SqlException e) { 
                
                }
            }
        
        }

        private void winLoaded(object sender, RoutedEventArgs e)
        {
            LoadDBData();
        }
    }
}
