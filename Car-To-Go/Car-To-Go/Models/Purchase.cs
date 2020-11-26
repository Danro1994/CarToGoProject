using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.Models
{
    public class Purchase
    {
        public Purchase(Model model, Brand brand)
        {
            Model = model;
            Brand = brand;
        }

        public Purchase(Car car, Model model, Photo photo, Status status, Seller seller, Condition condition)
        {
            Car = car;
            Model = model;
            Photo = photo;
            Status = status;
            Seller = seller;
            Condition = condition;
        }

        public Model Model { get; set; }
        public Brand Brand { get; set; }
        public Photo Photo { get; set; }
        public Status Status { get; set; }
        public Seller Seller { get; set; }
        public Condition Condition { get; set; }
        public Car Car { get; set; }

    }
}
