using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryProject_3.TuningItems;
using CarFactoryProject_3.PartFactories;

namespace CarFactoryProject_3.PartFactories.CarBodyFactory
{
    class BodyFactory : IPartFactory
    {
        private List<Tuning> bodytuning = null;

        public List<Tuning> TuningForPart
        {
            get
            {
                this.bodytuning = new List<Tuning>();
                return this.bodytuning;
            }
        }

        public BodyFactory() {}
        
        public void CreatePart()
        {
            throw new NotImplementedException();
        }
    }
}
