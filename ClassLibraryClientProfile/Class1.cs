﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryClientProfile
{
    public class Class1
    {
        public string Bar
        {
            get
            {
                return "Hello from ClassLibraryClientProfile " + typeof(Class1).AssemblyQualifiedName;
            }
        }
    }
}
