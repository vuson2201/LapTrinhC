using Quanlykho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Quanlykho
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_DangNhap(object sender, RoutedEventArgs e)
        {
            if (txt_UserName.Text == "" || txt_PassWord.Password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string userName = txt_UserName.Text;
                string passWord = txt_PassWord.Password;
                MyBlogContext myBlog = new MyBlogContext();
                var count = myBlog.Users.Where(a => a.UserName == userName && a.PasswordHash == passWord).Count();
                if (count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công", "Xác nhận", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Hide();
                    Kho kho = new Kho();
                    kho.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập ko thành công", "Xác nhận", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                
            }
        }

        private void Btn_Thoat(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
