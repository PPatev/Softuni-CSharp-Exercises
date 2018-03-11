﻿using System;
using System.Text.RegularExpressions;

namespace _4._Match_Dates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            var dateString = Console.ReadLine();
            var dates = Regex.Matches(dateString, regex);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
