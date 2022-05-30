using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCandles
{
    public interface IIndicatorInfoSet
    {
        public IList<IIndicatorInfo> Infos { get; set; }
    }

    public interface IIndicatorInfo
    {
    }
}
