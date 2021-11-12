using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.ICount;
using Interfaces.ICost;

namespace SOLIDTASK.Models
{
    public class Inventory
    {
        private List<ICost> _gadgets;
        private List<ICount> _countables;

        public Inventory(List<ICount> countables, List<ICost> gadgets)
        {
            _gadgets = gadgets;
            _countables = countables;
        }

        #region Total Count Of All Office Equipments
        public double GetTotalEquipmentCount()
        {
            var totalEquipments = 0d;

            foreach (var equipment in _countables)
            {
                totalEquipments += equipment.GetCount();
            }

            return totalEquipments;
        }
        #endregion


        #region Accumulated Cost Of All Gadgets
        public double GetGadgetsCost()
        {
            var overallCost = 0d;

            foreach (var gadget in _gadgets)
            {
                overallCost += gadget.GetCost();
            }

            return overallCost;
        }
        #endregion
    }
}
