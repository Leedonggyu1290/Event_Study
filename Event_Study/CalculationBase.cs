using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Study
{
    public class CalculationBase
    {
        protected int calculationValue;
        protected virtual int OnCalculation(int a, int b)
        {
            throw new Exception("구현하세요.");
        }

        protected virtual bool OnBeginCalculation(int a, int b)
        {
            return true;
        }

        protected virtual void OnEndCalculation(int a, int b)
        { 
        
        }

        public virtual void Calc(int a, int b)
        {
            if (OnBeginCalculation(a, b) == false)
                return;

            calculationValue =  OnCalculation(a, b);

            OnEndCalculation(a, b);
        }
    }
}
