using Giaolang.DieuDao.GUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Giaolang.DieuDao.GUI
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        //cần 1 biến chứa trỏ thằng ChosenOne bên Main, thằng bị edit đó em!!!
        //style get set kiểu mới thay vì _backingField, phỉa làm get set truyền thống hoặc propfull tab tab 

        //prop tab tab
        public Fruit EditedOne { get; set; } // = chosenOne bên Main set sang


        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            //KHÁC NULL TỨC LÀ EDIT MODE
            if (EditedOne != null) //biến eidited one chính là biến phất cờ trạng thái
            {
                //fill data nè
                //đồ từ object, từng field object vào từng ô nhập
                IdTextBox.Text = EditedOne.Id;
                NameTextBox.Text = EditedOne.Name;
                DescTextBox.Text = EditedOne.Desc;
                PriceTextBox.Text = EditedOne.Price.ToString();
            }

            //dù new hay edit mode đều phải đổ vào ôn chọn category
            List<Category> cates = new List<Category>(); //chuẩn bị danh sách Category, lẽ ra đọc từ table, làm sau !!!
            cates.Add(new Category()
            {
                Id = "1",
                Name = "TRÁI CÂY VIETGAP",
                Desc = "....."
            });

            cates.Add(new Category()
            {
                Id = "2",
                Name = "TRÁI CÂY NHẬP KHẨU",
                Desc = "....."
            });

            cates.Add(new Category()
            {
                Id = "3",
                Name = "TRÁI CÂY SẤY KHÔ",
                Desc = "....."
            });

            CateComboBox.ItemsSource = cates;
            CateComboBox.DisplayMemberPath = "Name"; //cột này dùng để show data xuất hiện cho user
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //lấy giá trị trong ô nhập
            string id = IdTextBox.Text.Trim(); //1 đống dấu cách bị cắt, vì vô nghĩa
            string name = NameTextBox.Text.Trim();
            string desc = DescTextBox.Text.Trim();
            string price = PriceTextBox.Text.Trim(); //LÀM SAO BẮT LỖI ĐC Ô GIÁ TIỀN
                                                     // NẾU NGƯỜI TA GÕ AHIHI -> CHỬI
                                                     //VÌ KO LÀ CON SỐ
                                                     //NẾU GÕ 5..5 CHỬI LUÔN...
                                                     //TÓM LẠI: CHỬI NẾU KO PHẢI LÀ SỐ THỰC
                                                     //CODE KHOẢNG 5 - 7 DÒNG CỦA C#, TỰ TÌM HIỂU

            //bắt validation
            if(string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Id is required", "Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //chửi xong thì thoát luôn
            }

            //ổn thì xuống đây gọi việc save DB
            //TODO: làm sau
            //giả bộ thông báo save thành công
            MessageBox.Show("Save fruit successfully!", "Noti", MessageBoxButton.OK, MessageBoxImage.Information);

            //CÙNG 1 MÀN HÌNH MÀ 2 CHỨC NĂNG CREATE VÀ EDIT LUÔN
            //DETAIL NEW VÀ DETAIL EDIT KO TỐT VỀ MẶT RE-USE
            //1 CÁI NÀY DÙNG CHUNG CHO CẢ 2 THẰNG LUÔN


        }
    }
}
