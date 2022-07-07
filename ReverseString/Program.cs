using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "test";
            char[] arr = a.ToCharArray();
            char[] resarr = new char[arr.Length];

            for(int i=0, j = a.Length-1; i<a.Length -1; i++,j--)
            {
                resarr[i] = arr[j];
            }

        }
    }
}
