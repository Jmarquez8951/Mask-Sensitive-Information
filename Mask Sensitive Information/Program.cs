using Microsoft.VisualBasic;
using System;

namespace Mask_Sensitive_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a secret.");
            var secret = Console.ReadLine();
            string final = "";

            secret.ToCharArray();
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret.Length - 4 > i)
                {
                    final += "*";
                } else
                {
                    final += secret[i];
                }
            }
            Console.WriteLine(final);
            Console.Read();
        }
    }
}
