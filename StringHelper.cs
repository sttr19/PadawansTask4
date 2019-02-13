using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            int sum = 0;
            for (int i=0;i<str.Length;i++)
            {
                if (str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='o'||str[i]=='u')
                {
                    sum += 1;
                }
         
            }
            return sum;
        }
    }
}
