using Microsoft.EntityFrameworkCore;
using PE.Exam.Entities;
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

namespace PE.Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Su26DieuDaoContext _ctx = new(); //new ăn bớt vế phải
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            FruitsDataGrid.ItemsSource = _ctx.Fruits.Include("Category").ToList();

            var status = new[] { 
                new
                {
                    Id = 1,
                    Name = "Paid",
                },
                new { 
                    Id = 2, 
                    Name = "Packing" 
                },
                new { 
                    Id = 3, 
                    Name = "Shipping" 
                },
                new { 
                    Id = 4, 
                    Name = "Delivered" 
                },
                new { 
                    Id = 5, 
                    Name = "Completed" 
                }
            };

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

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}