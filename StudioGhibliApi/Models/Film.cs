using System;

namespace StudioGhibliApi.Models.Film
{
    ///
    public class Film
    {
        ///
        public int FilmId { get; set; }

        ///
        public string Title { get; set; } = string.Empty;

        ///
        public string Description { get; set; } = string.Empty;

        ///
        public string Director { get; set; } = string.Empty;

        ///
        public DateTime ReleaseDate { get; set; }
    }
}
