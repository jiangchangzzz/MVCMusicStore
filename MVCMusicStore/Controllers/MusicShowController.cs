using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models.Concrete;
using System.Data.Entity;
using MVCMusicStore.Models.Entities;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class MusicShowController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        public ActionResult List(int? categoryId)
        {
            var musics = db.Musics
                .Where(m => categoryId == null || m.CategoryId == categoryId)
                .Include(m => m.Category)
                .Include(m => m.Artist);
            return PartialView(musics.ToList());
        }

        public ActionResult ArtistSearch(string artistName)
        {
            var artists = db.Artists.Where(m => m.Name.Contains(artistName));
            return PartialView(artists.ToList());
        }

        public PartialViewResult Nav()
        {
            var categorys = db.Categorys.OrderBy(m=>m.Name);
            return PartialView(categorys.ToList());
        }

        public PartialViewResult Summary(Cart cart)
        {
            var viewModel = new MusicShowSummaryViewModel { Quantity =cart.Lines.Sum(m=>m.Quantity),
                TotalPrice=cart.ComputeTotalValue()};
            return PartialView(viewModel);
        }
    }
}