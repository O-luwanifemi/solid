using Interfaces.ICount;

namespace Gadgets
{
    public class Gadget
    {
        public string Name { get; set; }
        public string Count { get; set; }
    }

    public class Desktop : Gadget, ICount
    {
        public double GetCount()
        {
            return 0;
        }
    }

    public class Laptop : Gadget, ICount
    {
        public double GetCount()
        {
            return 0;
        }
    }
}
