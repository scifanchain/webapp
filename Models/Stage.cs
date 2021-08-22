using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Stage
    {
        public int StageID { get; set; }

        public int Type { get; set; }

        [StringLength(100, MinimumLength =1)]
        public string Title { get; set; }

        [Required ,Display(Name = "内容")]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Updated { get; set; }
    }
}