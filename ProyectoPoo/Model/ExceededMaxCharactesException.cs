using System;

namespace ProyectoPoo
{
    public class ExceededMaxCharactesException : Exception
    {
        public ExceededMaxCharactesException(string Message) : base(Message){ }
    }
}