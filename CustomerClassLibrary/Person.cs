﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerClassLibrary
{
    public abstract class Person
    {
        public abstract string FirstName 
        { 
            get; 
            set; 
        }
        public abstract string LastName
        {
            get;
            set;
        }       
    }
}
