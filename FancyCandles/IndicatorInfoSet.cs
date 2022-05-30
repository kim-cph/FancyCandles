using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCandles
{
    public class IndicatorInfoSet : IIndicatorInfoSet
    {
        public IList<IIndicatorInfo> Infos { get; set; } = null;
    }
}
