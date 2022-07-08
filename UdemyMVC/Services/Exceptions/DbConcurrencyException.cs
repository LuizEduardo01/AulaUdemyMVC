using System;

namespace UdemyMVC.Services.Exceptions
{
    public class DbConcurrencyException : AccessViolationException
    {
        public DbConcurrencyException(string massege) : base(massege) 
        {
            
        }
    }
}
