using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoDevSuperiorPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        { 
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{this.Name} $ {(this.Price+this.CustomsFee).ToString("F2")} (Customs fee: $ {this.CustomsFee.ToString("F2")})";
        }
    }
}
