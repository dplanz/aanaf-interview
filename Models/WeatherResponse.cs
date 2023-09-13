using System.Collections.Generic;

namespace AANAF_Interview.Models
{
    public class WeatherResponse
    {
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Description { get; set; }
        public List<Forecast> Forecast { get; set; }
    }
}