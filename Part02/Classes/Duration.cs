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

        #region 4-Implement All required Operators overloading to enable this Code:
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration
            (
                d1.Hours + d2.Hours,
            d1.Minutes + d2.Minutes,
            d1.Seconds + d2.Seconds
            );
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration
            (
                d1.Hours - d2.Hours,
            d1.Minutes - d2.Minutes,
            d1.Seconds - d2.Seconds
            );
        }
        public static Duration operator +(Duration d1, int d2)
        {
            Duration d3 = new Duration(d2);

            return new Duration
            (
                d1.Hours + d3.Hours,
            d1.Minutes + d3.Minutes,
            d1.Seconds + d3.Seconds
            );
        }
        public static Duration operator +(int d1, Duration d2)
        {
            Duration d3 = new Duration(d1);

            return new Duration
            (
                d2.Hours + d3.Hours,
            d2.Minutes + d3.Minutes,
            d2.Seconds + d3.Seconds
            );
        }
        public static Duration operator ++(Duration d1)
        {
            int H = d1.Hours;
            int M = d1.Minutes + 1;

            if (M >= 60)
                M = 0;
                H++;
            return new Duration(H, M, d1.Seconds);
        }
        public static Duration operator --(Duration d1)
        {
            int H = d1.Hours;
            int M = d1.Minutes - 1;

            if (M < 0)
                M = 59;
            H = H > 0 ? H - 1 : 0;
            return new Duration(H, M, d1.Seconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1.Hours == d2.Hours)
                if (d1.Minutes == d2.Minutes)
                    return d1.Seconds > d2.Seconds;
                else if (d1.Minutes == d2.Minutes)
                    return d1.Seconds > d2.Seconds;
            return d1.Hours > d2.Hours;
        }
        public static bool operator <(Duration d1, Duration d2)
        {

            if (d1.Hours == d2.Hours)
                if (d1.Minutes == d2.Minutes)
                    return d1.Seconds < d2.Seconds;
                else if (d1.Minutes == d2.Minutes)
                    return d1.Seconds < d2.Seconds;
            return d1.Hours < d2.Hours;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            int Time1 = (d1.Hours * 3600)+ (d1.Minutes * 60) + d1.Seconds;
            int Time2 = (d2.Hours * 3600)+ (d2.Minutes * 60) + d2.Seconds;

            return Time1 >= Time2;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            int Time1 = (d1.Hours * 3600) + (d1.Minutes * 60) + d1.Seconds;
            int Time2 = (d2.Hours * 3600) + (d2.Minutes * 60) + d2.Seconds;

            return Time1 <= Time2;
        }

        public static bool operator true(Duration d1)
        {
            return d1.Hours !=0 || d1.Minutes != 0 || d1.Seconds != 0;
        }
        public static bool operator false(Duration d1)
        {
            return d1.Hours == 0 && d1.Minutes == 0 && d1.Seconds == 0;
        }

        public static explicit operator DateTime(Duration d1)
        {
            DateTime dateTime = DateTime.Today;// to Set Time (0, 0, 0)
            return dateTime.AddHours(d1.Hours).AddMinutes(d1.Minutes).AddMinutes(d1.Seconds);
            // I Searchd for bc if u used this (return new DateTime(2000, 1, 1, d.Hours, d.Minutes, d.Seconds);)
            // I'm gonna need to Set the (D, M, Y) and it will be static
        }

        #endregion

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
