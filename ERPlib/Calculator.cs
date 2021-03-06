﻿/************************************************************************************************************
 * Title: Calculator Class
 * Author: Sean Hinds
 * Date: 11/18/17
 * Description: Calculator static class implementation for the ERPlib library.
 ************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPlib
{
    static public class Calculator
    {
        public static DateTime addDaysToToday(double days)
        {
            DateTime x = DateTime.Today.AddDays(days);
            return x;
        }

        public static DateTime subDaysFromDate(double days, DateTime date)
        {
            DateTime x = date.AddDays((-1) * days);
            return x;
        }
    }
}
