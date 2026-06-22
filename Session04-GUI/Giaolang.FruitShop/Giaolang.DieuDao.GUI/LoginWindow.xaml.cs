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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            //hỏi are you sure 
            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Quit?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            if(answer == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }


        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //bắt 2 ô nhập để lấy value email và pass để đẩy xuống DB
            //ta xài Get() của mỗi ô nhập
            //gán vào biến bình thường để tiện xử lý
            string email, password;
            email = EmailTextBox.Text; //lấy đc email òi
            password = PassTextBox.Text;

            string msg = $"Email: {email}\nPassword: {password}";

            //in thử: hàm messi
            //MessageBox.Show(msg);

            //vào db, thấy 1 dòng match, mời vào màn hình MainWindow
            if(email == "nt" && password == "tr")
            {
                //mời vào main, mỗi cửa sổ là 1 class, new và render
                MainWindow main = new(); //ăn bớt vế phải
                //main.Show(); //render
                //giấu login trước khi show
                this.Hide();
                main.ShowDialog(); //chỉ có 1 cửa sổ mà hoy

            }
            else
            {
                MessageBox.Show("Wrong credentials", "Wrong!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
