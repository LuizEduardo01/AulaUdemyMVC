using System;

namespace UdemyMVC.Services.Excepitons
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
