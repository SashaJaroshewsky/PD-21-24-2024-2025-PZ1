using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz1
{
    internal abstract class BaseFigure
    {
        TringleCalculator _tringleCalculator;

        public BaseFigure()
        {
            _tringleCalculator = new TringleCalculator();
        }
    }
}
