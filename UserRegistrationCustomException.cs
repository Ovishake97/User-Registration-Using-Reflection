using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationReflection
{
   public class UserRegistrationCustomException:Exception
    {
        public enum ExceptionType { 
            EMPTY_FIELD,
            EMPTY_PATTERN,
            NULL_REFERENCE
        }
        public readonly ExceptionType type;
        public UserRegistrationCustomException(ExceptionType type,string message) :base(message)
        {
            this.type = type;
        }
    }
}
