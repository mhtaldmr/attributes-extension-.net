using System.Text;

namespace MuhammetAliDemir.TP.Net.Hw2.Part1.DateTimeExtension
{
    public static class DateTimeExtension
    {
        public static string AgoOrAfter(this DateTime date)
        {
            var currentDate = DateTime.Now;
            var builder = new StringBuilder();
            var difference = currentDate - date;
            //checking if the time is before or after
            var timeDiff = difference.TotalMilliseconds > 0 ? currentDate - date : date - currentDate;

            //checking if the results are plural or not
            var day = timeDiff.Days > 1 ? "days" : "day";
            var hour = timeDiff.Hours > 1 ? "hours" : "hour";
            var minute = timeDiff.Minutes > 1 ? "minutes" : "minute";

            //checking if one of the results are 0 or not.
            var diffday = timeDiff.Days > 0 ? $"{timeDiff.Days} {day} " : "";
            var diffhour = timeDiff.Hours > 0 ? $"{timeDiff.Hours} {hour} " : "";
            var diffminute = timeDiff.Minutes > 0 ? $"{timeDiff.Minutes} {minute} " : "";
            var lastWord = (diffday=="" && diffhour == "" && diffminute == "")
                    ? "Current Time!" : (difference.TotalMilliseconds > 0 ? "Ago!" : "After!");

            //return the result string after combine them
            return builder.Append(diffday)
                          .Append(diffhour)
                          .Append(diffminute)
                          .Append(lastWord)
                          .ToString();
        }
    }
}
