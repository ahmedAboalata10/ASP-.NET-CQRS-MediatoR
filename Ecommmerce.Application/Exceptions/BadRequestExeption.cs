using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Exceptions
{
    public class BadRequestExeption :ApplicationException
    {
        public BadRequestExeption(string message) :base(message) { }
    }
}
