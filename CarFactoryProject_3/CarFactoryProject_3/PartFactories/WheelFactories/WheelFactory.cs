using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryProject_3.TuningItems;
using CarFactoryProject_3.PartFactories;

namespace CarFactoryProject_3.PartFactories.WheelFactories
{
    class WheelFactory : IPartFactory
    {
        private List<Tuning> wheeltuning = null;

        public List<Tuning> TuningForPart
        {
            get
            {
                this.wheeltuning = new List<Tuning>();
                return this.wheeltuning;
            }
        }
        
        public WheelFactory() {}
        
        public void CreatePart()
        {
            throw new NotImplementedException();
        }
    }
}
