using System;

namespace Domain.Exceptions
{
    public class SpaceAlreadyTakenException : Exception
    {
        public SpaceAlreadyTakenException()
        {
            
        }
        public SpaceAlreadyTakenException(string message) : base(message)
        {
            
        }
    }
}