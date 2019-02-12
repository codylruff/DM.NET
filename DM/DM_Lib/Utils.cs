using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Lib
{
    public static class Utils
    {
        public static string Left(string text, int charCount)
        {
            return text.Substring(text.Length - charCount, charCount);
        }

        public static string Right(string text, int charCount)
        {
            return text.Substring(0, charCount);
        }
    }
}
