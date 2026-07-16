using Giaolang.DieuDao.GUI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
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
        //~~~~ _id, _name, _yob, _gpa

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            //FruitsDataGrid.ItemsSource = 1 cái list cần lắm luôn
            FruitsDataGrid.ItemsSource = _ctx.Fruits.Include("Category").ToList();
            //                               đừng quên convert từ DbSet thành List<>

            //ĐỔ THỬ 1 DANH SÁCH TỪ RAM VÀO COMBOBOX, KO DÙNG TABLE
            //StatusComboBox.ItemsSource = ?;      danh sách List<> Mảng[] object nhiều cột
            //StatusComboBox.DisplayMemberPath = ? tên cột hiển thị  treo đầu dê
            //StatusComboBox.SelectedValuePath = ? tên cột lấy value   lấy thịt heo

            var status = new[] { new { Id = 1, Name = "Paid" },
                                 new { Id = 2, Name = "Packing" },
                                 new { Id = 3, Name = "Shipping" },
                                 new { Id = 4, Name = "Delivered" },
                                 new { Id = 5, Name = "Completed" }
                               };         //anonymous object, có 1 class ngầm đc tạo ra, 2 prop Id, Name, readonly 

            StatusComboBox.ItemsSource = status;
            StatusComboBox.DisplayMemberPath = "Name";
            StatusComboBox.SelectedValuePath = "Id";


        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //BẮT XEM ĐÃ CHỌN DÒNG CHƯA?
            Fruit? selectedOne = FruitsDataGrid.SelectedItem as Fruit;

            //chửi vì chưa chọn
            if (selectedOne == null)
            {
                MessageBox.Show("Please select a fruit before deleting", "Select!", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //thoát luôn!!!
            }

            //chọn rồi hỏi are you sure
            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.No)
            {
                return;
            }

            //CHÍNH THỨC XOÁ NÈ!!!!!!!!!!!!!!! MẤT DÒNG TRONG TABLE LUÔN 
            _ctx.Fruits.Remove(selectedOne);  //mất dòng trong ram
            _ctx.SaveChanges();               //mất dòng trong table

            //F5 TẢI LẠI GRID
            //XOÁ LƯỚI, ĐỔ LẠI DATA, CÓ JOIN
            FruitsDataGrid.ItemsSource = null; //xoá
            FruitsDataGrid.ItemsSource = _ctx.Fruits.Include("Category").ToList();

        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            //show màn hình DetailWindow trống trơn!!!
            //new Class và .Show()  .ShowDiaglog() 
            DetailWindow detail = new();

            //VÀO MODE NEW            
            detail.ShowDialog();

            //F5 CÁI GRID
            _ctx = new();
            FruitsDataGrid.ItemsSource = null;
            FruitsDataGrid.ItemsSource = _ctx.Fruits.Include("Category").ToList();


        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Fruit? selectedOne = FruitsDataGrid.SelectedItem as Fruit;

            //chửi vì chưa chọn
            if (selectedOne == null)
            {
                MessageBox.Show("Please select a fruit before editing", "Select!", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //thoát luôn!!!
            }

            //GỬI DÒNG NÀY SANG MÀN HÌNH DETAIL!!!!!!!!!!!!!!
            //MÀN HÌNH DETAIL VÀO MODE EDIT
            DetailWindow detail = new();
            detail.EditedOne = selectedOne;

            //VÀO MODE EDIT, ĐI KÈM SELECTED-ONE            
            detail.ShowDialog();  //ĐÓNG MÀN HÌNH EDIT THÌ PHẢI F5 GRID

            //F5 CÁI GRID
            _ctx = new();
            FruitsDataGrid.ItemsSource = null;
            FruitsDataGrid.ItemsSource = _ctx.Fruits.Include("Category").ToList();



        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string kw = SearchTextBox.Text.Trim();  //cắt trắng đầu đuôi, vì vô nghĩa
            if (string.IsNullOrWhiteSpace(kw))
            {
                //ko gõ gì cả, hay 1 đống dấu cách cx là ko gì cả thì search all
                FruitsDataGrid.ItemsSource = null;
                FruitsDataGrid.ItemsSource = _ctx.Fruits.Include("Category").ToList();
            }
            else
            {
                //có keyword đã trim(), where trên list
                //var result = _ctx.Fruits.Include("Category").Where(x => x.Name == kw || x.Description == kw);  //where = chứ ko phải where like
                var result = _ctx.Fruits.Include("Category").Where(x => x.Name.Contains(kw) || x.Description.Contains(kw));
                FruitsDataGrid.ItemsSource = null;
                FruitsDataGrid.ItemsSource = result.ToList();
            } //LINQ
        }
    }
}
