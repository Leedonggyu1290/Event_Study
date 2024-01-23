using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Study
{
    public class Calculation : CalculationBase
    {
        public delegate void EndCalculationHandler(object sender, int result);

        public event EndCalculationHandler EndCalculation;

        protected override bool OnBeginCalculation(int a, int b)
        {
            if (a < 0)
            {
                throw new Exception("A < 0");
            }

            if (b < 0)
            {
                throw new Exception("A < 0");
            }

            return true;
        }

        protected override int OnCalculation(int a, int b)
        {
            return a + b;
        }

        protected override void OnEndCalculation(int a, int b)
        {
            if (EndCalculation != null)
            {
                EndCalculation(this, this.calculationValue);
            }
        }

    }
}
