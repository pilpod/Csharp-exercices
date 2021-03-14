using System;

public static class ResistorColor
{
    private static string[] colors = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    public static int ColorCode(string color)
    {

        int number = Array.IndexOf(colors, color);
        return number;
    }

    public static string[] Colors()
    {   
        return colors;
    }
}

