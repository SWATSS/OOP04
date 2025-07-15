using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02.Classes
{
    #region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion
        #region 3-Define All Required Constructors to Produce this output:
        public Duration(int hour, int minutes, int seconds)
        {
            Hours = hour;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            if (seconds > 0)
            {
                Hours = seconds / 3600;
                seconds = seconds % 3600;

                Minutes = seconds / 60;
                seconds = seconds % 60;

                Seconds = seconds;
            }
            else
            {
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
            }
        }


        #endregion
        #region 2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] .
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            if (Hours == 0)
                return $"Minutes:{Minutes}, Seconds :{Seconds}";
            else
                return $"Hours: {Hours}, Minutes:{Minutes}, Seconds :{Seconds}";

        }
        #endregion
    }

}
