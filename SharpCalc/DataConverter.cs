using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCalc
{
   public class DataConverter
    {
        public double ConvertToNumeric(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Must imput a numeric value");
            return convertedNumber;
        }
    }
}
