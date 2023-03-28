using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.Support
{
    public class Support
    {

        public static string GenerateRandomEmail()
        {
            return string.Format("{0}{1}@{2}.com", "sotwaretesteranna+", GenerateRandomNumberString(3), "testdomain");
        }



        public static string GenerateRandomNumberString(int length)
        {
            string allowedChars = "abcd1234567890";
            var rnd = SeedRandom();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rnd.Next(allowedChars.Length)];
            }

            return new string(chars);
        }

        private static Random SeedRandom()
        {
            return new Random(Guid.NewGuid().GetHashCode());
        }
    }
}
