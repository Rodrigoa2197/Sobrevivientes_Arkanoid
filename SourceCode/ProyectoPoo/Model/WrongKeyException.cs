using System;

namespace ProyectoPoo
{
    public class WrongKeyException : Exception
    {
        public WrongKeyException(string Message) : base(Message) { }

    }
}