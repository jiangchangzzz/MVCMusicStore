using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore.Models.Entities
{
    public class Music
    {
        [Required]
        public virtual int MusicId { get; set; }

        [Required]
        [Display(Name="音乐名")]
        public virtual string Name { get; set; }

        [Display(Name="描述")]
        public virtual string Description { get; set; }

        [Required]
        [Display(Name="价格")]
        public virtual decimal Price { get; set; }

        [Required]
        public virtual int ArtistId { get; set; }

        [Required]
        public virtual int CategoryId { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual Category Category { get; set; }
    }
}