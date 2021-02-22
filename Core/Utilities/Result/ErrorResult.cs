using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(bool success, string message) : base(success, message)
        {
        }

        public ErrorResult(bool success) : base(success)
        {
        }
    }
}
