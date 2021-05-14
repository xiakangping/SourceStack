using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    //1.源栈的学费是按周计费的，所以请实现这两个功能：
    //  1.函数GetDate()，能计算一个日期若干（日/周/月）后的日期
    //  2.给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：

    class Datetime
    {
        static DateTime GetFirstMonday(int year)
        {
            DateTime date = new DateTime(year, 1, 1);
            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(1);
            }
            return date;
        } 
        static DateTime ShowWeeks(DateTime firsMonday)
        {
            int currenYear = firsMonday.Year;
            while (firsMonday.Year)
            {
                Console.WriteLine($"第(i+1)周");
                firsMonday = firsMonday.AddDays(7);
                i++;
            }
            for (int i = 0; i < 365/7; i++)
            {

            }
            return firsMonday;
        }
    }
}
