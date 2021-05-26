using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyShare.Core.BLL.Infrastructure
{
    class ValidationException : Exception
    {
        public string Property { get; set; }

        public ValidationException(string propName, string message)
            :base(message)
        {
            Property = propName;
        }
    }
}
