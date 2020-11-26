using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }

    }
}
