using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCMusicStore.Models.Concrete;
using MVCMusicStore.Models.Entities;

namespace MVCMusicStore.Models
{
    public class MusicStoreDbInitializer:DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Categorys.Add(new Category { CategoryId = 1, Name = "Rock" });
            context.Categorys.Add(new Category { CategoryId = 2, Name = "Jazz" });
            context.Categorys.Add(new Category { CategoryId = 3, Name = "Metal" });

            context.Artists.Add(new Artist { ArtistId = 1, Name = "Red" });
            context.Artists.Add(new Artist { ArtistId = 2, Name = "Green" });
            context.Artists.Add(new Artist { ArtistId = 3, Name = "Black" });

            context.Musics.Add(new Music { MusicId = 1, Name = "Tie", Price = 15m, ArtistId = 1 ,CategoryId = 2 });
            context.Musics.Add(new Music { MusicId = 2, Name = "Rool", Price = 12m, ArtistId = 3, CategoryId = 1 });
            context.Musics.Add(new Music { MusicId = 3, Name = "Bash", Price = 7m, ArtistId = 2, CategoryId = 1 });
            context.Musics.Add(new Music { MusicId = 4, Name = "Rush", Price = 8m, ArtistId = 3, CategoryId = 3 });
            context.Musics.Add(new Music { MusicId = 5, Name = "Seed", Price = 34m, ArtistId = 2, CategoryId = 2 });
            context.Musics.Add(new Music { MusicId = 6, Name = "Sun", Price = 8m, ArtistId = 1, CategoryId = 3 });

            base.Seed(context);
        }
    }
}