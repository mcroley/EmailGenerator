using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EmailGenerator
{
    class Program
    {
        // The List to hold all of the emails:
        static List<string> email = new List<string>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {                
                email.Add(RandomEmail());                   
            }
            for(int x = 0; x < email.Count; x++)
            {
                Console.WriteLine(email[x]);
            }
        }
        public static string  RandomEmail()
        {
            Random random = new Random();
            List<char> randomGeneratedString = new List<char>();
            int randomNumberBetween3and36 = random.Next(3, 10);

            for (int i = 0; i < randomNumberBetween3and36; i++)
            {              
                 randomGeneratedString.Add(GetFirstPartofEmail());
                 randomNumberBetween3and36 = random.Next(5, 15);
            }
            var firstPartofEmail = String.Concat(randomGeneratedString);
            var secondPartofEmail = GetSecondPartofEmail();
            string email = String.Concat(firstPartofEmail, secondPartofEmail) + System.Environment.NewLine;
            return email;
        }
        public static char GetFirstPartofEmail()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz1234567890.&-";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }
        public static string GetSecondPartofEmail()
        {
            string[] secondpartEmail = {"@hotmail.com", "@outlook.com", "@gmail.com", "@msn.com", "@nbc.com" , "@aol.com",
                "@firstbank.com", "@fed.gov"};
            
            Random randonSecond = new Random();
            return secondpartEmail[randonSecond.Next(0, secondpartEmail.Length - 1)];
        }
    }        
}
