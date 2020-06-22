using System;

namespace ProyectoPoo
{
    public class EmptyUsuarioException : Exception
    {
        public EmptyUsuarioException(string Message) : base(Message) { }
    }
}