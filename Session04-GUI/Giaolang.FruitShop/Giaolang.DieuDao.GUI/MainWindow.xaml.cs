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
        //chuẩn bị data đổ vào data grid
        private List<Fruit> _list = new List<Fruit>(); //backing field của 1 class

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
            //List<Fruit> list = new List<Fruit>();
            _list.Add(new Fruit() {
                Id = "MC",
                Name = "Mãng Cầu",
                Desc = "Mãng cầu là...",
                Price = 5.0
            });

            _list.Add(new Fruit()
            {
                Id = "SS",
                Name = "Sung Sướng",
                Desc = "Trái sung là...",
                Price = 6.0
            });

            _list.Add(new Fruit()
            {
                Id = "DD",
                Name = "Dừa",
                Desc = "Dừa dừa cx cx là...",
                Price = 7.0
            });

            FruitDataGrid.ItemsSource = _list;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            _list.Add(new Fruit()
            {
                Id = "MC",
                Name = "Mãng Cầu",
                Desc = "Mãng cầu là...",
                Price = 5.0
            });

            _list.Add(new Fruit()
            {
                Id = "SS",
                Name = "Sung Sướng",
                Desc = "Trái sung là...",
                Price = 6.0
            });

            _list.Add(new Fruit()
            {
                Id = "DD",
                Name = "Dừa",
                Desc = "Dừa dừa cx cx là...",
                Price = 7.0
            });

            FruitDataGrid.ItemsSource = _list;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //khi user nhấn nút Delete, ta làm những việc sau: 
            //1. check xem user đã chọn 1 dòng nào đó hay chưa, nếu chọn rồi thì tóm lấy object ứng với cái dòng!!!

            //khai báo 1 biến hứng dòng Fruit đc chọn, hoặc bằng null nếu chưa chọn
            Fruit? chosenOne = FruitDataGrid.SelectedItem as Fruit;

            if(chosenOne == null)
            {
                //chửi
                MessageBox.Show("Please select a fruit before deleteing!", "Select one", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return; //thoát hàm này luôn, ko chạy xuống dưới xóa
            }

            //in thử cháu sẽ bị xóa, đang bị trỏ bởi biến chosenOne


            //2. hỏi confirm Are you sure? (0.5 điểm trong vài PE)
            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Confirm?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                MessageBox.Show($"Mày ĐÃ BỊ xóa: {chosenOne.Id} | {chosenOne.Name}");
                _list.Remove(chosenOne);  //xóa cái thằng đang trỏ, ArrayList, lsit có hàm xóa 1 object
                FruitDataGrid.ItemsSource = null; //xóa trằng rồi đổ vào lại
                FruitDataGrid.ItemsSource = _list; //fill lại cái grid
            }
            //3. xóa dòng, xóa dòng trong table nếu user YES

            //4. fill lại cái DataGrid = lệnh .ItemSource = list mới
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Fruit? chosenOne = FruitDataGrid.SelectedItem as Fruit;

            if (chosenOne == null)
            {
                //chửi
                MessageBox.Show("Please select a fruit before editing!", "Select one", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return; //thoát hàm này luôn, ko chạy xuống dưới xóa
            }

            DetailWindow detail = new();
            //detail.Show();
            detail.EditedOne = chosenOne;
            detail.ShowDialog();
        }
    }
}

//Modal trong lập trình FE, là mấu đồ huyền cạnh bo, làm giao diện