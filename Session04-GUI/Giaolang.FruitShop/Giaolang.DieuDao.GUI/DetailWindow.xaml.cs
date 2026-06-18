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
            //fill data nè
            //đồ từ object, từng field object vào từng ô nhập
            IdTextBox.Text = EditedOne.Id;
            NameTextBox.Text = EditedOne.Name;
            DescTextBox.Text = EditedOne.Desc;
            PriceTextBox.Text = EditedOne.Price.ToString();

        }
    }
}
