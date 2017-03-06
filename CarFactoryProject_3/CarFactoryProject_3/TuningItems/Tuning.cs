using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryProject_3.TuningItems
{
    abstract class Tuning : CarFactoryProject_3.IItemPrice.IPrice
    {
        protected string name = "";
        protected float price = 0;

        public float Price { get { return this.price; } }

        public string Name { get { return this.name; } }
    }
}
