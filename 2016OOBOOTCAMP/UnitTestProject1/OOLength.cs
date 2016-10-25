using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject1
{
    class OOLength
    {
        public readonly int value;
        public readonly string unit;

        public OOLength(int value, string unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public override bool Equals(object obj)
        {
            var currentValue = 0;
            var targetValue = 0;
            var targetObj = ((OOLength)obj);

            if (this.unit == "m")
            {
                currentValue = this.value * 100 * 10;
            }
            if (this.unit == "cm")
            {
                currentValue = this.value * 10;
            }
            if (this.unit == "mm")
            {
                currentValue = this.value;
            }

            if (targetObj.unit == "m")
            {
                targetValue = targetObj.value * 100 * 10;
            }
            if (targetObj.unit == "cm")
            {
                targetValue = targetObj.value * 10;
            }
            if (targetObj.unit == "mm")
            {
                targetValue = targetObj.value;
            }

            return currentValue == targetValue;
        }

    }
}
