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
        //khai báo Context để chuẩn bị CRUD table Fruit
        private Su26DieuDaoContext _ctx = new();  //biến local trong hàm, ko phải backing field

        //khai báo cái prop để hứng selectedOne từ Main gửi sang
        public Fruit EditedOne { get; set; } = null;
        //              _editedOne biến giấu mặt phía sau

        //biến này đóng vai trò biến flag, phất cờ, biến lưu mode, trạng thái màn hình: 
        //nó bằng null nghĩa là ko có ai edit, tức là tạo mới
        //nó = 1 row bên màn hình Main, tức là edit mode
        //nếu là eidt mode thì phải fill vào các ô nhập thằng đang được selected !!!!!!!!!!!!!!!!!!!!!



        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //FILL DANH SÁCH CATEGORY!!!!!!! KO CARE MODE EDIT | NEW
            //NHỜ CÁI THẰNG CTX NÓ GIÚP
            CateComboBox.ItemsSource = _ctx.Categories.ToList();
            CateComboBox.DisplayMemberPath = "Name"; //show cột Category.Name của table Category (| ID | Name |)
            //https://youtu.be/r_0TPwHjfpg?t=2041
            CateComboBox.SelectedValuePath = "Id";
            //treo đầu dê, treo cột Name, lấy cột Id

            //KHÓA CÁI Ô ID LẠI, KO CHO EDIT, KO CHO NHẬP KHI TẠO MỚI, VÌ KEY TỰ TĂNG
            IdTextBox.IsEnabled = false;

            //check mode để fill data khi là edit mode
            //new mode ko cần fill data
            if (EditedOne != null) {
                //fill data nè, fill vào ô nhập: .Text = value cần fill
                IdTextBox.Text = EditedOne.Id.ToString();
                NameTextBox.Text = EditedOne.Name;
                DescTextBox.Text = EditedOne.Description;
                PriceTextBox.Text = EditedOne.Price.ToString();

                //NHẢY ĐẾN ĐÚNG CÁI CATE Ở CHẾ ĐỘ EDIT 
                CateComboBox.SelectedValue = EditedOne.CategoryId; //value FK gán vào Combo
                                                                   //có value thì tự nhảy đến display tương ứng



                //đổi header trong cái nhãn FormModeLabel
                FormModeLabel.Content = "Cập nhật thông tin trái cây";
            }
            else
            {
                //tạo mới, ko đổ gì cả, đổi nhãn header
                FormModeLabel.Content = "Tạo mới thông tin trái cây";
                //nhảy default đến Category đầu tiên!!!!!!!!!!!!!!!!! ĐỐ EM !!!!!!!!!!!!!!!
                //TODO:
            }
        }

        //HÀM HELPER - HÀM TRỢ GIÚP CHO HÀM KHÁC
        public bool ValidateForm()
        {
            //kiểm tra từng ô nhập, coi có gõ gì ko, sai đến đâu chửi đến đó
            //và return false luôn dọc đường
            if (string.IsNullOrWhiteSpace(NameTextBox.Text.Trim()))
            {
                MessageBox.Show("Name is required", "Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(DescTextBox.Text.Trim()))
            {
                MessageBox.Show("Description is required", "Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            //Lưu ý: Java: Interger.parse(chuỗi-dạng-số) convert thành công từ text thành số
            //       C#  : int.Parse(chuỗi-dạng-số) convert thành công từ text thành số
            //       Đều bị Exception nếu đưa Ahihi, text ko là số!!!!
            //C# có thêm bool int.TryParse(text-số)  bool double.TryParse(text-số)  bool long.TryParse(text-số)
            //          nếu convert ko thành công, thì ko ném ngoại lệ, chỉ báo true false
            //OUT REF 

            //BẮT LỖI NHẬP SỐ MÀ LẠI GÕ AHIHI NGỌC TRINH
            //decimal price;
            //bool status = decimal.TryParse(PriceTextBox.Text.Trim(), out price);

            bool status = decimal.TryParse(PriceTextBox.Text.Trim(), out decimal price); //khai báo inline
            //status == true, convert thành công, và price chính là price nhập vào từ ô text
            //status == false, convert ko thành công, biến price ko care
            //                  chửi message
            if(status == false)
            {
                MessageBox.Show("Price must be a decimal number, e.g 3.14; 60.68", "Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            //status = decimal.TryParse(PriceTextBox.Text.Trim(), out decimal height); //khai báo inline
            //khai báo tiếp mà xài, ko cần phải tạo lại

            //chặn chọn ComboBox, ít nhất trong create mode
            if (CateComboBox.SelectedItem == null) {
                MessageBox.Show("Atleast one category must be selected!", "Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            //SelectedItem: nguyên dòng
            //SelectedValue: chỉ 1 hàng đó thôi

            return true;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(ValidateForm() == false)
            {
                return;
            }

            //gọi hàm Add() hay Update() tuỳ mode màn hình
            //ta tạo 1 object trống Fruit, sau đó set value từ màn hình vào object này!!!
            //và gọi hàm

            //LÀM TRƯỚC PHẦN EDIT CÁI ĐÃ

            Fruit obj = new Fruit();  //hứng value từ ô text thả vào object chuẩn bị xuống table

            obj.Name = NameTextBox.Text;
            obj.Description = DescTextBox.Text;
            obj.Price = decimal.Parse(PriceTextBox.Text);
            //obj.CategoryId = EditedOne.CategoryId; //FK 

            //LẤY ĐÚNG FK ĐANG ĐC CHỌN TRÊN COMBOX, CHỨ KO ĐC LẤY TỪ EDITED-ONE DO ĐANG LÀ THỨ CŨ
            //CHUYỂN TỪ MÀN HÌNH MAIN SANG, HOẶC ĐANG LÀ NULL Ở TẠO MỚI
            //TA LẤY CATE MỚI NHẤT TỪ DANH SÁCH CHỌN, KO CARE MODE
            //===tại sao phải ép kiểu vì thằng này là số nguyên, còn thằng kia là object=====
            obj.CategoryId = (int) CateComboBox.SelectedValue; //khó hiểu nha ??? Lấy value từ ô ComBoBox
            // https://youtu.be/r_0TPwHjfpg?t=3394
            //ÁP DỤNG CHO TẠO MỚI VÀ EDIT
            //LẤY VALUE TỪ Ô COMBO ĐỔ VÀO KHÓA NGOẠI
            //TRONG SAVE TỪ MÀN HÌNH CHỌN ĐỔ VÀO KHÓA NGOẠI VÀ CẤT XUỐNG TABLE

            //CHECK MODE - NẾU EDIT HOẶC TẠO MỚI, THÌ GỌI ĐÚNG HÀM CỦA BÊN CTX
            //DÙNG BIẾN FLAG EDITEDONE
            if (EditedOne != null)
            {
                obj.Id = int.Parse(IdTextBox.Text); 
                _ctx.Fruits.Update(obj); //VÀO RAM
            }
            else
            {
                obj.Id = null;
                _ctx.Fruits.Add(obj);
            }

            _ctx.SaveChanges(); //VÀO DATABASE

            this.Close(); //đóng cửa sổ này lại!!!!!!!!!!, kế thừa hàm Close() từ Cha Window

            //ctx.Fruits.Add(EditedOne);
            //ctx.Fruits.Update(EditedOne);
            //ctx.SaveChanges();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //lệnh Close của class Cha Window
        }

        
    }
}
