using Caliburn.Micro;
using Quanlykho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Data;
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;

namespace Quanlykho.ViewModels
{
    internal class KhoViewModel:Screen
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set
            {
                if (this._Id != value)
                {
                    this._Id = value;
                    this.NotifyOfPropertyChange("Id");
                }
            }
        }
        private string _Title="";
        [Required(ErrorMessage ="Tiêu đề không được để trống")]
        public string Title
        {
            get { return _Title; }
            set
            {
                
                if (this._Title != value)
                {
                    this._Title = value;
                    this.NotifyOfPropertyChange("Title");
                }
                //ValidateProperty(value, "Title");
            }
        }
        private DateTime? _PublishDate;
        public DateTime? PublishDate
        {
            get { return _PublishDate; }
            set
            {
                if (this._PublishDate != value)
                {
                    this._PublishDate = value;
                    this.NotifyOfPropertyChange("PublishDate");
                }
            }
        }
        private string _Content="";
        [Required(ErrorMessage = "Nội dung không được để trống")]
        public string Content
        {
            get { return _Content; }
            set
            {
                
                if (this._Content != value)
                {
                    this._Content = value;
                    this.NotifyOfPropertyChange("Content");
                }
                //ValidateProperty(value, "Content");
            }
        }
        //private void ValidateProperty<T>(T value,string name)
        //{
        //    Validator.ValidateProperty(value, new ValidationContext(this, null, null)
        //    {
        //        MemberName=name
        //    });
        //}
        private Article _SelectedItem;
        public Article SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                this._SelectedItem = value;
                this.NotifyOfPropertyChange("SelectedItem");
                if (this._SelectedItem != null)
                {
                    Id = this._SelectedItem.Id;
                    Title=this._SelectedItem.Title;
                    Content=this._SelectedItem.Content;
                    PublishDate = this._SelectedItem.PublishDate;
                }
            }
        }
        private ObservableCollection<Article> _articles;
        public ObservableCollection<Article> articles
        {
            get { return _articles; }
            set {
                if (this._articles != value)
                {
                    this._articles = value;
                    this.NotifyOfPropertyChange("articles");
                }
            }
        }
        //public void AddCommand()
        //{
        //    var add = new Article
        //    {
        //        Title = Title,
        //        PublishDate = PublishDate,
        //        Content = Content
        //    };
        //    articles.Add(add);
        //    context.Articles.Add(add);
        //    context.SaveChanges();
        //}
        //public bool CanAddCommand()
        //{
        //    return true;
        //}
        //public void EditCommand(string title, string content)
        //{
        //    var edit = context.Articles.Where(c => c.Id == SelectedItem.Id).SingleOrDefault();
        //    edit.Title = Title;
        //    edit.PublishDate = PublishDate;
        //    edit.Content = Content;
        //    context.SaveChanges();
        //}
        //public bool CanEditCommand(string title, string content)
        //{
        //    if (string.IsNullOrEmpty(title)||string.IsNullOrEmpty(content)) return false;
        //    else return true;
        //}
        //public void DeleteCommand(Article selectedItem)
        //{
        //    var delete = context.Articles.Where(c => c.Id == SelectedItem.Id).SingleOrDefault();
        //    context.Articles.Remove(delete);
        //    context.SaveChanges();
        //    articles.Remove(SelectedItem);
        //}
        //public bool CanDeleteCommand(Article selectedItem)
        //{
        //    if (selectedItem!=null) return true;
        //    else return false;
        //}

        //MyBlogContext context = new MyBlogContext();
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        static HttpClient Client = new HttpClient();

        private async void GetArticleAsync()
        {
            var response = await Client.GetStringAsync("api/Articles");
            articles = JsonConvert.DeserializeObject<ObservableCollection<Article>>(response);
        }

        private async void CreateArticleAsync(Article article)
        {
            await Client.PostAsJsonAsync("api/Articles", article);
            GetArticleAsync();
            Clear();
        }

        private async void UpdateArticleAsync(Article article)
        {
            await Client.PutAsJsonAsync($"api/Articles/{article.Id}", article);
            GetArticleAsync();
            Clear();
        }
        private async void DeleteArticleAsync(int id)
        {
            await Client.DeleteAsync($"api/Articles/{id}");
            GetArticleAsync();
            Clear();
        }
        private void Clear()
        {
            Title = "";
            PublishDate = null;
            Content = "";
        }
        public KhoViewModel()
        {
            Client.BaseAddress = new Uri("https://localhost:7287/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            this.GetArticleAsync();

            LoginCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                
            });

            AddCommand = new RelayCommand<object>((p) => {
                if ((Title != "") && (Content != "") && (PublishDate != null)) return true;
                return false;
            }, (p) => {
                
                var add = new Article
                {
                    Title = Title,
                    PublishDate = PublishDate,
                    Content = Content
                };
                CreateArticleAsync(add);
                MessageBox.Show("Thêm thành công");
                
            });

            EditCommand = new RelayCommand<object>((p) => {
                if ((Title != "") && (Content != "") && (PublishDate != null) && (SelectedItem != null)) return true;
                return false;

            }, (p) => {
                var edit = SelectedItem;
                edit.Title = Title;
                edit.PublishDate = PublishDate;
                edit.Content = Content;
                UpdateArticleAsync(edit);
                
                MessageBox.Show("Sửa thành công");
                
            });

            DeleteCommand = new RelayCommand<object>((p) => {
                if ((SelectedItem != null)) return true;
                return false;
            }, (p) => {
                var delete = SelectedItem;
                DeleteArticleAsync(delete.Id);
                MessageBox.Show("Xóa thành công");
                
            });
        }
    }
}
