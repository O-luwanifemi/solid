using Interfaces.ICost;
using Interfaces.ICount;

namespace SOLIDTASK.Models
{
    public class Furniture
    {
        private double _cost;

        public string FurnitureType { get; set; }
        public string Status { get; set; }
        public double Cost { get => _cost; set {; } }
    }

    public class Chair : Furniture, ICost, ICount
    {
        public double GetCost()
        {
            return Cost;
        }

        public double GetCount()
        {
            return 0;
        }
    }

    public class Desk : Furniture, ICost, ICount
    {
        public double GetCost()
        {
            return Cost;
        }

        public double GetCount()
        {
            return 0;
        }
    }

    public class Cabinet : Furniture, ICost, ICount
    {
        public double GetCost()
        {
            return Cost;
        }

        public double GetCount()
        {
            return 0;
        }
    }
}
