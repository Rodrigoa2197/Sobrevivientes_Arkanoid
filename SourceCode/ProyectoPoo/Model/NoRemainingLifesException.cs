using System;

namespace ProyectoPoo
{
    public class NoRemainingLifesException : Exception
    {
        public NoRemainingLifesException(string Message) : base(Message) { }
    }
}