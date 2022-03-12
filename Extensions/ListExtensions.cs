using System;
using System.Collections.Generic;

namespace RandomNaniClip.Extensions;

public static class ListExtensions
{
    public static void ShuffleMe<T>(this IList<T> list)
    {
        Random random = new();

        for (int i = list.Count - 1; i > 1; i--)
        {
            int rnd = random.Next(i + 1);

            (list[i], list[rnd]) = (list[rnd], list[i]);
        }
    }
}