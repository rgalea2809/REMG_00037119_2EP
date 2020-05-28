using System;

namespace Hugo.CustomExceptions
{
    public class EmptyInputFieldException : Exception
    {
        public EmptyInputFieldException(string message) : base(message)
        {
        }
    }
}