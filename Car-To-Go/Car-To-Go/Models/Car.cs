using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string Fuel { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Traction { get; set; }
        public string Seats { get; set; }
        public bool AirConditioner { get; set; }
        public string Windows { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public int ConditionId { get; set; }
        public Condition Condition { get; set; }
        public int Price { get; set; }
        public string Comments { get; set; }

    }
}
