using System;

namespace RedisGuiManager
{
    public class RedisConnectionFailedException : Exception
    {
        public RedisConnectionFailedException()
        {
        }

        public RedisConnectionFailedException(string message)
            : base(message)
        {
        }

        public RedisConnectionFailedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
