using Giaolang.DieuDao.GUI.Entities;
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

namespace Giaolang.DieuDao.GUI
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

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            //hứng nút đc bấm, thả vào biến thuộc class MessageBoxResult
            MessageBoxResult answer =  MessageBox.Show("Are you sure?", "Quit?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes) 
            { 
                Application.Current.Shutdown();
            }
        }

        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            //chuẩn bị data đổ vào data grid
            List<Fruit> list = new List<Fruit>();
            list.Add(new Fruit() {
                Id = "MC",
                Name = "Mãng Cầu",
                Desc = "Mãng cầu là...",
                Price = 5.0
            });

            list.Add(new Fruit()
            {
                Id = "SS",
                Name = "Sung Sướng",
                Desc = "Trái sung là...",
                Price = 6.0
            });

            list.Add(new Fruit()
            {
                Id = "DD",
                Name = "Dừa",
                Desc = "Dừa dừa cx cx là...",
                Price = 7.0
            });

            FruitDataGrid.ItemsSource = list;
        }
    }
}