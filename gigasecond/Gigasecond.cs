using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime newDate = moment.AddSeconds(Math.Pow(10, 9));
        return newDate;
    }
}