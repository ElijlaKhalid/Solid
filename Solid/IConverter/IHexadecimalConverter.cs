﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.IConverter
{
    internal interface IHexadecimalConverter
    {
        string HexadecimalToText(string text);

        string TextToHexadecimal(string text);
    }
}