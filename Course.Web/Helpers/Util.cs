using System;

namespace Course.Web.Helpers
{
    public sealed class Util
    {
        private Util()
        {

        }

        public static int ParseInt32(string input, int defaultValue)
        {
            if (input == null)
            {
                return defaultValue;
            }
            else
            {
                int output;

                if (Int32.TryParse(input, out output) == true)
                {
                    return output;
                }
                else
                {
                    return defaultValue;
                }
            }
        }

        public static bool ParseBool(string input, bool defaultValue)
        {
            if (input == null)
            {
                return defaultValue;
            }
            else
            {
                bool output;

                if (Boolean.TryParse(input, out output) == true)
                {
                    return output;
                }
                else
                {
                    return defaultValue;
                }
            }
        }

        public static DateTime ParseDateTime(string input, DateTime defaultValue)
        {
            if (input == null)
            {
                return defaultValue;
            }
            else
            {
                DateTime output;

                if (DateTime.TryParse(input, out output) == true)
                {
                    return output;
                }
                else
                {
                    return defaultValue;
                }
            }
        }

    }
}