using System;
using SOLIDTASK.Models;
using Interfaces.ICount;
using System.Collections.Generic;

namespace SOLIDTASK
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<ICount> countables = new List<ICount>() { new Gadgets(), new Furnitures() };
            var inventory = new Inventory();
        }
    }
}
