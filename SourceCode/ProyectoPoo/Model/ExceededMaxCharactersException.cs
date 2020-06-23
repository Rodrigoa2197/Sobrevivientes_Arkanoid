using System;

namespace ProyectoPoo
{
    public class ExceededMaxCharactersException : Exception
    {
        public ExceededMaxCharactersException(string Message) : base(Message) { }

    }
}