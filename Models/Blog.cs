using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Content { get; set; }

        public decimal Price { get; set; }
    }
}