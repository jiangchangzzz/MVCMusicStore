using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models.Entities
{
    public class CartLine
    {
        public Music Music { get; set; }
        public int Quantity { get; set; }
    }
}