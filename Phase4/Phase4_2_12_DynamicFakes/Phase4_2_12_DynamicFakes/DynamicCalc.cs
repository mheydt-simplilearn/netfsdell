using System;

namespace Phase4_2_12_DynamicFakes
{
    public interface IDynamicCalc
    {
        dynamic add(Object x, Object y);
    }

    public class DynamicCalc : IDynamicCalc
    {

        public dynamic add(Object x, Object y)
        {
            if (x.GetType().Name == "Int32" && y.GetType().Name == "Int32")
                return Convert.ToInt32((Int32)x + (Int32)y);
            else
                return Convert.ToInt32(0);
        }
    }
}
