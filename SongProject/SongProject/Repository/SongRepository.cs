using SongProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace SongProject.Repository
{
    public class SongRepository
    {
        public SongDBContext db = new SongDBContext();

        // public object Server { get; private set; }

        public void AddSong(Song song)
        {

            db.Songs.Add(song);
            db.SaveChanges();
        }
        public List<Song> GetSongs()
        {
            return db.Songs.ToList();
        }
        public Song GetSong(int SongId)
        {
            return db.Songs.Find(SongId);
        }
        public void DeleteSong(int SongId)
        {
            Song song = db.Songs.Find(SongId);
            db.Songs.Remove(song);
            db.SaveChanges();
        }
        public void EditSong(Song song)
        {
            db.Entry<Song>(song).State = System.Data.Entity.EntityState.Modified; //record update in table
            db.SaveChanges();
        }
    }
}