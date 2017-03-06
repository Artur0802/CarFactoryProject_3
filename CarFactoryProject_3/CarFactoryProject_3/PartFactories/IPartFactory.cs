using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryProject_3.TuningItems;

namespace CarFactoryProject_3.PartFactories
{
    interface IPartFactory
    {
        void CreatePart();
        List<Tuning> TuningForPart;
    }
}
