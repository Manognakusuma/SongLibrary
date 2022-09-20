using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongProject.Models
{
    [Table("Songs")]
    public class Song
    {
        [Key]
        [Required(ErrorMessage = "Id Required")]
        public int SongId { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "SongName Requied")]
        public string SongName { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "MovieName Requied")]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "Year Requied")]
        public int Year { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Lang Requied")]
        [DisplayName("Language")]
        public string Lang { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Actor Requied")]
        [DisplayName("Actors")]
        public string Actor { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "MusicDirector Requied")]
        public string MusicDirector { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "MovieDirector Requied")]
        public string MovieDirector { get; set; }
    }
}