using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmsAndDataStructures
{
    public class BigONotation
    {
        // 7n3 + 3n2 + 5
        // We can express this as O(n3), as both 3n2 and 5 will become less relevant as n approaches infinity
        public void N3(int loop)
        {
            var lines = new List<string>();

            const int spacing = -10;
            
            for (int i = 0; i < loop; i++)
            {
                string cubed = $"{(7 * Math.Pow(i, 3)).ToString(), spacing}";
                string squared = $"{(3 * Math.Pow(i, 2)).ToString(), spacing}";
                string num = $"{5.ToString(), spacing}";
                string lineN = $"{i.ToString(), -5}";
                string line = $"n = {lineN} 7n3:  {cubed} 3n2:  {squared} 5:  {5}";
                lines.Add(line);
            }

            using StreamWriter file = new StreamWriter(@"n3.txt");
            foreach (string line in lines)
            {
                file.WriteLine(line);
            }
            
        }
        
    }
}