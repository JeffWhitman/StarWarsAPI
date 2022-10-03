using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StarWarsAPI.Models
{
    public class FilmModel
    {
        public FilmModel()
        {
            Characters = new List<string>();
        }
        public string Title { get; set; }
        [Display(Name = "Episode Id")]
        public string EpisodeId { get; set; }
        [Display(Name = "Opening Crawl")]
        public string OpeningCrawl { get; set; }
        public string Director { get; set; }
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public string ReleaseDate { get; set; }
        public string Url { get; set; }
        public List<string> Characters { get; set; }
    }
}

