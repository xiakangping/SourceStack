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
        public static void GetDateDate(DateTime initialtime,int number)
        {
            return initialtime.AddDays(number);
        }
        public static void GetDateGreat(DateTime initialtime,int number)
        {
            return initialtime.AddDays(number * 7);
        }
        public static void GetDateYear(DateTime initialtime, int number)
        {
            return initialtime.AddMoths(number);
        }
    }
}
