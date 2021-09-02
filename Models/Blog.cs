using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Blog
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [Display(Name = "标题")]
        public string Title { get; set; }

        [Display(Name = "内容")]
        public string Content { get; set; }

        [Display(Name = "作者")]
        public int Owner { get; set; }

        [Display(Name = "创建时间")]
        public DateTime Created { get; set; }

        [Display(Name = "更新时间")]
        public DateTime Updated { get; set; }

    }
}