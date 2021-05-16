using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioPropostoDevSuperiorPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            this.ManufactureDate = date;
        }

        public override string PriceTag()
        {
            return $"{this.Name} (used) $ {this.Price.ToString("F2")} (Manufature date: {this.ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
