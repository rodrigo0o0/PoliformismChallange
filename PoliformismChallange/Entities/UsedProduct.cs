using System;
using System.Globalization;
namespace PoliformismChallange.Entities
{
    internal sealed class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }


        public override string PriceTag()
        {
            return base.Name + " $ " + base.Price.ToString("F2",CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufacturedDate.ToShortDateString();
        }
    }
}
