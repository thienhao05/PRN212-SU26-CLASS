using Q2.DieuDao.DAL;
using Q2.DieuDao.DAL.Entities;
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

namespace Q2.DieuDao
{
    //CODE THỰC DỤNG, KO CHIA 3-LAYER, CHƠI TRỰC TIẾP DBCONTEXT
   
    public partial class MainWindow : Window
    {
        private Su26DieuDaoContext _ctx = new(); //new nó là có trong tay danh sách List<Fruit>, List<Category> ứng với 2 table Fruit và Category

        //MỞ MÀN HÌNH LÊN THÌ FILL VÀO GRID, TA CODE Ở _LOADED EVENT
        //TA LÀM HÀM FILL GRID ĐỂ RE-USE KHI UPDATE, DELETE, SEARCH,...

        public void FillGrid()
        {
            FruitDataGrid.ItemsSource = null; //xoá grid
            FruitDataGrid.ItemsSource = _ctx.Fruits.ToList(); //select * from Fruit xong!!!
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillGrid();
        }

        private void FruitDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //hàm này tự chạy nếu ta select 1 dòng nào đó, mỗi dòng chính là 1 trái cây Fruit
            //ta hứng thằng này, dổi vào các ô text ở dưới để phục vụ edit
            Fruit? selectedOne = FruitDataGrid.SelectedItem as Fruit;
            if(selectedOne == null)
            {
                return; //cố tình chọn dòng trống, thì ko làm gì cả
            }

            //ngược lại chọn 1 dòng, bắt đc 1 cháu, fill cháu vào các ô text
            IdTextBox.Text = selectedOne.Id.ToString();
            NameTextBox.Text = selectedOne.Name;
            DescTextBox.Text = selectedOne.Description;
            PriceTextBox.Text = selectedOne.Price.ToString();
        }
    }
}