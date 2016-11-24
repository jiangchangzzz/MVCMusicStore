using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore.Models.Entities
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name="类别")]
        public string Name { get; set; }
    }
}