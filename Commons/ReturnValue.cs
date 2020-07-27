using System;
using System.Collections.Generic;
using System.Text;

namespace Commons
{
    public class ReturnValue<T>
    {
        public bool isSuccess { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { set; get; }
    }
}
