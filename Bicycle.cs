using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class Bicycle : Transport
    {
        public int NumberOfGears { get; set; }
        public bool HasBasket { get; set; }

        public Bicycle(BaseInform baseInfo, int numberOfGears, bool HasBasket) : base(baseInfo)
        {
            NumberOfGears = numberOfGears;
            this.HasBasket = HasBasket;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, NumberOfGears: {NumberOfGears}, HasBasket: {HasBasket}";
        }
    }
}
