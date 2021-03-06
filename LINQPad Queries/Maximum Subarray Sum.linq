<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    long[] a = {3,3,9,9,5};
     maximumSum (a,7).Dump();
    //long[] a = {354724723,116663117,1885681600,474513639,2048518168,1798715778,1154451359,560856756,1265212167,1048886968,639685644,1765763845,1962254641,1433464549,499924441,1054240376,1022523980,388882895,1541208731,970773431,1604797159,1508755786,352886413,1673921314,1488688549,422151782,1680803283,240145938,743965900,1827917457,1639906102,1098690623,1944580573,1378104053,1573204261,1845615092,1029336182,580171972,258988200,147064700,1629058939,898673843,1912828544,1443829931,184654743,265269336,350586658,1207178723,654152230,1891795388,30468505,111465741,1253067526,383354917,1785387054,594272426,805506698,1318706689,834418363,1549472597,999140497,326840816,500679571,796237422,1704944868,2073883832,494368865,586797401,506572155,753357064,733862100,2135631093,1652030907,499206995,1431977375,1836685649,764476331,1782564032,896380723,1418628560,1526875771,926849227,1530094300,632459648,1310204143,1167997706,1226732073,2115710840,339220746,2061150436,1517699789,1338361242,240507603,2018379359,2134598663,1945452471,1944779542,481483880,384766223,303868048};
    //maximumSum (a,1399760164).Dump();
}
static long maximumSum (long[] a, long m)
{
    int outerCount = 1;
    int outerTotal = a.Length;
    int innerCount = 0;
    long maxsum = 0;

    while (outerCount <= outerTotal)
    {
        innerCount = outerCount - 1;
        int diff = innerCount;
        while (innerCount >= 0)
        {
            int innerLoop = a.Length - diff;
            int start = innerCount;
            long sum =0;
            Console.WriteLine("Sart {0} innerLoop {1}", start, innerLoop);
            while (innerLoop > 0 && start < a.Length)
            {
               sum += a [start];
               Console.WriteLine("{0}, ", a [start]);
               start++;
               innerLoop--;
            }
            
            Console.Write("={0} ", sum);
            Console.WriteLine();
            innerCount--;
            maxsum = System.Math.Max (maxsum, sum % m);
        }
        outerCount++;
    }
    return maxsum;
}
// Define other methods, classes and namespaces here
