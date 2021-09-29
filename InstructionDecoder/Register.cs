using System;
using System.Collections.Generic;
using System.Text;

namespace InstructionDecoder
{
    class Register
    {
        public int Value { get; set; }
        public string Name { get; private set; }

        public Register(string name)
        {
            Value = 0;
            Name = name;
        }
    }
}
