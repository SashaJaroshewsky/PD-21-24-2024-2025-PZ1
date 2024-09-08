using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz1
{
    internal class Tringle: BaseFigure
    {
        private float _a;
        private float _b;
        private float _c;

        
       

        public float A => _a;
        public float B => _b;
        public float C => _c;

        public Tringle(float a, float b, float c)
        {
            _a = a;
            _b = b; 
            _c = c;
        }

        
    }
}
