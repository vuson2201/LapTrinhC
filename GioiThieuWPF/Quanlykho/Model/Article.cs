using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Quanlykho.Model
{
    public partial class Article: INotifyPropertyChanged
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set {
                if (this._Id != value)
                {
                    this._Id = value;
                    this.NotifyPropertyChanged("Id");
                }
            }
        }
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set {
                if (this._Title != value)
                {
                    this._Title = value;
                    this.NotifyPropertyChanged("Title");
                }
            }
        }
        private DateTime _PublishDate;

        public DateTime PublishDate
        {
            get { return _PublishDate; }
            set {
                if (this._PublishDate != value)
                {
                    this._PublishDate = value;
                    this.NotifyPropertyChanged("PublishDate");
                }
            }
        }
        private string _Content;

        public string Content
        {
            get { return _Content; }
            set {
                if (this._Content != value)
                {
                    this._Content = value;
                    this.NotifyPropertyChanged("Content");
                }
            }
        }



        //public int Id { get; set; }
        //public string Title { get; set; } = null!;
        //public DateTime PublishDate { get; set; }
        //public string Content { get; set; } = null!;



        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string prop)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
