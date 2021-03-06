﻿using System;

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

    public class GenereConstants {
        public const string FEMENINO = "Femenino";
        public const string MASCULINO = "Masculino";
    }

    public class GenereShortConstants
    {
        public const string FEMENINO = "F";
        public const string MASCULINO = "M";
    }

    public class CategoryConstants
    {
        public const string PORTATILES = "Portátiles";
        public const string IMPRESION = "Impresión";
        public const string ALMACENAMIENTO = "Almacenamiento";
        public const string SOFTWARE = "Software";
        public const string TABLETS = "Tables";
    }

    public class CategoryShortConstants
    {
        public const string PORTATILES = "P";
        public const string IMPRESION = "I";
        public const string ALMACENAMIENTO = "A";
        public const string SOFTWARE = "S";
        public const string TABLETS = "T";
    }
}