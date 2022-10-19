using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

        public static string pangrams(string s)
        {
           string alphabet = "abcdefghijklmnopqrstuvwxyz";
           bool pangran = true;

           for (int i = 0; i < alphabet.Length; i++)
           {
                pangran = s.ToLower().Contains(alphabet[i]);
                
                if (!pangran)
                {
                    return "not pangram";
                }
           }
           
            return "pangram";
        }
    }
}