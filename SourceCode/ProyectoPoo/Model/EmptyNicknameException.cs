using System;

namespace ProyectoPoo
{
    public class EmptyNicknameException : Exception
    {
        public EmptyNicknameException(string Message) : base(Message) { }

    }
}