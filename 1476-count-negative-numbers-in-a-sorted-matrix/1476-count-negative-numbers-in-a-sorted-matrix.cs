public class Solution {
    public int CountNegatives(int[][] grid) {
     int count= 0;
     foreach(var g in grid)
     {
        Console.WriteLine(g);
        for(int i = 0 ; i < g.Length ; i++)
        {
            if(g[i] < 0)
            {
                count += Math.Abs(i - g.Length);
                Console.WriteLine(count);
                break;
            }
        }
      }  
      return count; 
    }
}