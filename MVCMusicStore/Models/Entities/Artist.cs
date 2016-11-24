using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore.Models.Entities
{
    public class Artist
    {
        [Required]
        public virtual int ArtistId { get; set; }

        [Required]
        [Display(Name="艺术家名")]
        public virtual string Name { get; set; }
    }
}