using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Blog
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [Display(Name = "����")]
        public string Title { get; set; }

        [Display(Name = "����")]
        public string Content { get; set; }

        [Display(Name = "����")]
        public int Owner { get; set; }

        [Display(Name = "����ʱ��")]
        public DateTime Created { get; set; }

        [Display(Name = "����ʱ��")]
        public DateTime Updated { get; set; }

    }
}