using SongProject.Models;
using SongProject.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SongProject.Controllers
{
    public class SongController : Controller
    {
        // GET: Song
        SongRepository songRepository = new SongRepository();
        public ActionResult GetAll()
        {
            List<Song> songs = songRepository.GetSongs();
            return View(songs);
        }

        public ActionResult SongDetails(int id)
        {
            Song song = songRepository.GetSong(id);
            return View(song);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Song song)
        {


            if (ModelState.IsValid)
            {

                songRepository.AddSong(song);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            songRepository.DeleteSong(id);
            return RedirectToAction("GetAll");
        }
        public ActionResult Edit(int id)
        {
            Song song = songRepository.GetSong(id);
            return View(song);
        }
        [HttpPost]
        public ActionResult Edit(Song song)
        {
            songRepository.EditSong(song);
            return RedirectToAction("GetAll");

        }
        public ActionResult Search()
        {
            List<Song> songs = songRepository.GetSongs();
            return View(songs);
        }
    }
}