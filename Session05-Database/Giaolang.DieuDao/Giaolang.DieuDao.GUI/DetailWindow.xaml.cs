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
            //check mode để fill data khi là edit mode
            //new mode ko cần fill data
            if(EditedOne != null) {
                //fill data nè, fill vào ô nhập: .Text = value cần fill
                IdTextBox.Text = EditedOne.Id.ToString();
                NameTextBox.Text = EditedOne.Name;
                DescTextBox.Text = EditedOne.Description;
                PriceTextBox.Text = EditedOne.Price.ToString();

                //đổi header trong cái nhãn FormModeLabel
                FormModeLabel.Content = "Cập nhật thông tin trái cây";
            }
            else
            {
                //tạo mới, ko đổ gì cả, đổi nhãn header
                FormModeLabel.Content = "Tạo mới thông tin trái cây";
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //khai báo Context để chuẩn bị CRUD table Fruit
            Su26DieuDaoContext ctx = new();  //biến local trong hàm, ko phải backing field

            //gọi hàm Add() hay Update() tuỳ mode màn hình
            //ta tạo 1 object trống Fruit, sau đó set value từ màn hình vào object này!!!
            //và gọi hàm

            //LÀM TRƯỚC PHẦN EDIT CÁI ĐÃ

            Fruit obj = new Fruit();  //hứng value từ ô text thả vào object chuẩn bị xuống table
            obj.Id = int.Parse(IdTextBox.Text);
            obj.Name = NameTextBox.Text;
            obj.Description = DescTextBox.Text;
            obj.Price = decimal.Parse(PriceTextBox.Text);
            obj.CategoryId = EditedOne.CategoryId;

            ctx.Fruits.Update(obj);
            ctx.SaveChanges();

            this.Close(); //đóng cửa sổ này lại!!!!!!!!!!, kế thừa hàm Close() từ Cha Window

            //ctx.Fruits.Add(EditedOne);
            //ctx.Fruits.Update(EditedOne);
            //ctx.SaveChanges();
        }
    }
}
