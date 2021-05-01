using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int count;
        List<int> numbList = new List<int>();

        foreach (var item in multiples)
        {
            count = 0;
            for (int i = 0; i < max; i++)
            {
                if(item == 0) {
                    numbList.Add(0);
                }

                if(item != 0 && count % item == 0 && !numbList.Contains(count) && count < max) {
                    numbList.Add(count);
                }
                count++;
            }
        }

        int result = numbList.Sum();

        return result;
    }
}