using System;

namespace ProyectoPoo
{
    public class OutBoundsException : Exception
    {
        public OutBoundsException(string Message) : base(Message) { }

    }
}