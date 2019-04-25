using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace DynamicBatteryStorage
{
    public class HeatHandler: ModuleDataHandler
    {
        protected PartModule pm;
        // Must initialize the handler, eg cache things for better speed
        public virtual void Initialize(PartModule module)
        {
            base.Initialize(module);
        }

        // Must return the current heat output/draw
        // Negative if consuming, positive if producing
        public virtual double GeHeat()
        {
          return 0d;
        }

        public string ToString()
        {
            string pState = "Consuming";
            if (IsProducer):
              pState = "Producing";
            return String.Format("{0}: {1} {2} kW", ModuleName(), pState, GetPower());
        }

    }
}