using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models.Entities;
using MVCMusicStore.Models.Concrete;
using System.Data.Entity;

namespace MVCMusicStore.Controllers
{
    public class MusicCartController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();

        public ActionResult Index(Cart cart,string returnUrl)
        {
            var model = cart;
            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        public ActionResult AddToCart(Cart cart,int musicId,string returnUrl)
        {
            Music music = db.Musics.SingleOrDefault(m=>m.MusicId==musicId);
            if (music != null)
            {
                cart.AddItem(music, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public ActionResult RemoveFromCart(Cart cart,int musicId,string returnUrl)
        {
            Music music = db.Musics.SingleOrDefault(m => m.MusicId == musicId);
            if(music!=null)
            {
                cart.RemoveItem(music);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}