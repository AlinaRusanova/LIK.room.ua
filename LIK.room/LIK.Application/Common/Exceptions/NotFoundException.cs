using System;
using System.Collections.Generic;
using System.Text;


namespace LIK.Application.Common.Exceptions
{
  
        public class NotFoundException : Exception
    {
        public NotFoundException(String name, object key)
        : base($"Entity \"{name}\" {key} was not found.")
        { 
        }
    }
}
