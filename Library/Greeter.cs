using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Greeter : IGreeter
    {
        public string SayHello(string name)
        {
            return $"Why hello there {name}";
        }
    }
}
