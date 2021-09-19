using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace eBordo.Model.Helpers
{
    public class PasswordGenerator
    {
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        private string RandomSpecial(int size = 10)
        {
            const string SPECIALS = "!@£$%^&*()#€";

            char[] _password = new char[size];
            string charSet = "";
            System.Random _random = new Random();
            int counter;

            charSet += SPECIALS;

            for (counter = 0; counter < size; counter++)
            {
                _password[counter] = charSet[_random.Next(charSet.Length - 1)];
            }

            return String.Join(null, _password);
        }
        public string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public string GeneratePassword()
        {
            StringBuilder builder = new StringBuilder();

            Random random = new Random();
            int broj;
            bool special = false, lowerString = false, upperString = false, numbers = false;
            do
            {
                broj = random.Next(1, 5);
                if (broj == 1 && !special)
                {
                    builder.Append(RandomString(2, true));
                    builder.Append(RandomSpecial(2));
                    special = true;
                }
                if (broj == 2 && !lowerString)
                {
                    builder.Append(RandomString(2, false));
                    builder.Append(RandomNumber(1000, 9999));
                    lowerString = true;
                }
                if (broj == 3 && !upperString)
                {
                    builder.Append(RandomString(2, false));
                    builder.Append(RandomSpecial(2));
                    upperString = true;
                }
                if (broj == 4 && !numbers)
                {
                    builder.Append(RandomSpecial(2));
                    builder.Append(RandomString(2, true));
                    numbers = true;
                }
            } while (!special || !lowerString || !upperString || !numbers);

            return builder.ToString();
        }
    }
}
