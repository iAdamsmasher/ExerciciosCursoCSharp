using System;
using System.Collections.Generic;
using System.Globalization;

namespace TemplateCodes
{
    class CasasDecimais
    {
        public double NumA { get; set; }
        public double NumB { get; set; }

        public CasasDecimais(double numA, double numb)
        {
            NumA = numA;
            NumB = numb;
        }

        public string casaDecimal()
        {
            return "A-"  + NumA.ToString(CultureInfo.InvariantCulture) + " B-" + NumB.ToString();
        }
    }
}
