using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class MyTime
    {
        public  MyTime()
           {
                setHour(0);
                setMinute(0);
                setSecond(0);
           }
           public MyTime(int Hour)
           {
               setHour(Hour);
               setMinute(0);
               setSecond(0);
           }
           public MyTime(int Hour, int Minute)
           {
               setHour(Hour);
               setMinute(Minute);
               setSecond(0);
           }
           public MyTime(int Hour, int Minute, int Second)
           {
               setHour(Hour);
               setMinute(Minute);
               setSecond(Second);
           }
            

           private int Hour; // 0 - 23 (24-hour clock format)
           private int Minute; // 0 - 59
           private int Second;// 0 - 59
           public void setTime(int Hour, int Minute, int Second)
           {

                setHour(Hour);
                setMinute(Minute);
                setSecond(Second);
           }
           void setHour(int Hour)
           {
               if (Hour >= 0 && Hour < 24)

                   this.Hour = Hour;
               else
                   throw new ArgumentException("hour was out of range");

        }
        void setMinute(int Minute)
        {
            if (Minute >= 0 && Minute < 60)
                this.Minute = Minute;
            else
                throw new ArgumentException("minute was out of range");
        }

        void setSecond(int Second)
        {
            if (Second >= 0 && Second < 60)
                this.Second = Second;
            else
                throw new ArgumentException("second was out of range");
        }


         public void printUniversal()
        {
            Console.WriteLine("{0:00}:{1:00}:{2:00}", getHour(), getMinute(), getSecond());
        }
        public void printStarndard()
        {
            Console.WriteLine("{0:00}:{1:00}:{2:00} {3}", ((getHour() == 0 || getHour() == 12) ? 12 : getHour() % 12), getMinute(), getSecond(), getHour() < 12 ? "AM" : "PM");
        }

           public int getHour()
        {
            return Hour;
        }
        public int getMinute()
        {
            return Minute;
        }
        public int getSecond()
        {
            return Second;
        }

    }
}
