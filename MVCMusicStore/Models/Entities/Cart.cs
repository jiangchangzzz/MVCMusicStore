using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models.Entities
{
    public class Cart
    {
        private List<CartLine> lines=new List<CartLine>();

        public void AddItem(Music music,int quantity)
        {
            CartLine line = lines.Where(m => m.Music.MusicId == music.MusicId).SingleOrDefault();
            if(line==null)
            {
                lines.Add(new CartLine { Music = music, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveItem(Music music)
        {
            lines.RemoveAll(m => m.Music.MusicId == music.MusicId);
        }

        public decimal ComputeTotalValue()
        {
            return lines.Sum(m => m.Music.Price * m.Quantity);
        }

        public void Clear()
        {
            lines.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lines; }
        }
    }
}