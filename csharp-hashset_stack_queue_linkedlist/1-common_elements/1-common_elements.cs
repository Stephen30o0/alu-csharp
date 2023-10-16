using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        set1.IntersectWith(set2);
        List<int> commonElements = new List<int>(set1);
        commonElements.Sort();
        return commonElements;
    }
}
