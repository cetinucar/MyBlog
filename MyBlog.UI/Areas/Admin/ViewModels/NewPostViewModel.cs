﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Areas.Admin.ViewModels
{
    public class NewPostViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Lütfen bir başlık giriniz.")]
        public string Title { get; set; }

        [Display(Name = "İçerik")]
        public string Content { get; set; }

        [Display(Name = "İçerik")]
        [Required(ErrorMessage = "Lütfen bir kategori seçiniz.")]
        public int? CategoryId { get; set; }


    }
}
