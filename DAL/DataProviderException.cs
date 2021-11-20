using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    [Serializable]
    public class DbConnectErrorException : Exception
    {
        public DbConnectErrorException() : base() { }
        public DbConnectErrorException(string message) : base(message) { }
        public DbConnectErrorException(string message, Exception innerException) : base(message, innerException) { }

    }
    [Serializable]
    public class DbInvalidParameterException : Exception
    {
        public DbInvalidParameterException() : base() { }
        public DbInvalidParameterException(string message) : base(message) { }
        public DbInvalidParameterException(string message, Exception innerException) : base(message, innerException) { }
    }
    
}
