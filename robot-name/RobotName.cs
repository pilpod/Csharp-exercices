using System;
using System.Collections.Generic;

public class Robot
{   
    private char[] alphabet =  {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    private string currentName;
    private bool nameSet = false;
    List<string> names = new List<string>();

    public string Name
    {
        get
        {
            while (!nameSet)
            {
                Random rnd = new Random();
                char firstChar = Char.ToUpper(alphabet[rnd.Next(26)]);
                char secondChar = Char.ToUpper(alphabet[rnd.Next(26)]);
                int digits = rnd.Next(100, 1000);
                string robotName = firstChar + secondChar.ToString() + digits;
                
                bool isInList = this.names.Contains(robotName);

                if(!isInList) {
                    this.names.Add(robotName);
                    this.currentName = robotName;
                    nameSet = true;
                }
            }

            return this.currentName;
        }
    }

    public void Reset()
    {
        nameSet = false;
    }
}