using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryProject_3.TuningItems;
using CarFactoryProject_3.PartFactories;

namespace CarFactoryProject_3.PartFactories.EngineFactories
{
    class EngineFactory : IPartFactory
    {
        private List<Tuning> enginetuning = null;

        public List<Tuning> TuningForPart
        {
            get
            {
                this.enginetuning = new List<Tuning>();
                return this.enginetuning;
            }
        }

        public EngineFactory() { }
        
        public void CreatePart()
        {
            throw new NotImplementedException();
        }
    }
}
