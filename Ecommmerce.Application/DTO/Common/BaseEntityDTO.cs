using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.DTO.Common
{
    public abstract class BaseEntityDTO<T>
    {
        public T Id { get; set; }   
    }
}
