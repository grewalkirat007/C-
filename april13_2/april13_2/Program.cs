using System;

namespace april13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            
            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine("Largest word : " + word);

            
            foreach (String s in words)
            {
                if (s.Length < ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine("Smallest word : " + word);

            
        }
    }
}
