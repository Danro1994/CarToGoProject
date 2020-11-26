using Car_To_Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.DomainService
{
    public class CarDomainService
    {
        public string GetCarDomainService(Car car)
        {
            if (car == null)
            {
                return "No se Encontro el Vehiculo";
            }
            return null;
        }

        public string PostCarDomainService(Purchase purchase)
        {
            if (purchase.Model == null)
            {
                return "El Modelo no existe";
            }
            if (purchase.Photo == null)
            {
                return "Estas fotografias no estan registradas";
            }
            if (purchase.Status == null)
            {
                return "El Estado no existe";
            }
            if (purchase.Seller == null)
            {
                return "El Vendedor no existe";
            }
            if (purchase.Condition == null)
            {
                return "La Condicion no existe";
            }
            if (purchase.Car.Year < 1950)
            {
                return "El vehiculo debe ser año 1950 en adelante";
            }

            return null;
        }

        public string PutCarDomainService(int id, Purchase purchase)
        {
            if (purchase.Car == null)
            {
                return "No se encuentra el Vehiculo";
            }
            if (purchase.Model == null)
            {
                return "El Modelo no existe";
            }
            if (purchase.Photo == null)
            {
                return "Estas fotografias no estan registradas";
            }
            if (purchase.Status == null)
            {
                return "El Estado no existe";
            }
            if (purchase.Seller == null)
            {
                return "El Vendedor no existe";
            }
            if (purchase.Condition == null)
            {
                return "La Condicion no existe";
            }

            return null;
        }

        public string DeleteCarDomainService(int id, Car car)
        {

            if (car == null)
            {
                return "No se encontro el Vehiculo";
            }

            return null;
        }
    }
}
