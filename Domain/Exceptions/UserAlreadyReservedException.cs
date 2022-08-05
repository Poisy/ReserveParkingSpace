using System;

namespace Domain.Exceptions
{
    public class UserAlreadyReservedException : Exception
    {
        public UserAlreadyReservedException()
        {
            
        }
        public UserAlreadyReservedException(string message) : base(message)
        {
            
        }
    }
}