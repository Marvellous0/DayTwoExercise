using System;

namespace VowelReverse
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter string to reverse the vowel: ");
           string str = Console.ReadLine();

           Console.WriteLine(reverseVowel(str));
        }

         public static bool isVowel(char c) 
        {
            return (c == 'a' || c == 'A' || c == 'e'
                    || c == 'E' || c == 'i' || c == 'I'
                    || c == 'o' || c == 'O' || c == 'u'
                    || c == 'U');
        }
  
    // Function to reverse order of vowels
        static String reverseVowel(String str1)
        {
            int j = 0;
            
            // Storing the vowels separately
            char[] str = str1.ToCharArray();
            string vowel = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (isVowel(str[i]))
                {
                    j++;
                    vowel += str[i];
                }
            }
    
            // Placing the vowels in the reverse
            // order in the string
            for (int i = 0; i < str.Length; i++)
            {
                if (isVowel(str[i]))
                {
                    str[i] = vowel[--j];
                }
            }
    
            return String.Join("",str);
        }
    
    }
}
