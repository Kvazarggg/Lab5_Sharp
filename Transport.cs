using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class Transport
    {
        public BaseInform BaseInfo { get; set; }

        public Transport(BaseInform baseInfo)
        {
            BaseInfo = baseInfo;
        }

        public override string ToString()
        {
            return BaseInfo.ToString();
        }
    }
}
