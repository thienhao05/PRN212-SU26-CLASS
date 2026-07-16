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
        public Fruit EditedOne { get; set; } = null; //hàm set =
        //           _editedOne biến giấu mặt phía sau

        //biến này đóng vai trò biến flag, phất cờ, biến lưu mode, trạng thái màn hình:
        //nó bằng null nghĩa là ko có ai edit, tức là tạo mới
        //nó = 1 row bên màn hình Main, tức là edit mode
        //nếu là edit mode thì phải fill vào các ô nhập thằng đang đc selected!!!!!!!!!!!!!!!!11


        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //FILL DANH SÁCH CATEGORY!!!!! KO CARE MODE EDIT | NEW
            //NHỜ THẰNG CTX NÓ GIÚP
            //CateComboBox.ItemsSource = _ctx.Categories.ToList();
            List<Category> cates = _ctx.Categories.ToList(); //lấy ds Cates từ table

            //bổ sung thêm 1 thằng 0 | -- Vui lòng chọn cate --
            cates.Insert(0, new Category() { Id = 0, Name = "--Vui lòng chọn 1 category--" });
            CateComboBox.ItemsSource = cates;

            CateComboBox.DisplayMemberPath = "Name"; //show cột Category.Name của table Category (|ID | Name |)
            CateComboBox.SelectedValuePath = "Id";
            //treo đầu dê, treo cột Name, lấy cột Id

            //chọn default thằng đầu tiên - thằng Category 0 | Vui lòng...
            CateComboBox.SelectedValue = 0; //con số ---Vui lòng---


            //KHOÁ CÁI Ô ID LẠI, KO  CHO EDIT, KO CHO NHẬP KHI TẠO MỚI, VÌ KEY TỰ TĂNG
            IdTextBox.IsEnabled = false;

            //check mode để fill data khi là edit mode
            //new mode ko cần fill data
            if (EditedOne != null)
            {
                //fill data nè, fill vào ô nhập: .Text = value cần fill
                IdTextBox.Text = EditedOne.Id.ToString();
                NameTextBox.Text = EditedOne.Name;
                DescTextBox.Text = EditedOne.Description;
                PriceTextBox.Text = EditedOne.Price.ToString();

                //NHẢY ĐẾN ĐÚNG CÁI CATE Ở CHẾ ĐỘ EDIT 
                CateComboBox.SelectedValue = EditedOne.CategoryId;  //value FK gán vào combo
                                                                    //có value thì tự nhảy đến display tương ứng

                //đổi header trong nhãn FormModeLabel
                FormModeLabel.Content = "Cập nhật thông tin trái cây";                
            }
            else
            {
                //tạo mới, ko đổ gì cả, đổi nhãn header
                FormModeLabel.Content = "Tạo mới thông tin trái cây";
                //nhảy default đến Category đầu tiên!!!!!!!! ĐỐ EM!!!!!!
                //TODO: 
            }
        }

        //HÀM HELPER - HÀM TRỢ GIÚP CHO HÀM KHÁC
        public bool ValidateForm()
        {
            //kiểm tra từng o nhập, coi có gõ gì ko, sai đến đâu chửi đến đó
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

            //lưu ý: Java: Integer.parse(chuỗi-dạng-số) convert thành công từ text thành số
            //       C#:  int.Parse(chuỗi-dạng-số) convert thành công từ text số
            //            Đều bị Exception nếu đưa Ahihi, text ko là số!!!
            //C# có thêm bool int.TryParse(text-số)   bool double.TryParse(text-số)  long.TryParse() 
            //            nếu convert ko thành công, thì ko ném ngoại lệ, chỉ báo true false
            //OUT REF

            //bắt lỗi nhập số mà lại gõ ahihi ngọc trinh
            //decimal price;
            //bool status = decimal.TryParse(PriceTextBox.Text.Trim(), out price);

            bool status = decimal.TryParse(PriceTextBox.Text.Trim(), out decimal price); //khai báo inline
            //status == true, convert thành công, và price chính là price nhập vào từ ô text
            //status == false, convert ko thành công, biến price ko care
            //          chửi message
            if (status == false)
            {
                MessageBox.Show("Price must be a decimal number, e.g 3.14; 60.68", "Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            //chặn chọn combobox, ít nhất trong create mode
            if ((int)CateComboBox.SelectedValue == 0)
            {
                MessageBox.Show("Atleast one category must be selected!", "Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            //if (CateComboBox.SelectedItem == null)
            //{
            //    MessageBox.Show("Atleast one category must be selected!", "Required", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return false;
            //}


            return true;
        
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            if (ValidateForm() == false) {
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
            //LẤY ĐÚNG FK ĐANG ĐC CHỌN TRÊN COMBOBOX, CHỨ KO ĐC LẤY TỪ EDITED-ONE DO ĐANG LÀ THỨ CŨ
            //CHUYỂN TỪ MÀN HÌNH MAIN SANG, HOẶC ĐANG LÀ NULL Ở TẠO MỚI
            //TA LẤY CATE MỚI TỪ DANH SÁCH CHỌN, KO CARE MODE 
            obj.CategoryId = (int)CateComboBox.SelectedValue;


            //CHECK MODE - NẾU EDIT HOẶC TẠO MỚI, THÌ GỌI ĐÚNG HÀM CỦA BÊN CTX
            //DÙNG BIẾN FLAG EDITEDONE
            if (EditedOne != null)
            {
                obj.Id = int.Parse(IdTextBox.Text);
                _ctx.Fruits.Update(obj);
            }
            else
            {
                obj.Id = null;
                _ctx.Fruits.Add(obj);
            }
            _ctx.SaveChanges();

            this.Close(); //đóng cửa sổ này lại!!!!!!!!!!, kế thừa hàm Close() từ Cha Window

            //ctx.Fruits.Add(EditedOne);
            //ctx.Fruits.Update(EditedOne);
            //ctx.SaveChanges();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();  //lệnh Close() của class Cha Window
        }
    }

}
