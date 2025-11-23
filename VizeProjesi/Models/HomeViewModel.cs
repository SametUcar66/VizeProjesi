using System.Collections.Generic;

namespace VizeProjesi.Models
{
    public class HomeViewModel
    {
        // vitrin filmi
        public Movie VitrinFilmi { get; set; }

        // film slider listesi
        public List<Movie> SliderFilmleri { get; set; }

        // haber listesi eklendi
        public List<News> Haberler { get; set; }
    }
}