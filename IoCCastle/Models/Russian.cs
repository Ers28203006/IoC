﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCCastle.Models
{
    public class Russian : ILanguage
    {
        public string Message()
        {
            return "Привет мир!";
        }
    }
}