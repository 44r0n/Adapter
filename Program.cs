﻿using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter(new Adaptee());
            target.Request();
        }
    }
}
