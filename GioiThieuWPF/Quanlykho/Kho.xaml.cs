using MaterialDesignThemes.Wpf;
using Quanlykho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Kho.xaml
    /// </summary>
    public partial class Kho : Window
    {
        MyBlogContext context = new MyBlogContext();
        private ObservableCollection<Article> articles;
        public Kho()
        {
            InitializeComponent();
            articles =new ObservableCollection<Article>(context.Articles);
            lvUsers.ItemsSource = articles;

            //lvUsers.ItemsSource = context.Articles.ToList();
        }

        //private void Btn_Them(object sender, RoutedEventArgs e)
        //{
        //    if (txt_Title.Text == ""||txt_PublishDate.Text==""||txt_Content.Text=="")
        //    {
        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
        //    } 
        //    else
        //    {
        //        var add = new Article
        //        {
        //            Title = txt_Title.Text,
        //            PublishDate = txt_PublishDate.SelectedDate.Value,
        //            Content = txt_Content.Text
        //        };
        //        articles.Add(add);
        //        context.Articles.Add(add);
        //        context.SaveChanges();
        //        //lvUsers.ItemsSource = context.Articles.ToList();
        //    }

        //}

        //private void Btn_Sua(object sender, RoutedEventArgs e)
        //{
        //    if (txt_Title.Text == "" || txt_PublishDate.Text == "" || txt_Content.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin","Lỗi",MessageBoxButton.OK,MessageBoxImage.Error);
        //    }
        //    else
        //    {
        //        if (lvUsers.SelectedItem != null)
        //        {
        //            var edit = (Article)lvUsers.SelectedItem;
        //            edit.Title = txt_Title.Text;
        //            edit.PublishDate = txt_PublishDate.SelectedDate.Value;
        //            edit.Content = txt_Content.Text;
        //        }
        //        context.SaveChanges();
        //        //lvUsers.Items.Refresh();
        //    }
        //}

        //private void Btn_Xoa(object sender, RoutedEventArgs e)
        //{
        //    var delete = (Article)lvUsers.SelectedItem;
        //    articles.Remove(delete);
        //    context.Articles.Remove(delete);
        //    context.SaveChanges();
        //    //lvUsers.ItemsSource = context.Articles.ToList();
        //}



        //commands
        private void AddCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true; 
        }

        private void AddCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (txt_Title.Text == "" || txt_PublishDate.Text == "" || txt_Content.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var add = new Article
                {
                    Title = txt_Title.Text,
                    PublishDate = txt_PublishDate.SelectedDate.Value,
                    Content = txt_Content.Text
                };
                articles.Add(add);
                context.Articles.Add(add);
                context.SaveChanges();

                //lvUsers.ItemsSource = context.Articles.ToList();
            }
        }
        private void EditCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txt_Title.Text != "") && (txt_Content.Text != "") && (txt_PublishDate.Text != "")&&(lvUsers.SelectedItem != null);
        }

        private void EditCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var edit = (Article)lvUsers.SelectedItem;
            edit.Title = txt_Title.Text;
            edit.PublishDate = txt_PublishDate.SelectedDate.Value;
            edit.Content = txt_Content.Text;
            context.SaveChanges();

            //lvUsers.Items.Refresh();
        }
        private void DeleteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txt_Title.Text != "") && (txt_Content.Text != "") && (txt_PublishDate.Text != "") && (lvUsers.SelectedItem != null);
        }

        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var delete = (Article)lvUsers.SelectedItem;
            articles.Remove(delete);
            context.Articles.Remove(delete);
            context.SaveChanges();

            //lvUsers.Items.Refresh();
        }
    }
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Add = new RoutedUICommand
            (
                "Add",
                "Add",
                typeof(CustomCommands)
            );
        public static readonly RoutedUICommand Edit = new RoutedUICommand
            (
                "Edit",
                "Edit",
                typeof(CustomCommands)
            );
        public static readonly RoutedUICommand Delete = new RoutedUICommand
           (
               "Delete",
               "Delete",
               typeof(CustomCommands)
           );
    }
}
