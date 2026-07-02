using Giaolang.DieuDao.GUI.Entities;
using Microsoft.EntityFrameworkCore;
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
        private Su26DieuDaoContext _ctx = new(); //new ăn bớt vế phải
        //~~~~~ _id, _name, _yob, _gpa
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //FruitsDataGrid.ItemsSource = 1 cái list cần lắm luôn
            FruitsDataGrid.ItemsSource = _ctx.Fruits.Include("Category").ToList();
            //                  đừng quên convert từ DbSet thành List<>

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //VUA BIẾT MẶT, CHÚA ĐẶT TÊN: 
            //BẮT XEM ĐÃ CHỌN DÒNG CHƯA ? 
            Fruit? selectedOne = FruitsDataGrid.SelectedItem as Fruit;

            //chửi vì chưa chọn
            if(selectedOne == null)
            {
                MessageBox.Show("Please select a fruit before deleting", "Select!", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //thoát luôn
            }

            //chọn rồi hỏi are you sure 
            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(answer == MessageBoxResult.No)
            {
                return;
            }

            //CHÍNH THỨC XÓA NÈ !!!!! MẤT DÒNG TRONG TABLE LUÔN
            _ctx.Fruits.Remove(selectedOne); //mất dòng trong ram
            _ctx.SaveChanges();              //mất dòng trong table

            //F5 TẢI LẠI GRID
            //XÓA LƯỚI, ĐỔI LẠI DATA, CÓ JOIN
            FruitsDataGrid.ItemsSource = null; //xóa
            FruitsDataGrid.ItemsSource = _ctx.Fruits.Include("Category").ToList();
        }
    }
}