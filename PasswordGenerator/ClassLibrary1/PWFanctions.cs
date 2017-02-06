using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class PWFanctions
    {
        private Random rnd = new Random();
        private List<string> l = new List<string>();
        private string str = string.Empty;
        public List<string> GetPassword(byte length, int count, int simbollenght, string[] arrsimbols)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    str += arrsimbols[rnd.Next(0, simbollenght)];
                }
                l.Add(str);
                str = string.Empty;
            }
            return l;
        }
    }
}
