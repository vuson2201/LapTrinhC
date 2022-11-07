using System;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime PublishDate { get; set; }
        public string Content { get; set; } = null!;
    }
}
