using System;
using System.Globalization;

namespace ApiFury.Services
{
      public class AppException : Exception
    {
        public AppException() : base() {}
 
        public AppException(string message) : base(message) { }
 
        public AppException(string message, params object[] args) 
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}