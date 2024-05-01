using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class Cart : Transport
    {
        public int Capacity { get; set; }
        public string Material { get; set; }

        public Cart(BaseInform baseInfo, int capacity, string material) : base(baseInfo)
        {
            Capacity = capacity;
            Material = material;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Capacity: {Capacity}, Material: {Material}";
        }
    }
}
