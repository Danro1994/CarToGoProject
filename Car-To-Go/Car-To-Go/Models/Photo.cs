using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public string Left { get; set; }
        public string Right { get; set; }
        public string Dashboard { get; set; }
        public string Backseat { get; set; }
        public string Trunk { get; set; }
        public string Hood { get; set; }
        public List<Car> Cars { get; set; }
    }
}
