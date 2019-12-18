using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCCastle.Models
{
    public class English : ILanguage
    {
        public string Message()
        {
            return "Hello world!";
        }
    }
}